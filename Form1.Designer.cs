namespace MacEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabIndentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.file = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentFont = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentTabIndent = new System.Windows.Forms.ToolStripStatusLabel();
            this.texteditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip4 = new System.Windows.Forms.StatusStrip();
            this.statusStrip6 = new System.Windows.Forms.StatusStrip();
            this.ffile = new System.Windows.Forms.ToolStripStatusLabel();
            this.keywordColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.typeColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.commentColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.stringColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.syntaxeditor = new System.Windows.Forms.RichTextBox();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.toolStripContainer2.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.statusStrip4.SuspendLayout();
            this.statusStrip6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 648);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStripContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStripContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Syntax Highlighter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip2);
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip3);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.texteditor);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(816, 526);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(816, 616);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tabIndentToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tabIndentToolStripMenuItem
            // 
            this.tabIndentToolStripMenuItem.Name = "tabIndentToolStripMenuItem";
            this.tabIndentToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.tabIndentToolStripMenuItem.Text = "Tab Indent";
            this.tabIndentToolStripMenuItem.Click += new System.EventHandler(this.tabIndentToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file});
            this.statusStrip2.Location = new System.Drawing.Point(0, 0);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(816, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentFont});
            this.statusStrip1.Location = new System.Drawing.Point(0, 44);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            // 
            // statusStrip3
            // 
            this.statusStrip3.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentTabIndent});
            this.statusStrip3.Location = new System.Drawing.Point(0, 22);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(816, 22);
            this.statusStrip3.SizingGrip = false;
            this.statusStrip3.TabIndex = 4;
            // 
            // file
            // 
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(60, 17);
            this.file.Text = "(New File)";
            // 
            // currentFont
            // 
            this.currentFont.Name = "currentFont";
            this.currentFont.Size = new System.Drawing.Size(157, 17);
            this.currentFont.Text = "Current Font: Consolas, 10pt";
            // 
            // currentTabIndent
            // 
            this.currentTabIndent.Name = "currentTabIndent";
            this.currentTabIndent.Size = new System.Drawing.Size(75, 17);
            this.currentTabIndent.Text = "Tab Indent: 4";
            // 
            // texteditor
            // 
            this.texteditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texteditor.IsReadOnly = false;
            this.texteditor.Location = new System.Drawing.Point(0, 0);
            this.texteditor.Name = "texteditor";
            this.texteditor.Size = new System.Drawing.Size(816, 526);
            this.texteditor.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.BottomToolStripPanel
            // 
            this.toolStripContainer2.BottomToolStripPanel.Controls.Add(this.statusStrip4);
            this.toolStripContainer2.BottomToolStripPanel.Controls.Add(this.statusStrip6);
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.syntaxeditor);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(816, 548);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(816, 616);
            this.toolStripContainer2.TabIndex = 0;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.menuStrip2);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fontToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(816, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.newToolStripMenuItem1,
            this.toolStripMenuItem4,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem1.Text = "Font";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // statusStrip4
            // 
            this.statusStrip4.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ffile});
            this.statusStrip4.Location = new System.Drawing.Point(0, 0);
            this.statusStrip4.Name = "statusStrip4";
            this.statusStrip4.Size = new System.Drawing.Size(816, 22);
            this.statusStrip4.SizingGrip = false;
            this.statusStrip4.TabIndex = 0;
            // 
            // statusStrip6
            // 
            this.statusStrip6.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordColor,
            this.typeColor,
            this.commentColor,
            this.stringColor});
            this.statusStrip6.Location = new System.Drawing.Point(0, 22);
            this.statusStrip6.Name = "statusStrip6";
            this.statusStrip6.Size = new System.Drawing.Size(816, 22);
            this.statusStrip6.SizingGrip = false;
            this.statusStrip6.TabIndex = 2;
            // 
            // ffile
            // 
            this.ffile.Name = "ffile";
            this.ffile.Size = new System.Drawing.Size(60, 17);
            this.ffile.Text = "(New File)";
            // 
            // keywordColor
            // 
            this.keywordColor.Name = "keywordColor";
            this.keywordColor.Size = new System.Drawing.Size(82, 17);
            this.keywordColor.Text = "Keyword: Blue";
            this.keywordColor.ToolTipText = "Change Keyword Color";
            this.keywordColor.Click += new System.EventHandler(this.keywordColor_Click);
            this.keywordColor.MouseEnter += new System.EventHandler(this.keywordColor_MouseEnter);
            this.keywordColor.MouseLeave += new System.EventHandler(this.keywordColor_MouseLeave);
            // 
            // typeColor
            // 
            this.typeColor.Name = "typeColor";
            this.typeColor.Size = new System.Drawing.Size(89, 17);
            this.typeColor.Text = "Type: DarkCyan";
            this.typeColor.ToolTipText = "Change Type Color";
            this.typeColor.Click += new System.EventHandler(this.typeColor_Click);
            this.typeColor.MouseEnter += new System.EventHandler(this.typeColor_MouseEnter);
            this.typeColor.MouseLeave += new System.EventHandler(this.typeColor_MouseLeave);
            // 
            // commentColor
            // 
            this.commentColor.Name = "commentColor";
            this.commentColor.Size = new System.Drawing.Size(98, 17);
            this.commentColor.Text = "Comment: Green";
            this.commentColor.ToolTipText = "Change Comment Color";
            this.commentColor.Click += new System.EventHandler(this.commentColor_Click);
            this.commentColor.MouseEnter += new System.EventHandler(this.commentColor_MouseEnter);
            this.commentColor.MouseLeave += new System.EventHandler(this.commentColor_MouseLeave);
            // 
            // stringColor
            // 
            this.stringColor.Name = "stringColor";
            this.stringColor.Size = new System.Drawing.Size(78, 17);
            this.stringColor.Text = "String: Brown";
            this.stringColor.ToolTipText = "Change String Color";
            this.stringColor.Click += new System.EventHandler(this.stringColor_Click);
            this.stringColor.MouseEnter += new System.EventHandler(this.stringColor_MouseEnter);
            this.stringColor.MouseLeave += new System.EventHandler(this.stringColor_MouseLeave);
            // 
            // syntaxeditor
            // 
            this.syntaxeditor.AcceptsTab = true;
            this.syntaxeditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.syntaxeditor.Location = new System.Drawing.Point(0, 0);
            this.syntaxeditor.Name = "syntaxeditor";
            this.syntaxeditor.Size = new System.Drawing.Size(816, 548);
            this.syntaxeditor.TabIndex = 0;
            this.syntaxeditor.Text = "";
            this.syntaxeditor.TextChanged += new System.EventHandler(this.syntaxeditor_TextChanged);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 648);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(672, 561);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.toolStripContainer2.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip4.ResumeLayout(false);
            this.statusStrip4.PerformLayout();
            this.statusStrip6.ResumeLayout(false);
            this.statusStrip6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel file;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentFont;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel currentTabIndent;
        private ICSharpCode.TextEditor.TextEditorControl texteditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabIndentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.StatusStrip statusStrip4;
        private System.Windows.Forms.ToolStripStatusLabel ffile;
        private System.Windows.Forms.StatusStrip statusStrip6;
        private System.Windows.Forms.ToolStripStatusLabel keywordColor;
        private System.Windows.Forms.ToolStripStatusLabel typeColor;
        private System.Windows.Forms.ToolStripStatusLabel commentColor;
        private System.Windows.Forms.ToolStripStatusLabel stringColor;
        private System.Windows.Forms.RichTextBox syntaxeditor;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
    }
}

