namespace TeX_Sharp_IDE.Forms
{
    partial class Draw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlComplete = new System.Windows.Forms.Button();
            this.controlDrawPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.controlLayers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.controlWeight = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlComplete
            // 
            this.controlComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlComplete.Location = new System.Drawing.Point(12, 485);
            this.controlComplete.Name = "controlComplete";
            this.controlComplete.Size = new System.Drawing.Size(150, 23);
            this.controlComplete.TabIndex = 4;
            this.controlComplete.Text = "Вставить как TeX";
            this.controlComplete.UseVisualStyleBackColor = true;
            this.controlComplete.Click += new System.EventHandler(this.controlComplete_Click);
            // 
            // controlDrawPanel
            // 
            this.controlDrawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.controlDrawPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.controlDrawPanel.Location = new System.Drawing.Point(175, 36);
            this.controlDrawPanel.Name = "controlDrawPanel";
            this.controlDrawPanel.Size = new System.Drawing.Size(480, 470);
            this.controlDrawPanel.TabIndex = 8;
            this.controlDrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlDrawPanel_Paint);
            this.controlDrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlDrawPanel_MouseDown);
            this.controlDrawPanel.MouseLeave += new System.EventHandler(this.controlDrawPanel_MouseLeave);
            this.controlDrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlDrawPanel_MouseMove);
            this.controlDrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlDrawPanel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 133);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton8.Location = new System.Drawing.Point(9, 106);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(62, 17);
            this.radioButton8.TabIndex = 5;
            this.radioButton8.Text = "Эллипс";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.ToolChange);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton7.Location = new System.Drawing.Point(9, 85);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(48, 17);
            this.radioButton7.TabIndex = 4;
            this.radioButton7.Text = "Круг";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.ToolChange);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton6.Location = new System.Drawing.Point(9, 64);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(105, 17);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "Прямоугольник";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.ToolChange);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton5.Location = new System.Drawing.Point(9, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Кривая линия";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.ToolChange);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Location = new System.Drawing.Point(9, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Прямая линия";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.ToolChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режимы";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(7, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "С параметрами";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ручной";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ModeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.controlLayers);
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 188);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Слои";
            // 
            // controlLayers
            // 
            this.controlLayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.controlLayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlLayers.Location = new System.Drawing.Point(6, 19);
            this.controlLayers.Name = "controlLayers";
            this.controlLayers.Size = new System.Drawing.Size(138, 163);
            this.controlLayers.TabIndex = 0;
            this.controlLayers.UseCompatibleStateImageBehavior = false;
            this.controlLayers.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 138;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(228, 14);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(0, 13);
            this.labelY.TabIndex = 12;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(172, 14);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(0, 13);
            this.labelX.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.controlWeight);
            this.groupBox4.Location = new System.Drawing.Point(12, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 56);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Толщина";
            // 
            // controlWeight
            // 
            this.controlWeight.Location = new System.Drawing.Point(7, 22);
            this.controlWeight.Name = "controlWeight";
            this.controlWeight.Size = new System.Drawing.Size(137, 20);
            this.controlWeight.TabIndex = 0;
            this.controlWeight.Text = "1";
            this.controlWeight.TextChanged += new System.EventHandler(this.controlWeight_TextChanged);
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 521);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controlDrawPanel);
            this.Controls.Add(this.controlComplete);
            this.Name = "Draw";
            this.Text = "TeX# IDE - Графический редактор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button controlComplete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView controlLayers;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox controlWeight;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.Panel controlDrawPanel;
    }
}