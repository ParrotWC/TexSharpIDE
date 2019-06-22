namespace TeX_Sharp_IDE
{
    partial class CompieleSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.controlPDFLaTeXPath = new System.Windows.Forms.TextBox();
            this.controlOpenPDFLaTeXFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.controlInterval = new System.Windows.Forms.TextBox();
            this.controlDeny = new System.Windows.Forms.Button();
            this.controlApply = new System.Windows.Forms.Button();
            this.controlOk = new System.Windows.Forms.Button();
            this.controlActivePreprocessor = new System.Windows.Forms.CheckBox();
            this.controlActivePreview = new System.Windows.Forms.CheckBox();
            this.LaTeXDirDia = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к директории с приложением pdflatex.exe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // controlPDFLaTeXPath
            // 
            this.controlPDFLaTeXPath.Location = new System.Drawing.Point(15, 28);
            this.controlPDFLaTeXPath.Name = "controlPDFLaTeXPath";
            this.controlPDFLaTeXPath.Size = new System.Drawing.Size(346, 20);
            this.controlPDFLaTeXPath.TabIndex = 1;
            // 
            // controlOpenPDFLaTeXFile
            // 
            this.controlOpenPDFLaTeXFile.Location = new System.Drawing.Point(367, 26);
            this.controlOpenPDFLaTeXFile.Name = "controlOpenPDFLaTeXFile";
            this.controlOpenPDFLaTeXFile.Size = new System.Drawing.Size(50, 23);
            this.controlOpenPDFLaTeXFile.TabIndex = 2;
            this.controlOpenPDFLaTeXFile.Text = "...";
            this.controlOpenPDFLaTeXFile.UseVisualStyleBackColor = true;
            this.controlOpenPDFLaTeXFile.Click += new System.EventHandler(this.controlOpenPDFLaTeXFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Интервал попыток автоматического компилирования (в секундах, от 1 до 10)";
            // 
            // controlInterval
            // 
            this.controlInterval.Location = new System.Drawing.Point(15, 94);
            this.controlInterval.Name = "controlInterval";
            this.controlInterval.Size = new System.Drawing.Size(46, 20);
            this.controlInterval.TabIndex = 4;
            // 
            // controlDeny
            // 
            this.controlDeny.Location = new System.Drawing.Point(342, 206);
            this.controlDeny.Name = "controlDeny";
            this.controlDeny.Size = new System.Drawing.Size(75, 23);
            this.controlDeny.TabIndex = 5;
            this.controlDeny.Text = "Отмена";
            this.controlDeny.UseVisualStyleBackColor = true;
            this.controlDeny.Click += new System.EventHandler(this.controlDeny_Click);
            // 
            // controlApply
            // 
            this.controlApply.Location = new System.Drawing.Point(261, 206);
            this.controlApply.Name = "controlApply";
            this.controlApply.Size = new System.Drawing.Size(75, 23);
            this.controlApply.TabIndex = 6;
            this.controlApply.Text = "Применить";
            this.controlApply.UseVisualStyleBackColor = true;
            this.controlApply.Click += new System.EventHandler(this.controlApply_Click);
            // 
            // controlOk
            // 
            this.controlOk.Location = new System.Drawing.Point(180, 206);
            this.controlOk.Name = "controlOk";
            this.controlOk.Size = new System.Drawing.Size(75, 23);
            this.controlOk.TabIndex = 7;
            this.controlOk.Text = "Ок";
            this.controlOk.UseVisualStyleBackColor = true;
            this.controlOk.Click += new System.EventHandler(this.controlOk_Click);
            // 
            // controlActivePreprocessor
            // 
            this.controlActivePreprocessor.AutoSize = true;
            this.controlActivePreprocessor.Location = new System.Drawing.Point(15, 138);
            this.controlActivePreprocessor.Name = "controlActivePreprocessor";
            this.controlActivePreprocessor.Size = new System.Drawing.Size(151, 17);
            this.controlActivePreprocessor.TabIndex = 8;
            this.controlActivePreprocessor.Text = "Активный препроцессор";
            this.controlActivePreprocessor.UseVisualStyleBackColor = true;
            // 
            // controlActivePreview
            // 
            this.controlActivePreview.AutoSize = true;
            this.controlActivePreview.Location = new System.Drawing.Point(15, 161);
            this.controlActivePreview.Name = "controlActivePreview";
            this.controlActivePreview.Size = new System.Drawing.Size(152, 17);
            this.controlActivePreview.TabIndex = 9;
            this.controlActivePreview.Text = "Активный предпросмотр";
            this.controlActivePreview.UseVisualStyleBackColor = true;
            // 
            // LaTeXDirDia
            // 
            this.LaTeXDirDia.HelpRequest += new System.EventHandler(this.LaTeXDirDia_HelpRequest);
            // 
            // CompieleSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(429, 241);
            this.Controls.Add(this.controlActivePreview);
            this.Controls.Add(this.controlActivePreprocessor);
            this.Controls.Add(this.controlOk);
            this.Controls.Add(this.controlApply);
            this.Controls.Add(this.controlDeny);
            this.Controls.Add(this.controlInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlOpenPDFLaTeXFile);
            this.Controls.Add(this.controlPDFLaTeXPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompieleSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox controlPDFLaTeXPath;
        private System.Windows.Forms.Button controlOpenPDFLaTeXFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox controlInterval;
        private System.Windows.Forms.Button controlDeny;
        private System.Windows.Forms.Button controlApply;
        private System.Windows.Forms.Button controlOk;
        private System.Windows.Forms.CheckBox controlActivePreprocessor;
        private System.Windows.Forms.CheckBox controlActivePreview;
        private System.Windows.Forms.FolderBrowserDialog LaTeXDirDia;
    }
}