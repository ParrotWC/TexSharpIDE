using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TeX_Sharp_IDE.Forms
{
    public partial class MML : Form
    {
        MainForm MF;
        String mainpath;

        public MML()
        {
            InitializeComponent();
        }

        public MML(MainForm _arg)
        {
            InitializeComponent();
            this.MF = _arg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpath = Application.ExecutablePath.Remove(Application.ExecutablePath.LastIndexOf('\\'));

            using (FileStream fs = File.Create(mainpath + "\\saxon\\in.mml"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(this.textBox1.Text);
                fs.Write(info, 0, info.Length);
            }

            try
            {
                String mml = mainpath + "\\saxon\\in.mml";
                String xslt = mainpath + "\\saxon\\bin\\pmml2tex\\pmml2tex.xsl";
                String output = mainpath + "\\saxon\\out.tex";

                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = mainpath + @"\saxon\bin\Transform.exe",
                        Arguments = "-o:\"" + output + "\" -s:\"" + mml + "\" -xsl:\"" + xslt + "\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        CreateNoWindow = true
                    }
                };

                proc.EnableRaisingEvents = true;
                proc.Exited += TransformCompleted;
                proc.Start();
            }
            catch
            {
                try
                {
                    File.Delete(mainpath + "\\saxon\\in.mml");
                    File.Delete(mainpath + "\\saxon\\out.tex");
                }
                catch
                {

                }
            }
        }

        private void TransformCompleted(Object sender, EventArgs e)
        {
            try
            {
                String result = File.ReadAllText(mainpath + "\\saxon\\out.tex");

                this.MF.controlMainTextBox.Text = this.MF.controlMainTextBox.Text.Insert(this.MF.controlMainTextBox.SelectionStart, result);

                this.Close();
            }
            catch
            {

            }
            finally
            {
                try
                {
                    File.Delete(mainpath + "\\saxon\\in.mml");
                    File.Delete(mainpath + "\\saxon\\out.tex");
                }
                catch
                {

                }
            }
        }
    }
}
