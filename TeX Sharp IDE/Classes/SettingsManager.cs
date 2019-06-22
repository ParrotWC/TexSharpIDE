using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TeX_Sharp_IDE
{
    public class Settings
    {
        // 0 - всё ок
        // 1 - нужно показать окно настроек
        public Int32 Code;
        public String LaTeXCompielerDirectory;
        public Int32 TimerInterval;
        public Boolean Prepocessor, Preview;
    }

    public class SettingsManager
    {
        String Settingsdir;

        public SettingsManager()
        {
            this.Settingsdir = @"%APPDATA%\TeXSharpIDEData";
        }

        public Settings LoadSettings()
        {
            Settings result = new Settings();

            CheckFileExistence();

            result.Code = 0;

            String[] lines = File.ReadAllLines(this.Settingsdir + "\\settings.txt");

            if(lines.Length != 4)
            {
                MessageBox.Show("Файл конфигурации повреждён и будет создан заново с настройками по умолчанию.");
                SetDefaultSettings();
                lines = File.ReadAllLines(this.Settingsdir + "\\settings.txt");
            }

            if(lines[0] == "")
            {
                result.LaTeXCompielerDirectory = "";
                result.Code = 1;
                MessageBox.Show("Для полноценной работы приложения, пожалуйста, укажите директорию с приложением pdflatex.exe (находится внутри установленного дистрибутива LaTeX).");
            }
            else
            {
                if (Directory.Exists(lines[0]))
                {
                    if (File.Exists(lines[0] + "\\pdflatex.exe"))
                    {
                        result.LaTeXCompielerDirectory = lines[0];
                    }
                    else
                    {
                        result.LaTeXCompielerDirectory = "";
                        result.Code = 1;
                        MessageBox.Show("В указанной директории, приложением pdflatex.exe не был найден. Компляция невозможна. Пожалуйста, укажите корректную директорию.");
                    }
                }
                else
                {
                    result.LaTeXCompielerDirectory = "";
                    result.Code = 1;
                    MessageBox.Show("Указанная директория с приложением pdflatex.exe больше не существует. Компляция невозможна. Пожалуйста, укажите корректную директорию.");
                }
            }

            try
            {
                int interval = Convert.ToInt32(lines[1]);

                if(interval > 10 | interval < 1)
                {
                    interval = 2;
                }

                result.TimerInterval = interval;
            }
            catch
            {
                result.TimerInterval = 2;
            }

            if(lines[2] == "1")
            {
                result.Prepocessor = true;
            }
            else
            {
                result.Prepocessor = false;
            }

            if (lines[3] == "1")
            {
                result.Preview = true;
            }
            else
            {
                result.Preview = false;
            }

            return result;
        }

        private void CheckFileExistence()
        {
            if(!Directory.Exists(this.Settingsdir))
            {
                Directory.CreateDirectory(this.Settingsdir);
            }

            if (!File.Exists(this.Settingsdir + "\\settings.txt"))
            {
                SetDefaultSettings();
            }
        }

        public void SetDefaultSettings()
        {
            using (FileStream fs = File.Create(this.Settingsdir + "\\settings.txt"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("\r\n2\r\n0\r\n0");
                fs.Write(info, 0, info.Length);
            }
        }

        public void SaveSettings(Settings _args)
        {
            using (FileStream fs = File.Create(this.Settingsdir + "\\settings.txt"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(_args.LaTeXCompielerDirectory + "\r\n" + _args.TimerInterval + "\r\n" + (_args.Prepocessor ? 1 : 0) + "\r\n" + (_args.Preview ? 1 : 0));
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
