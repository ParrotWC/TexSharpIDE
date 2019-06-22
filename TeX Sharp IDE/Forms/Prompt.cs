using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeX_Sharp_IDE.Forms
{
    public partial class Prompt : Form
    {
        MainForm MF;
        string md;

        public Prompt(MainForm _arg, string mode)
        {
            InitializeComponent();
            MF = _arg;
            md = mode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(md == "tex")
            {
                MF.AddTeX(this.textBox1.Text);
            }
            else
            {
                MF.AddTeXSharp(this.textBox1.Text);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
