using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.RegularExpressions;

namespace TeX_Sharp_IDE
{
    public partial class MainForm : Form
    {
        public CompilationTuple CT;
        public WorkConditions WC;
        public SettingsManager SM;
        private TeXSharp.SyntaxPreprocessor SP;

        private System.Timers.Timer Timer;
        private Int32 TimerIntVal;
        public Int32 TimerInterval
        {
            get
            {
                return this.TimerIntVal;
            }

            set
            {
                if (value != this.TimerIntVal)
                {
                    this.TimerIntVal = value;
                    SetUpTimer();
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();

            this.CT = new CompilationTuple();
            this.WC = new WorkConditions();
            this.SM = new SettingsManager();
            this.SP = new TeXSharp.SyntaxPreprocessor();

            this.WC.LoadedDocs = new List<String>();
            this.WC.SelectedDoc = -1;
            Shown += MainForm_Shown;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(Object sender, EventArgs e)
        {
            //
            LoadSettings();
            this.WC.CurrentWorkMode = 0;
        }

        private void LoadSettings()
        {
            Settings sett = this.SM.LoadSettings();

            this.CT.LaTeXDirectory = sett.LaTeXCompielerDirectory;
            this.TimerInterval = sett.TimerInterval;
            this.WC.PreprocessorStatus = sett.Prepocessor;
            this.WC.PreviewStatus = sett.Preview;

            if (!sett.Preview)
            {
                tabPage1.Hide();
            }
            else
            {
                tabPage1.Show();
            }

            if(sett.Code == 1)
            {
                new CompieleSettingsForm(this).Show();
            }
        }    

        public void SaveSettings()
        {
            Settings setts = new Settings();
            setts.LaTeXCompielerDirectory = this.CT.LaTeXDirectory;
            setts.TimerInterval = this.TimerInterval;
            setts.Prepocessor = this.WC.PreprocessorStatus;
            setts.Preview = this.WC.PreviewStatus;
            if(!setts.Preview)
            {
                tabPage1.Hide();
            }
            else
            {
                tabPage1.Show();
            }
            this.SM.SaveSettings(setts);
        }

        private void SetUpTimer()
        {
            this.Timer = new System.Timers.Timer(this.TimerInterval * 1000);
            this.Timer.Elapsed += Timer_Elapsed;
            this.Timer.AutoReset = true;
            this.Timer.Enabled = true;
            this.Timer.Start();
        }

        private void Timer_Elapsed(Object sender, EventArgs e)
        {
            if(this.WC.PreprocessorStatus & this.WC.CurrentWorkMode != 0)
            {
                this.controlLaTeXTextOut.Text = this.SP.Transform(this.controlMainTextBox.Text).Result;
            }

            if (this.WC.PreviewStatus & this.WC.CurrentWorkMode != 0)
            {
                
            }
        }

        private void LoadMML2TeXCompieler()
        {
            
        }

        private void LoadFile(String _path)
        {
            this.WC.CurrentWorkObject = _path;
            this.Text = "TeX# - " + _path;
            this.WC.LoadedDocument = File.ReadAllText(_path);
            this.controlMainTextBox.Text = this.WC.LoadedDocument;
        }

        private void LoadFolder(String _path)
        {
            this.WC.CurrentWorkObject = _path;

            String[] scanresult = Directory.GetFiles(_path);

            String[] filename;
            
            foreach(String t in scanresult)
            {
                
                if (t.Substring(t.Length - 4) == ".tex" | t.Substring(t.Length - 9) == ".texsharp")
                {
                    this.WC.LoadedDocs.Add(File.ReadAllText(t));
                    filename = t.Split('\\');
                    this.controlFolderBrowse.Items.Add(filename[filename.Length - 1]);
                }
            }
        }

        private void SaveFile(String _path, String _text)
        {
            using (FileStream fs = File.Create(_path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(_text);
                fs.Write(info, 0, info.Length);
            }
        }

        // --- --- --- --- --- --- --- --- --- --- 
        // кастомизация интерфейса

        private void SwapInterfaceToSingleFileMode()
        {
            ClearAllFields();

            this.controlFolderBrowse.Visible = false;

            if (this.WC.CurrentWorkMode == 2 | this.WC.CurrentWorkMode == 0)
            {
                controlSplit.Width = controlSplit.Width + 226;
            }

            controlSplit.Location = new Point(12, 27);
            controlSplit.Visible = true;

            this.WC.CurrentWorkMode = 1;

            this.controlSave.Enabled = true;
            this.controlBuild.Enabled = true;
            this.controlSaveAll.Enabled = false;
            this.controlBuildSettings.Enabled = false;
        }

        private void SwapInterfaceToDirectoryMode()
        {
            ClearAllFields();

            if (this.WC.CurrentWorkMode == 1)
            {
                controlSplit.Width = controlSplit.Width - 226;
            }

            controlSplit.Location = new Point(238, 27);
            this.controlFolderBrowse.Visible = true;
            controlSplit.Visible = true;

            this.WC.CurrentWorkMode = 2;

            this.controlSave.Enabled = true;
            this.controlBuild.Enabled = true;
            this.controlSaveAll.Enabled = true;
            this.controlBuildSettings.Enabled = true;
        }

        private void ClearAllFields()
        {
            this.controlMainTextBox.Text = "";
            this.controlLaTeXTextOut.Text = "";
            this.controlErrorsTextOut.Text = "";
            this.controlWarningsTextOut.Text = "";
        }

        private void EnablePreview()
        {

        }

        private void DisablePreview()
        {

        }

        private void CompieleCurrent()
        {
            if (this.WC.CurrentWorkMode == 1)
            {
                toolStripStatus.Text = "Документ компилируется...";

                String obj = this.WC.CurrentWorkObject;

                if (obj.Split('.')[1] == "texsharp")
                {
                    obj = obj.Remove(obj.LastIndexOf('.')) + ".tex";
                    File.WriteAllText(obj, this.SP.Transform(this.controlMainTextBox.Text).Result, System.Text.Encoding.UTF8);
                }

                this.controlErrorsTextOut.Text = "";
                this.controlWarningsTextOut.Text = "";
                String[] res = this.CT.Compiele(obj);
                this.controlErrorsTextOut.Text = res[0];
                this.controlWarningsTextOut.Text = res[1];

                if (this.WC.CurrentWorkObject.Split('.')[1] == "texsharp")
                {
                    File.Delete(obj.Remove(obj.LastIndexOf('.')) + ".tex");
                }

                toolStripStatus.Text = "";
            }

            if (this.WC.CurrentWorkMode == 2)
            {
                toolStripStatus.Text = "Документ компилируется...";
                toolStripStatus.Text = "";
            }
        }

        // --- --- --- --- --- --- --- --- --- --- 
        // события контролов

        private void controlFileOpen_Click(Object sender, EventArgs e)
        {
            this.Timer.Stop();
            controlOpenFile.ShowDialog();
        }

        private void controlOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            this.WC.LoadedDocs = new List<String>();
            SwapInterfaceToSingleFileMode();
            LoadFile(this.controlOpenFile.FileName);
            this.Timer.Start();
        }

        private void controlFolderOpen_Click(Object sender, EventArgs e)
        {
            this.Timer.Stop();

            var openFolder = new CommonOpenFileDialog();
            openFolder.AllowNonFileSystemItems = true;
            openFolder.Multiselect = false;
            openFolder.IsFolderPicker = true;
            openFolder.Title = "";

            if (openFolder.ShowDialog() != CommonFileDialogResult.Ok)
            {
                MessageBox.Show("Директория не выбрана. Пожалуйста, повторите попытку.");
            }
            else
            {
                this.controlFolderBrowse.Items.Clear();
                this.WC.LoadedDocs = new List<String>();
                this.WC.SelectedDoc = -1;
                LoadFolder(openFolder.FileName);
                SwapInterfaceToDirectoryMode();
            }

            this.Timer.Start();
        }

        private void controlSave_Click(Object sender, EventArgs e)
        {
            if(this.WC.CurrentWorkMode == 1)
            {
                SaveFile(this.WC.CurrentWorkObject, this.controlMainTextBox.Text);

                if (this.Text.Substring(this.Text.Length - 2) == " *")
                {
                    this.Text = this.Text.Substring(0, this.Text.Length - 2);
                }
            }

            if(this.WC.CurrentWorkMode == 2 & this.WC.SelectedDoc != -1)
            {
                //MessageBox.Show(this.WC.CurrentWorkObject + "\\" + this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text.Replace(" *", ""));

                SaveFile(this.WC.CurrentWorkObject + "\\" + this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text.Replace(" *", ""), this.controlMainTextBox.Text);

                if (this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text.Substring(this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text.Length - 2) == " *")
                {
                    this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text = this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text.Substring(0, this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text.Length - 2);
                }
            }
        }

        private void controlSaveAll_Click(Object sender, EventArgs e)
        {
            for(Int32 i = 0; i < this.controlFolderBrowse.Items.Count; i++)
            {
                if(this.WC.SelectedDoc == i)
                {
                    SaveFile(this.WC.CurrentWorkObject + "\\" + this.controlFolderBrowse.Items[i].Text.Replace(" *", ""), this.controlMainTextBox.Text);
                }
                else
                {
                    SaveFile(this.WC.CurrentWorkObject + "\\" + this.controlFolderBrowse.Items[i].Text.Replace(" *", ""), this.WC.LoadedDocs[i]);
                }

                this.controlFolderBrowse.Items[i].Text = this.controlFolderBrowse.Items[i].Text.Replace(" *", "");
            }
        }

        private void controlCreateTeX_Click(object sender, EventArgs e)
        {
            if(this.WC.CurrentWorkMode == 2)
            {
                new TeX_Sharp_IDE.Forms.Prompt(this, "tex").Show();
            }
            else
            {
                controlSaveFileTeX.ShowDialog();
            }
        }

        private void controlCreateTeXSharp_Click(object sender, EventArgs e)
        {
            if (this.WC.CurrentWorkMode == 2)
            {
                new TeX_Sharp_IDE.Forms.Prompt(this, "texsharp").Show();
            }
            else
            {
                controlSaveFileTeXSharp.ShowDialog();
            }
        }

        private void controlSaveFileTeX_FileOk(object sender, CancelEventArgs e)
        {
            File.Create(controlSaveFileTeX.FileName);


        }

        private void controlSaveFileTeXSharp_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void AddTeX(String fn)
        {
            File.WriteAllText(this.WC.CurrentWorkObject + "\\" + fn + ".tex", "");

            this.controlFolderBrowse.Items.Add(fn + ".tex");

            this.WC.LoadedDocs.Add("");
        }

        public void AddTeXSharp(String fn)
        {
            File.WriteAllText(this.WC.CurrentWorkObject + "\\" + fn + ".texsharp", "");

            this.controlFolderBrowse.Items.Add(fn + ".texsharp");

            this.WC.LoadedDocs.Add("");
        }

        private void controlBuildSettings_Click(Object sender, EventArgs e)
        {

        }

        private void controlBuild_Click(Object sender, EventArgs e)
        {
            CompieleCurrent();
            ReloadPdf();
        }

        private void ReloadPdf()
        {
            axAcroPDF1.src = "file:///" + this.WC.CurrentWorkObject.Split('.')[0] + ".pdf";
        }

        private void controlSettings_Click(object sender, EventArgs e)
        {
            new CompieleSettingsForm(this).Show();
        }

        private void controlHelp_Click(Object sender, EventArgs e)
        {
            
        }

        private void controlOpenDirectory_HelpRequest(object sender, EventArgs e)
        {

        }

        private void controlFolderBrowse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.controlFolderBrowse.SelectedIndices.Count != 0)
            {
                if(this.WC.SelectedDoc != -1)
                {
                    this.WC.LoadedDocs[this.WC.SelectedDoc] = this.controlMainTextBox.Text;
                }

                ClearAllFields();

                this.controlMainTextBox.Text = this.WC.LoadedDocs[this.controlFolderBrowse.SelectedIndices[0]];
                this.WC.SelectedDoc = this.controlFolderBrowse.SelectedIndices[0];
            }
        }

        private void controlMainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.WC.CurrentWorkMode == 1)
            {
                if (this.Timer.Enabled)
                {
                    if (this.Text[this.Text.Length - 1] != '*')
                    {
                        this.Text += " *";
                    }
                }
            }

            if(this.WC.CurrentWorkMode == 2)
            {
                if (this.WC.SelectedDoc == this.controlFolderBrowse.SelectedIndices[0])
                {
                    if(this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text[this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text.Length - 1] != '*')
                    {
                        this.controlFolderBrowse.Items[this.WC.SelectedDoc].Text += " *";
                    }
                }
            }

            try
            {
                if (this.Timer.Enabled)
                {
                    if (this.controlMainTextBox.Text[this.controlMainTextBox.SelectionStart - 1] == '{')
                    {
                        Int32 selection = this.controlMainTextBox.SelectionStart;
                        this.controlMainTextBox.Text = this.controlMainTextBox.Text.Insert(this.controlMainTextBox.SelectionStart, "}");
                        this.controlMainTextBox.SelectionStart = selection;
                    }

                    /*if (this.controlMainTextBox.Text[this.controlMainTextBox.SelectionStart - 1] == '\n' & this.controlMainTextBox.Text[this.controlMainTextBox.SelectionStart - 2] == '{')
                    {
                        Int32 selection = this.controlMainTextBox.SelectionStart;
                        String currline = this.controlMainTextBox.Lines[this.controlMainTextBox.GetLineFromCharIndex(selection - 1)];
                        Int32 countoftabs = (currline.Length - currline.Replace("    ", "").Length) / "    ".Length;

                        this.controlMainTextBox.Text = this.controlMainTextBox.Text.Insert(this.controlMainTextBox.SelectionStart, new String(' ', countoftabs * 4) + "    \n" + new String(' ', countoftabs * 4));
                        this.controlMainTextBox.Text = this.controlMainTextBox.Text.Insert(selection - 2, "\n" + new String(' ', countoftabs * 4));
                        this.controlMainTextBox.SelectionStart = selection + 19 + countoftabs * 3;//(selection + countoftabs) * 5 + 14;
                    }

                    if (this.controlMainTextBox.Text[this.controlMainTextBox.SelectionStart - 1] == '\n' & this.controlMainTextBox.Text[this.controlMainTextBox.SelectionStart - 2] != '{')
                    {
                        Int32 selection = this.controlMainTextBox.SelectionStart;
                        String currline = this.controlMainTextBox.Lines[this.controlMainTextBox.GetLineFromCharIndex(selection - 1)];
                        Int32 countoftabs = (currline.Length - currline.Replace("    ", "").Length) / "    ".Length;

                        String oldstr  = this.controlMainTextBox.Lines[this.controlMainTextBox.GetLineFromCharIndex(selection)];

                        for(int i = 0; i < countoftabs; i++)
                        {
                            oldstr = "    " + oldstr;
                        }

                        this.controlMainTextBox.Text = this.controlMainTextBox.Text.Insert(selection, oldstr);
                        this.controlMainTextBox.SelectionStart = selection + countoftabs * 4;
                    }*/
                }
            }
            catch
            {

            }
            
        }


        private int CountWords(string s, string s0)
        {
            int count = (s.Length - s.Replace(s0, "").Length) / s0.Length;
            return count;
        }


        private void Keyup(Object sender, KeyEventArgs e)
        {
            
        }

        private void controlUndo_Click(object sender, EventArgs e)
        {

        }

        private void controlRedo_Click(object sender, EventArgs e)
        {

        }

        private void controlMML_Click(object sender, EventArgs e)
        {
            if(this.WC.CurrentWorkMode != 0)
            {
                new TeX_Sharp_IDE.Forms.MML(this).Show();
            }
        }

        private void controlGraph_Click(object sender, EventArgs e)
        {
            new TeX_Sharp_IDE.Forms.PreDraw(this).Show();
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            this.axAcroPDF1.Dispose();
        }
    }
}
