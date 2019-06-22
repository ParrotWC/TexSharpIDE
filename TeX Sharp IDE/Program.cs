using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TeX_Sharp_IDE
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());//);new TeX_Sharp_IDE.Forms.Draw()
        }
    }
}
