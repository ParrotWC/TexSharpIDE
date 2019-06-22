using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TeX_Sharp_IDE
{
    public class CompilationTuple
    {
        private Process Compieler;

        private Boolean CurrentCompiling;

        public String TempDir, ResultDir, LaTeXDir;
        public String LaTeXDirectory
        {
            get
            {
                return this.LaTeXDir;
            }
            
            set
            {
                if (value != "" & this.LaTeXDir != value)
                {
                    this.LaTeXDir = value;
                    LoadCompieler();
                }
            }
        }

        private void LoadCompieler()
        {
            
        }

        public String[] Compiele(String _inp)
        {
            if(!this.CurrentCompiling)
            {
                String errors = "", warnings = "";

                String path = _inp.Remove(_inp.LastIndexOf('\\'));

                String res = path, aux = path;

                this.Compieler = new Process();
                this.Compieler.StartInfo.FileName = this.LaTeXDir + "\\pdflatex.exe";
                this.Compieler.StartInfo.Arguments = "-halt-on-error -output-directory=\"" + res + "\" -aux-directory=\"" + aux + "\" \"" + _inp + "\"";//  
                this.Compieler.StartInfo.CreateNoWindow = true;
                this.Compieler.StartInfo.UseShellExecute = false;
                this.Compieler.StartInfo.RedirectStandardOutput = true;

                this.CurrentCompiling = true;

                this.Compieler.Start();

                String str;

                while (!this.Compieler.StandardOutput.EndOfStream)
                {
                    str = this.Compieler.StandardOutput.ReadLine();

                    try
                    {
                        if (str.Substring(0, 2) == "! ")
                        {
                            errors += str + "\n";
                        }

                        if (str[0] != '(')
                        {
                            //warnings += str + "\n";
                        }
                    }
                    catch
                    {

                    }
                }

                this.CurrentCompiling = false;

                return new String[2] { errors, warnings };
            }
            else
            {
                return new String[2] { "", "" };
            }
        }
    }
}
