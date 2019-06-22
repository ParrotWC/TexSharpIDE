namespace TeX_Sharp_IDE
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.controlFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.controlFolderOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlCreateTeXSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.controlCreateTeX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.controlSave = new System.Windows.Forms.ToolStripMenuItem();
            this.controlSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.controlBuildSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.controlBuild = new System.Windows.Forms.ToolStripMenuItem();
            this.controlSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.controlHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.EditToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.controlUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.controlRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.controlMML = new System.Windows.Forms.ToolStripMenuItem();
            this.controlGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.controlSplit = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlMainTextBox = new System.Windows.Forms.RichTextBox();
            this.controlPreviewErrs = new System.Windows.Forms.TabControl();
            this.controlLaTeXTab = new System.Windows.Forms.TabPage();
            this.controlLaTeXTextOut = new System.Windows.Forms.RichTextBox();
            this.controlErrorsTab = new System.Windows.Forms.TabPage();
            this.controlErrorsTextOut = new System.Windows.Forms.RichTextBox();
            this.controlWarningsTab = new System.Windows.Forms.TabPage();
            this.controlWarningsTextOut = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.controlOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.controlFolderBrowse = new System.Windows.Forms.ListView();
            this.controlSaveFileTeX = new System.Windows.Forms.SaveFileDialog();
            this.controlSaveFileTeXSharp = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlSplit)).BeginInit();
            this.controlSplit.Panel1.SuspendLayout();
            this.controlSplit.Panel2.SuspendLayout();
            this.controlSplit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.controlPreviewErrs.SuspendLayout();
            this.controlLaTeXTab.SuspendLayout();
            this.controlErrorsTab.SuspendLayout();
            this.controlWarningsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlFileOpen,
            this.controlFolderOpen,
            this.toolStripSeparator1,
            this.создатьToolStripMenuItem,
            this.toolStripSeparator3,
            this.controlSave,
            this.controlSaveAll,
            this.toolStripSeparator2,
            this.controlBuildSettings,
            this.controlBuild});
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(48, 20);
            this.FileToolStrip.Text = "Файл";
            // 
            // controlFileOpen
            // 
            this.controlFileOpen.Name = "controlFileOpen";
            this.controlFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.controlFileOpen.Size = new System.Drawing.Size(250, 22);
            this.controlFileOpen.Text = "Открыть файл...";
            this.controlFileOpen.Click += new System.EventHandler(this.controlFileOpen_Click);
            // 
            // controlFolderOpen
            // 
            this.controlFolderOpen.Name = "controlFolderOpen";
            this.controlFolderOpen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.controlFolderOpen.Size = new System.Drawing.Size(250, 22);
            this.controlFolderOpen.Text = "Открыть папку...";
            this.controlFolderOpen.Click += new System.EventHandler(this.controlFolderOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlCreateTeXSharp,
            this.controlCreateTeX});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // controlCreateTeXSharp
            // 
            this.controlCreateTeXSharp.Name = "controlCreateTeXSharp";
            this.controlCreateTeXSharp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.controlCreateTeXSharp.Size = new System.Drawing.Size(200, 22);
            this.controlCreateTeXSharp.Text = "Файл TeX#";
            this.controlCreateTeXSharp.Click += new System.EventHandler(this.controlCreateTeXSharp_Click);
            // 
            // controlCreateTeX
            // 
            this.controlCreateTeX.Name = "controlCreateTeX";
            this.controlCreateTeX.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.controlCreateTeX.Size = new System.Drawing.Size(200, 22);
            this.controlCreateTeX.Text = "Файл TeX";
            this.controlCreateTeX.Click += new System.EventHandler(this.controlCreateTeX_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(247, 6);
            // 
            // controlSave
            // 
            this.controlSave.Enabled = false;
            this.controlSave.Name = "controlSave";
            this.controlSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.controlSave.Size = new System.Drawing.Size(250, 22);
            this.controlSave.Text = "Сохранить...";
            this.controlSave.Click += new System.EventHandler(this.controlSave_Click);
            // 
            // controlSaveAll
            // 
            this.controlSaveAll.Enabled = false;
            this.controlSaveAll.Name = "controlSaveAll";
            this.controlSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.controlSaveAll.Size = new System.Drawing.Size(250, 22);
            this.controlSaveAll.Text = "Сохранить всё...";
            this.controlSaveAll.Click += new System.EventHandler(this.controlSaveAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // controlBuildSettings
            // 
            this.controlBuildSettings.Enabled = false;
            this.controlBuildSettings.Name = "controlBuildSettings";
            this.controlBuildSettings.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.controlBuildSettings.Size = new System.Drawing.Size(250, 22);
            this.controlBuildSettings.Text = "Настройки сборки";
            this.controlBuildSettings.Click += new System.EventHandler(this.controlBuildSettings_Click);
            // 
            // controlBuild
            // 
            this.controlBuild.Enabled = false;
            this.controlBuild.Name = "controlBuild";
            this.controlBuild.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.controlBuild.Size = new System.Drawing.Size(250, 22);
            this.controlBuild.Text = "Выполнить сборку";
            this.controlBuild.Click += new System.EventHandler(this.controlBuild_Click);
            // 
            // controlSettings
            // 
            this.controlSettings.Name = "controlSettings";
            this.controlSettings.Size = new System.Drawing.Size(79, 20);
            this.controlSettings.Text = "Настройки";
            this.controlSettings.Click += new System.EventHandler(this.controlSettings_Click);
            // 
            // controlHelp
            // 
            this.controlHelp.Name = "controlHelp";
            this.controlHelp.Size = new System.Drawing.Size(65, 20);
            this.controlHelp.Text = "Справка";
            this.controlHelp.Click += new System.EventHandler(this.controlHelp_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStrip,
            this.EditToolStrip,
            this.controlSettings,
            this.controlHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(200, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // EditToolStrip
            // 
            this.EditToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlUndo,
            this.controlRedo,
            this.controlMML,
            this.controlGraph});
            this.EditToolStrip.Name = "EditToolStrip";
            this.EditToolStrip.Size = new System.Drawing.Size(59, 20);
            this.EditToolStrip.Text = "Правка";
            // 
            // controlUndo
            // 
            this.controlUndo.Name = "controlUndo";
            this.controlUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.controlUndo.Size = new System.Drawing.Size(209, 22);
            this.controlUndo.Text = "Отменить";
            this.controlUndo.Visible = false;
            this.controlUndo.Click += new System.EventHandler(this.controlUndo_Click);
            // 
            // controlRedo
            // 
            this.controlRedo.Name = "controlRedo";
            this.controlRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.controlRedo.Size = new System.Drawing.Size(209, 22);
            this.controlRedo.Text = "Вернуть";
            this.controlRedo.Visible = false;
            this.controlRedo.Click += new System.EventHandler(this.controlRedo_Click);
            // 
            // controlMML
            // 
            this.controlMML.Name = "controlMML";
            this.controlMML.Size = new System.Drawing.Size(209, 22);
            this.controlMML.Text = "Вставить MML-формулу";
            this.controlMML.Click += new System.EventHandler(this.controlMML_Click);
            // 
            // controlGraph
            // 
            this.controlGraph.Name = "controlGraph";
            this.controlGraph.Size = new System.Drawing.Size(209, 22);
            this.controlGraph.Text = "Вставить псевдографику";
            this.controlGraph.Click += new System.EventHandler(this.controlGraph_Click);
            // 
            // controlSplit
            // 
            this.controlSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlSplit.Location = new System.Drawing.Point(238, 27);
            this.controlSplit.Name = "controlSplit";
            // 
            // controlSplit.Panel1
            // 
            this.controlSplit.Panel1.Controls.Add(this.panel1);
            // 
            // controlSplit.Panel2
            // 
            this.controlSplit.Panel2.Controls.Add(this.controlPreviewErrs);
            this.controlSplit.Size = new System.Drawing.Size(758, 596);
            this.controlSplit.SplitterDistance = 375;
            this.controlSplit.TabIndex = 2;
            this.controlSplit.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.controlMainTextBox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 596);
            this.panel1.TabIndex = 0;
            // 
            // controlMainTextBox
            // 
            this.controlMainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlMainTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlMainTextBox.Location = new System.Drawing.Point(4, 4);
            this.controlMainTextBox.Name = "controlMainTextBox";
            this.controlMainTextBox.Size = new System.Drawing.Size(365, 585);
            this.controlMainTextBox.TabIndex = 0;
            this.controlMainTextBox.Text = "";
            this.controlMainTextBox.WordWrap = false;
            this.controlMainTextBox.TextChanged += new System.EventHandler(this.controlMainTextBox_TextChanged);
            this.controlMainTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyup);
            // 
            // controlPreviewErrs
            // 
            this.controlPreviewErrs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPreviewErrs.Controls.Add(this.controlLaTeXTab);
            this.controlPreviewErrs.Controls.Add(this.controlErrorsTab);
            this.controlPreviewErrs.Controls.Add(this.controlWarningsTab);
            this.controlPreviewErrs.Controls.Add(this.tabPage1);
            this.controlPreviewErrs.Location = new System.Drawing.Point(2, 0);
            this.controlPreviewErrs.Name = "controlPreviewErrs";
            this.controlPreviewErrs.SelectedIndex = 0;
            this.controlPreviewErrs.Size = new System.Drawing.Size(377, 598);
            this.controlPreviewErrs.TabIndex = 0;
            // 
            // controlLaTeXTab
            // 
            this.controlLaTeXTab.BackColor = System.Drawing.SystemColors.Control;
            this.controlLaTeXTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlLaTeXTab.Controls.Add(this.controlLaTeXTextOut);
            this.controlLaTeXTab.Location = new System.Drawing.Point(4, 22);
            this.controlLaTeXTab.Name = "controlLaTeXTab";
            this.controlLaTeXTab.Size = new System.Drawing.Size(369, 572);
            this.controlLaTeXTab.TabIndex = 2;
            this.controlLaTeXTab.Text = "LaTeX";
            // 
            // controlLaTeXTextOut
            // 
            this.controlLaTeXTextOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlLaTeXTextOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlLaTeXTextOut.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.controlLaTeXTextOut.Location = new System.Drawing.Point(3, 3);
            this.controlLaTeXTextOut.Name = "controlLaTeXTextOut";
            this.controlLaTeXTextOut.ReadOnly = true;
            this.controlLaTeXTextOut.Size = new System.Drawing.Size(368, 567);
            this.controlLaTeXTextOut.TabIndex = 0;
            this.controlLaTeXTextOut.Text = "";
            this.controlLaTeXTextOut.WordWrap = false;
            // 
            // controlErrorsTab
            // 
            this.controlErrorsTab.BackColor = System.Drawing.SystemColors.Control;
            this.controlErrorsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlErrorsTab.Controls.Add(this.controlErrorsTextOut);
            this.controlErrorsTab.Location = new System.Drawing.Point(4, 22);
            this.controlErrorsTab.Name = "controlErrorsTab";
            this.controlErrorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlErrorsTab.Size = new System.Drawing.Size(369, 572);
            this.controlErrorsTab.TabIndex = 0;
            this.controlErrorsTab.Text = "Ошибки";
            // 
            // controlErrorsTextOut
            // 
            this.controlErrorsTextOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlErrorsTextOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlErrorsTextOut.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.controlErrorsTextOut.Location = new System.Drawing.Point(3, 3);
            this.controlErrorsTextOut.Name = "controlErrorsTextOut";
            this.controlErrorsTextOut.ReadOnly = true;
            this.controlErrorsTextOut.Size = new System.Drawing.Size(361, 564);
            this.controlErrorsTextOut.TabIndex = 0;
            this.controlErrorsTextOut.Text = "";
            this.controlErrorsTextOut.WordWrap = false;
            // 
            // controlWarningsTab
            // 
            this.controlWarningsTab.BackColor = System.Drawing.SystemColors.Control;
            this.controlWarningsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlWarningsTab.Controls.Add(this.controlWarningsTextOut);
            this.controlWarningsTab.Location = new System.Drawing.Point(4, 22);
            this.controlWarningsTab.Name = "controlWarningsTab";
            this.controlWarningsTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlWarningsTab.Size = new System.Drawing.Size(369, 572);
            this.controlWarningsTab.TabIndex = 1;
            this.controlWarningsTab.Text = "Предупреждения";
            // 
            // controlWarningsTextOut
            // 
            this.controlWarningsTextOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlWarningsTextOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlWarningsTextOut.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.controlWarningsTextOut.Location = new System.Drawing.Point(3, 3);
            this.controlWarningsTextOut.Name = "controlWarningsTextOut";
            this.controlWarningsTextOut.ReadOnly = true;
            this.controlWarningsTextOut.Size = new System.Drawing.Size(361, 564);
            this.controlWarningsTextOut.TabIndex = 0;
            this.controlWarningsTextOut.Text = "";
            this.controlWarningsTextOut.WordWrap = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axAcroPDF1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(369, 572);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Предпросмотр";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(3, 3);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(363, 566);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // controlOpenFile
            // 
            this.controlOpenFile.Filter = "TeX#|*.texsharp|LaTeX|*.tex";
            this.controlOpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.controlOpenFile_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // controlFolderBrowse
            // 
            this.controlFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlFolderBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlFolderBrowse.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlFolderBrowse.Location = new System.Drawing.Point(12, 27);
            this.controlFolderBrowse.MultiSelect = false;
            this.controlFolderBrowse.Name = "controlFolderBrowse";
            this.controlFolderBrowse.Size = new System.Drawing.Size(220, 596);
            this.controlFolderBrowse.TabIndex = 4;
            this.controlFolderBrowse.UseCompatibleStateImageBehavior = false;
            this.controlFolderBrowse.View = System.Windows.Forms.View.List;
            this.controlFolderBrowse.Visible = false;
            this.controlFolderBrowse.SelectedIndexChanged += new System.EventHandler(this.controlFolderBrowse_SelectedIndexChanged);
            // 
            // controlSaveFileTeX
            // 
            this.controlSaveFileTeX.DefaultExt = "tex";
            this.controlSaveFileTeX.FileOk += new System.ComponentModel.CancelEventHandler(this.controlSaveFileTeX_FileOk);
            // 
            // controlSaveFileTeXSharp
            // 
            this.controlSaveFileTeXSharp.DefaultExt = "texsharp";
            this.controlSaveFileTeXSharp.FileOk += new System.ComponentModel.CancelEventHandler(this.controlSaveFileTeXSharp_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.controlFolderBrowse);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.controlSplit);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "TeX# IDE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.controlSplit.Panel1.ResumeLayout(false);
            this.controlSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlSplit)).EndInit();
            this.controlSplit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.controlPreviewErrs.ResumeLayout(false);
            this.controlLaTeXTab.ResumeLayout(false);
            this.controlErrorsTab.ResumeLayout(false);
            this.controlWarningsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem FileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem controlFileOpen;
        private System.Windows.Forms.ToolStripMenuItem controlFolderOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem controlSave;
        private System.Windows.Forms.ToolStripMenuItem controlSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem controlBuild;
        private System.Windows.Forms.ToolStripMenuItem controlBuildSettings;
        private System.Windows.Forms.ToolStripMenuItem controlSettings;
        private System.Windows.Forms.ToolStripMenuItem controlHelp;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.SplitContainer controlSplit;
        private System.Windows.Forms.TabControl controlPreviewErrs;
        private System.Windows.Forms.TabPage controlErrorsTab;
        private System.Windows.Forms.TabPage controlWarningsTab;
        private System.Windows.Forms.TabPage controlLaTeXTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox controlWarningsTextOut;
        private System.Windows.Forms.RichTextBox controlLaTeXTextOut;
        private System.Windows.Forms.OpenFileDialog controlOpenFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ListView controlFolderBrowse;
        private System.Windows.Forms.ToolStripMenuItem EditToolStrip;
        private System.Windows.Forms.ToolStripMenuItem controlUndo;
        private System.Windows.Forms.ToolStripMenuItem controlRedo;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlCreateTeXSharp;
        private System.Windows.Forms.ToolStripMenuItem controlCreateTeX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SaveFileDialog controlSaveFileTeX;
        private System.Windows.Forms.SaveFileDialog controlSaveFileTeXSharp;
        private System.Windows.Forms.ToolStripMenuItem controlMML;
        public System.Windows.Forms.RichTextBox controlMainTextBox;
        private System.Windows.Forms.ToolStripMenuItem controlGraph;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.RichTextBox controlErrorsTextOut;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;


    }
}

