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
    public partial class PreDraw : Form
    {
        MainForm MF;

        public PreDraw(MainForm _arg)
        {
            InitializeComponent();
            MF = _arg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw dr = new Draw(MF);

            Int32 x, y;
            x = Convert.ToInt32(textBox1.Text) * 38;
            y = Convert.ToInt32(textBox2.Text) * 38;

            dr.Width = 680 + (x > 680 ? x - 680 : 0);
            dr.Height = 560 + (y > 560 ? y - 560 : 0);
            dr.controlDrawPanel.Width = x;
            dr.controlDrawPanel.Height = y;
            dr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }


    }
}
