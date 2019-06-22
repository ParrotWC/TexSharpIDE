using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TeX_Sharp_IDE
{
    public partial class CompieleSettingsForm : Form
    {
        MainForm MainForm;
        bool allok;

        public CompieleSettingsForm(MainForm _MainForm)
        {
            InitializeComponent();
            this.MainForm = _MainForm;
            LoadSettings();
        }

        private void LoadSettings()
        {
            controlPDFLaTeXPath.Text = this.MainForm.CT.LaTeXDirectory;
            controlInterval.Text = this.MainForm.TimerInterval + "";
            controlActivePreprocessor.Checked = this.MainForm.WC.PreprocessorStatus;
            controlActivePreview.Checked = this.MainForm.WC.PreviewStatus;
        }

        private void SaveSettings()
        {
            if (Directory.Exists(controlPDFLaTeXPath.Text))
            {
                if (File.Exists(controlPDFLaTeXPath.Text + "\\pdflatex.exe"))
                {
                    this.MainForm.CT.LaTeXDirectory = controlPDFLaTeXPath.Text;
                }
                else
                {
                    this.allok = false;
                    MessageBox.Show("В выбранной вами директории отсутствует процесс pdflatex.exe. Изменения не сохранены.");
                }
            }
            else
            {
                this.allok = false;
                MessageBox.Show("В выбранной вами директория отсутствует. Изменения не сохранены.");
            }

            Int32 interval = 2;
            
            try
            {
                interval = Convert.ToInt32(controlInterval.Text);
            }
            catch
            {

            }

            if(interval > 10 | interval < 1)
            {
                interval = 2;
            }

            this.MainForm.TimerInterval = interval;

            this.MainForm.WC.PreprocessorStatus = controlActivePreprocessor.Checked;
            this.MainForm.WC.PreviewStatus = controlActivePreview.Checked;

            this.MainForm.SaveSettings();
        }

        // --- --- --- --- --- --- --- --- --- --- 

        private void label1_Click(Object sender, EventArgs e)
        {

        }

        private void controlOpenPDFLaTeXFile_Click(Object sender, EventArgs e)
        {
            SelectLaTeXDir();
        }

        private void SelectLaTeXDir()
        {
            if (LaTeXDirDia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(LaTeXDirDia.SelectedPath))
                {
                    if (File.Exists(LaTeXDirDia.SelectedPath + "\\pdflatex.exe"))
                    {
                        controlPDFLaTeXPath.Text = LaTeXDirDia.SelectedPath;
                    }
                    else
                    {
                        MessageBox.Show("В выбранной вами директории отсутствует процесс pdflatex.exe. Повторите попытку.");
                        SelectLaTeXDir();
                    }
                }
                else
                {
                    MessageBox.Show("В выбранной вами директория отсутствует. Повторите попытку.");
                    SelectLaTeXDir();
                }
            }
        }

        private void LaTeXDirDia_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void controlOk_Click(Object sender, EventArgs e)
        {
            this.allok = true;

            SaveSettings();

            if(this.allok)
            {
                this.Close();
            }
        }

        private void controlApply_Click(Object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void controlDeny_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
