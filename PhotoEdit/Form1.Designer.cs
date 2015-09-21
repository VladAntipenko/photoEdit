namespace PhotoEdit
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pBMain = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenu,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenu
            // 
            this.fileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolMenu,
            this.saveToolMenu,
            this.closeToolpMenu,
            this.exitToolMenu});
            this.fileStripMenu.Name = "fileStripMenu";
            this.fileStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenu.Text = "File";
            // 
            // openToolMenu
            // 
            this.openToolMenu.Name = "openToolMenu";
            this.openToolMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolMenu.Size = new System.Drawing.Size(152, 22);
            this.openToolMenu.Text = "Open";
            this.openToolMenu.Click += new System.EventHandler(this.openToolMenu_Click);
            // 
            // saveToolMenu
            // 
            this.saveToolMenu.Name = "saveToolMenu";
            this.saveToolMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolMenu.Size = new System.Drawing.Size(152, 22);
            this.saveToolMenu.Text = "Save";
            this.saveToolMenu.Click += new System.EventHandler(this.saveToolMenu_Click);
            // 
            // closeToolpMenu
            // 
            this.closeToolpMenu.Name = "closeToolpMenu";
            this.closeToolpMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolpMenu.Size = new System.Drawing.Size(152, 22);
            this.closeToolpMenu.Text = "Close";
            this.closeToolpMenu.Click += new System.EventHandler(this.closeToolpMenu_Click);
            // 
            // exitToolMenu
            // 
            this.exitToolMenu.Name = "exitToolMenu";
            this.exitToolMenu.Size = new System.Drawing.Size(152, 22);
            this.exitToolMenu.Text = "Exit";
            this.exitToolMenu.Click += new System.EventHandler(this.exitToolMenu_Click);
            // 
            // ts
            // 
            this.ts.AutoSize = false;
            this.ts.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.ts.Location = new System.Drawing.Point(0, 24);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(46, 417);
            this.ts.TabIndex = 1;
            this.ts.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 42);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 42);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // pBMain
            // 
            this.pBMain.Location = new System.Drawing.Point(49, 36);
            this.pBMain.Name = "pBMain";
            this.pBMain.Size = new System.Drawing.Size(563, 393);
            this.pBMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMain.TabIndex = 2;
            this.pBMain.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inverseToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inverseToolStripMenuItem.Text = "Darker";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pBMain);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "PhotoEdit 0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolpMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolMenu;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.PictureBox pBMain;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
    }
}

