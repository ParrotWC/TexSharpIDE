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
    public partial class Draw : Form
    {
        public class Shape
        {
            public String type;
            public Int32 x, y, xn, yn;
            public Point[] pts;

            public Shape(String _type, Int32 _x, Int32 _y, Int32 _xn, Int32 _yn)
            {
                this.type = _type;
                this.x = _x;
                this.y = _y;
                this.xn = _xn;
                this.yn = _yn;
            }

            public Shape(String _type, Point[] _pts)
            {
                this.type = _type;
                this.pts = _pts;
            }
        }

        Graphics gr, gb;
        Boolean workmode, isinwork; // workmode - true, если руками, false, если с параметрами
        Int32 Tool, weight;
        Int32? x, y;//, nx, ny;
        List<Point> points;

        List<Shape> Shapes;

        Bitmap buf;

        MainForm MF;

        public Draw(MainForm _arg)
        {
            InitializeComponent();

            MF = _arg;

            this.buf = new Bitmap(controlDrawPanel.Width, controlDrawPanel.Height);
            this.gb = Graphics.FromImage(buf);
            this.gb.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            this.gr = controlDrawPanel.CreateGraphics();
            this.gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            this.Shapes = new List<Shape>();
            this.workmode = true;
            this.isinwork = false;
            this.Tool = 0;
            this.weight = 1;

            this.x = null;
            this.y = null;

            points = new List<Point>();
        }

        private void MainForm_Shown(Object sender, EventArgs e)
        {
            

            /*controlTools.Items[0].Selected = true;
            controlTools.Items[0].Focused = true;*/

            /*controlTools.Items[0].Selected = true;
            controlTools.Select();
            controlTypes.Select();*/

            /*using (Graphics graphics = Graphics.FromHwnd(IntPtr.Zero))
            {
                float dpiX = graphics.DpiX;
                float dpiY = graphics.DpiY;

                //MessageBox.Show(dpiX + " " + dpiY);
            }*/
        }

        // -----------------
        // рисование
        // -----------------

        private void DrawRectangle(Boolean _place, Int32 _x, Int32 _y)
        {
            DrawRectangle(_place, this.x.Value, this.y.Value, _x, _y);
        }

        private void DrawRectangle(Boolean _place, Int32 _xn, Int32 _yn, Int32 _x, Int32 _y)
        {
            Int32 startx, starty, w, h, x0, y0;

            x0 = _xn;
            y0 = _yn;

            if (x0 < _x)
            {
                startx = x0;
                w = _x - startx;
            }
            else
            {
                startx = _x;
                w = x0 - startx;
            }

            if (y0 < _y)
            {
                starty = y0;
                h = _y - starty;
            }
            else
            {
                starty = _y;
                h = y0 - starty;
            }

            if (_place)
            {
                using (Pen p = new Pen(Brushes.Black, this.weight))
                {
                    gr.DrawRectangle(p, startx, starty, w, h);
                }
            }
            else
            {
                using (Pen p = new Pen(Brushes.Black, this.weight))
                {
                    gb.DrawRectangle(p, startx, starty, w, h);
                }
            }
        }

        private void DrawCircle(Boolean _place, Int32 _x, Int32 _y)
        {
            DrawCircle(_place, this.x.Value, this.y.Value, _x, _y);
        }

        private void DrawCircle(Boolean _place, Int32 _xn, Int32 _yn, Int32 _x, Int32 _y)
        {
            Int32 startx, starty, w, h, x0, y0;
            
            x0 = _xn;
            y0 = _yn;

            if (x0 < _x)
            {
                startx = x0;
                w = _x - startx;
            }
            else
            {
                startx = _x;
                w = x0 - startx;
            }

            if (y0 < _y)
            {
                starty = y0;
                h = _y - starty;
            }
            else
            {
                starty = _y;
                h = y0 - starty;
            }

            if (_place)
            {
                using (Pen p = new Pen(Brushes.Black, this.weight))
                {
                    gr.DrawEllipse(p, new Rectangle(startx, starty, w, w));
                }
            }
            else
            {
                using (Pen p = new Pen(Brushes.Black, this.weight))
                {
                    gb.DrawEllipse(p, new Rectangle(startx, starty, w, w));
                }
            }
        }

        private void DrawEllipce(Boolean _place, Int32 _x, Int32 _y)
        {
            DrawEllipce(_place, this.x.Value, this.y.Value, _x, _y);
        }

        private void DrawEllipce(Boolean _place, Int32 _xn, Int32 _yn, Int32 _x, Int32 _y)
        {
            Int32 startx, starty, w, h, x0, y0;

            x0 = _xn;
            y0 = _yn;

            if (x0 < _x)
            {
                startx = x0;
                w = _x - startx;
            }
            else
            {
                startx = _x;
                w = x0 - startx;
            }

            if (y0 < _y)
            {
                starty = y0;
                h = _y - starty;
            }
            else
            {
                starty = _y;
                h = y0 - starty;
            }

            if (_place)
            {
                using (Pen p = new Pen(Brushes.Black, this.weight))
                {
                    gr.DrawEllipse(p, new Rectangle(startx, starty, w, h));
                }
            }
            else
            {
                using (Pen p = new Pen(Brushes.Black, this.weight))
                {
                    gb.DrawEllipse(p, new Rectangle(startx, starty, w, h));
                }
            }
        }

        // -----------------
        // мышь
        // -----------------

        private void controlDrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isinwork = true;
            x = e.X;
            y = e.Y;

            if(workmode) // если руками
            {

            }
            else
            {

            }
        }

        private void controlDrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = "X: " + e.X;
            labelY.Text = "Y: " + e.Y;

            if(isinwork)
            {
                gr.Clear(Color.White);
                gr.DrawImage((Image)buf, new Point(0, 0));

                if (this.workmode)
                {
                    if(Tool == 0)
                    {
                        using (Pen p = new Pen(Brushes.Black, this.weight))
                        {
                            gr.DrawLine(p, new Point(x ?? e.X, y ?? e.Y), new Point(e.X, e.Y));
                        }
                    }
                    
                    if(Tool == 2)
                    {
                        DrawRectangle(true, e.X, e.Y);
                    }

                    if (Tool == 3)
                    {
                        DrawCircle(true, e.X, e.Y);
                    }

                    if (Tool == 4)
                    {
                        DrawEllipce(true, e.X, e.Y);
                    }
                }
                else
                {
                    labelY.Text = workmode.ToString();
                }
            }
        }

        private void controlDrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            using (Pen p = new Pen(Brushes.Black, this.weight))
            {
                if (Tool == 1)
                {
                    labelY.Text = points.Count + "";

                    points.Add(new Point(e.X, e.Y));

                    if (points.Count == 4)
                    {
                        gr.Clear(Color.White);
                        gr.DrawImage((Image)buf, new Point(0, 0));
                        gr.DrawCurve(p, points.ToArray());

                        this.Shapes.Add(new Shape("curve", points.ToArray()));

                        gb.DrawCurve(p, points.ToArray());

                        points = new List<Point>();

                        controlLayers.Items.Clear();

                        for (int i = 0; i < Shapes.Count; i++)
                        {
                            controlLayers.Items.Add("Слой" + (i + 1));
                        }
                    }
                    else
                    {
                        if (points.Count > 1)
                        {
                            gr.Clear(Color.White);
                            gr.DrawImage((Image)buf, new Point(0, 0));
                            gr.DrawCurve(p, points.ToArray());
                        }
                    }
                }
                else
                {
                    if (Tool == 0)
                    {
                        gb.DrawLine(p, new Point(x.Value, y.Value), new Point(e.X, e.Y));
                        this.Shapes.Add(new Shape("line", x.Value, y.Value, e.X, e.Y));
                    }

                    if (Tool == 2)
                    {
                        DrawRectangle(false, e.X, e.Y);
                        this.Shapes.Add(new Shape("rect", x.Value, y.Value, e.X, e.Y));
                    }

                    if (Tool == 3)
                    {
                        DrawCircle(false, e.X, e.Y);
                        this.Shapes.Add(new Shape("circ", x.Value, y.Value, e.X, e.X));
                    }

                    if (Tool == 4)
                    {
                        DrawEllipce(false, e.X, e.Y);
                        this.Shapes.Add(new Shape("ell", x.Value, y.Value, e.X, e.Y));
                    }

                    controlLayers.Items.Clear();

                    for (int i = 0; i < Shapes.Count; i++)
                    {
                        controlLayers.Items.Add("Слой" + (i + 1));
                    }
                    
                }
            }
            
            if (workmode)
            {

            }
            else
            {

            }

            this.isinwork = false;
            x = null;
            y = null;
        }

        private void controlDrawPanel_MouseLeave(object sender, EventArgs e)
        {
            labelX.Text = "";
            labelY.Text = "";
        }

        // -----------------
        // контролы
        // -----------------

        private void controlTools_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void controlTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void controlLayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void controlDrawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void controlComplete_Click(object sender, EventArgs e)
        {
            String output = "\\begin{tikzpicture}\n";

            foreach(Shape t in Shapes)
            {
                if(t.type == "line") // готово
                {
                    Double sx, sy, ex, ey;
                    String x1, y1, x2, y2;

                    sx = t.x * 0.747213;
                    sy = (this.controlDrawPanel.Height - t.y) * 0.747213;
                    ex = t.xn * 0.747213;
                    ey = (this.controlDrawPanel.Height - t.yn) * 0.747213;

                    x1 = sx.ToString().Replace(",", ".") + "pt";
                    y1 = sy.ToString().Replace(",", ".") + "pt";
                    x2 = ex.ToString().Replace(",", ".") + "pt";
                    y2 = ey.ToString().Replace(",", ".") + "pt";

                    output += "\\draw (" + x1 + "," + y1 + ") -- (" + x2 + "," + y2 + ");";
                }

                if(t.type == "curve")
                {
                    Double x1, y1, x2, y2, x3, y3;
                    String sx1, sy1, sx2, sy2, sx3, sy3;

                    if(t.pts.Length == 3)
                    {
                        x1 = t.pts[0].X * 0.747213;
                        y1 = (this.controlDrawPanel.Height - t.pts[0].Y) * 0.747213;
                        x2 = t.pts[1].X * 0.747213;
                        y2 = (this.controlDrawPanel.Height - t.pts[1].Y) * 0.747213;
                        x3 = t.pts[2].X * 0.747213;
                        y3 = (this.controlDrawPanel.Height - t.pts[2].Y) * 0.747213;

                        sx1 = x1.ToString().Replace(",", ".") + "pt";
                        sx2 = x2.ToString().Replace(",", ".") + "pt";
                        sx3 = x3.ToString().Replace(",", ".") + "pt";
                        sy1 = y1.ToString().Replace(",", ".") + "pt";
                        sy2 = y2.ToString().Replace(",", ".") + "pt";
                        sy3 = y3.ToString().Replace(",", ".") + "pt";

                        output += "\\draw (" + sx1 + "," + sy1 + ") .. controls (" + sx2 + "," + sy2 + ") .. (" + sx3 + "," + sy3 + ");\n";
                    }
                    else
                    {
                        Double x4, y4;
                        String sx4, sy4;

                        x1 = t.pts[0].X * 0.747213;
                        y1 = (this.controlDrawPanel.Height - t.pts[0].Y) * 0.747213;
                        x2 = t.pts[1].X * 0.747213;
                        y2 = (this.controlDrawPanel.Height - t.pts[1].Y) * 0.747213;
                        x3 = t.pts[2].X * 0.747213;
                        y3 = (this.controlDrawPanel.Height - t.pts[2].Y) * 0.747213;
                        x4 = t.pts[3].X * 0.747213;
                        y4 = (this.controlDrawPanel.Height - t.pts[3].Y) * 0.747213;

                        sx1 = x1.ToString().Replace(",", ".") + "pt";
                        sx2 = x2.ToString().Replace(",", ".") + "pt";
                        sx3 = x3.ToString().Replace(",", ".") + "pt";
                        sx4 = x4.ToString().Replace(",", ".") + "pt";
                        sy1 = y1.ToString().Replace(",", ".") + "pt";
                        sy2 = y2.ToString().Replace(",", ".") + "pt";
                        sy3 = y3.ToString().Replace(",", ".") + "pt";
                        sy4 = y4.ToString().Replace(",", ".") + "pt";

                        output += "\\draw (" + sx1 + "," + sy1 + ") .. controls (" + sx2 + "," + sy2 + ") and (" + sx3 + "," + sy3 + ") .. (" + sx4 + "," + sy4 + ");\n";
                    }
                }

                if(t.type == "rect")
                {
                    Double sx, sy, ex, ey;
                    String x1, y1, x2, y2;

                    sx = t.x * 0.747213;
                    sy = (this.controlDrawPanel.Height - t.y) * 0.747213;
                    ex = t.xn * 0.747213;
                    ey = (this.controlDrawPanel.Height - t.yn) * 0.747213;

                    x1 = sx.ToString().Replace(",", ".") + "pt";
                    y1 = sy.ToString().Replace(",", ".") + "pt";
                    x2 = ex.ToString().Replace(",", ".") + "pt";
                    y2 = ey.ToString().Replace(",", ".") + "pt";

                    output += "\\draw (" + x1 + "," + y1 + ") -- (" + x2 + "," + y1 + ");\n";
                    output += "\\draw (" + x2 + "," + y1 + ") -- (" + x2 + "," + y2 + ");\n";
                    output += "\\draw (" + x2 + "," + y2 + ") -- (" + x1 + "," + y2 + ");\n";
                    output += "\\draw (" + x1 + "," + y2 + ") -- (" + x1 + "," + y1 + ");";
                }

                if (t.type == "circ")
                {
                    Double sx, sy, ex, ey;
                    String x1, y1, x2, y2;

                    sx = t.x;
                    sy = t.y;
                    ex = t.xn;
                    ey = t.yn;

                    if (t.xn < t.x)
                    {
                        sx = t.xn;
                        ex = t.x;
                    }


                    if (t.yn < t.y)
                    {
                        sy = t.yn;
                        ey = t.y;
                    }


                    Double xmid = Math.Abs(ex - sx) / 2; // + sx
                    Double ymid = Math.Abs(ey - sy) / 2; // + sy

                    x1 = ((xmid) * 0.747213).ToString().Replace(",", ".") + "pt";
                    y1 = ((this.controlDrawPanel.Height - (ymid)) * 0.747213).ToString().Replace(",", ".") + "pt";
                    x2 = (xmid * 0.747213).ToString().Replace(",", ".") + "pt";
                    y2 = (ymid * 0.747213).ToString().Replace(",", ".") + "pt";

                    output += "\\draw (" + x1 + "," + y1 + ") ellipse (" + x2 + " and " + x2 + ");";
                }

                if (t.type == "ell")
                {
                    Double sx, sy, ex, ey;
                    String x1, y1, x2, y2;

                    sx = t.x;
                    sy = t.y;
                    ex = t.xn;
                    ey = t.yn;

                    if(t.xn < t.x)
                    {
                        sx = t.xn;
                        ex = t.x;
                    }
                    

                    if (t.yn < t.y)
                    {
                        sy = t.yn;
                        ey = t.y;
                    }

                    
                    Double xmid = Math.Abs(ex - sx) / 2; // + sx
                    Double ymid = Math.Abs(ey - sy) / 2; // + sy

                    x1 = ((xmid + sx) * 0.747213).ToString().Replace(",", ".") + "pt";
                    y1 = ((this.controlDrawPanel.Height - (ymid + sy)) * 0.747213).ToString().Replace(",", ".") + "pt";
                    x2 = (xmid * 0.747213).ToString().Replace(",", ".") + "pt";
                    y2 = (ymid * 0.747213).ToString().Replace(",", ".") + "pt";

                    output += "\\draw (" + x1 + "," + y1 + ") ellipse (" + x2 + " and " + y2 + ");";
                }

                output += "\n";
            }

            output += "\\end{tikzpicture}";

            MF.controlMainTextBox.Text = MF.controlMainTextBox.Text.Insert(MF.controlMainTextBox.SelectionStart, output);

            this.Close();
        }

        private void ToolChange(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                if(Tool == 1)
                {
                    if(points.Count > 2)
                    {
                        this.Shapes.Add(new Shape("curve", points.ToArray()));

                        using (Pen p = new Pen(Brushes.Black, this.weight))
                        {
                            try
                            {
                                gb.DrawCurve(p, points.ToArray());
                            }
                            catch
                            {

                            }
                        }
                    }

                    controlLayers.Items.Clear();

                    for (int i = 0; i < Shapes.Count; i++)
                    {
                        controlLayers.Items.Add("Слой" + (i + 1));
                    }
                    
                    points = new List<Point>();
                }

                switch (radioButton.Text)
                {
                    case "Прямая линия": Tool = 0; break;
                    case "Кривая линия": Tool = 1; break;
                    case "Прямоугольник": Tool = 2; break;
                    case "Круг": Tool = 3; break;
                    case "Эллипс": Tool = 4; break;
                    case "Текст": Tool = 5; break;
                    default: break;
                }
            }
        }

        private void ModeChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "Ручной":           workmode = true;  break;
                    case "С параметрами":    workmode = false; break;
                    default:                                   break;
                }
            }
        }

        private void controlWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.weight = Convert.ToInt32(controlWeight.Text);
                
                if(this.weight < 1 | this.weight > 5)
                {
                    controlWeight.Text = "1";
                    this.weight = 1;
                }
            }
            catch
            {
                controlWeight.Text = "1";
                this.weight = 1;
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
