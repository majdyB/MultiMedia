namespace FirstMM_HW
{
    partial class image_fourm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(image_fourm));
            this.menuStrip_IMGFRM = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brighterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseLum = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toRed2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toBlue2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGreen2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.W = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CL = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.easyAccessStrip = new System.Windows.Forms.ToolStrip();
            this.OpenToolstrip = new System.Windows.Forms.ToolStripButton();
            this.add_logo = new System.Windows.Forms.ToolStripButton();
            this.ShowPic = new System.Windows.Forms.PictureBox();
            this.ScrolPanel = new System.Windows.Forms.Panel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip_IMGFRM.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.easyAccessStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic)).BeginInit();
            this.ScrolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_IMGFRM
            // 
            this.menuStrip_IMGFRM.BackColor = System.Drawing.Color.Black;
            this.menuStrip_IMGFRM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_IMGFRM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.doToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip_IMGFRM.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_IMGFRM.Name = "menuStrip_IMGFRM";
            this.menuStrip_IMGFRM.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip_IMGFRM.Size = new System.Drawing.Size(1209, 28);
            this.menuStrip_IMGFRM.TabIndex = 0;
            this.menuStrip_IMGFRM.Text = "MainMenue";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.editToolStripMenuItem.Checked = true;
            this.editToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inverseToolStripMenuItem,
            this.toGrayToolStripMenuItem,
            this.brighterToolStripMenuItem,
            this.toRed2ToolStripMenuItem,
            this.toBlue2ToolStripMenuItem,
            this.toGreen2ToolStripMenuItem,
            this.selectColorToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShowShortcutKeys = false;
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            this.editToolStripMenuItem.EnabledChanged += new System.EventHandler(this.fileToolStripMenuItem_Click);
            this.editToolStripMenuItem.OwnerChanged += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.inverseToolStripMenuItem.Text = "Inverse";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // toGrayToolStripMenuItem
            // 
            this.toGrayToolStripMenuItem.Name = "toGrayToolStripMenuItem";
            this.toGrayToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.toGrayToolStripMenuItem.Text = "ToGray";
            this.toGrayToolStripMenuItem.Click += new System.EventHandler(this.toGrayToolStripMenuItem_Click);
            // 
            // brighterToolStripMenuItem
            // 
            this.brighterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseLum,
            this.decreaseToolStripMenuItem});
            this.brighterToolStripMenuItem.Name = "brighterToolStripMenuItem";
            this.brighterToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.brighterToolStripMenuItem.Text = "Brightness";
            this.brighterToolStripMenuItem.Click += new System.EventHandler(this.brighterToolStripMenuItem_Click);
            // 
            // increaseLum
            // 
            this.increaseLum.Name = "increaseLum";
            this.increaseLum.Size = new System.Drawing.Size(145, 26);
            this.increaseLum.Text = "Increase";
            this.increaseLum.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.decreaseToolStripMenuItem.Text = "Decrease";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // toRed2ToolStripMenuItem
            // 
            this.toRed2ToolStripMenuItem.Name = "toRed2ToolStripMenuItem";
            this.toRed2ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.toRed2ToolStripMenuItem.Text = "ToRed(2)";
            this.toRed2ToolStripMenuItem.Click += new System.EventHandler(this.toRed2ToolStripMenuItem_Click);
            // 
            // toBlue2ToolStripMenuItem
            // 
            this.toBlue2ToolStripMenuItem.Name = "toBlue2ToolStripMenuItem";
            this.toBlue2ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.toBlue2ToolStripMenuItem.Text = "ToBlue(2)";
            this.toBlue2ToolStripMenuItem.Click += new System.EventHandler(this.toBlue2ToolStripMenuItem_Click);
            // 
            // toGreen2ToolStripMenuItem
            // 
            this.toGreen2ToolStripMenuItem.Name = "toGreen2ToolStripMenuItem";
            this.toGreen2ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.toGreen2ToolStripMenuItem.Text = "ToGreen(2)";
            this.toGreen2ToolStripMenuItem.Click += new System.EventHandler(this.toGreen2ToolStripMenuItem_Click);
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.selectColorToolStripMenuItem.Text = "selectColor";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectColorToolStripMenuItem_Click);
            // 
            // doToolStripMenuItem
            // 
            this.doToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.doToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doToolStripMenuItem.Name = "doToolStripMenuItem";
            this.doToolStripMenuItem.ShowShortcutKeys = false;
            this.doToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.doToolStripMenuItem.Text = "Do";
            this.doToolStripMenuItem.Click += new System.EventHandler(this.doToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click_1);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.logoToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.drowToolStripMenuItem});
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.EnabledChanged += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // logoToolStripMenuItem
            // 
            this.logoToolStripMenuItem.Name = "logoToolStripMenuItem";
            this.logoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.logoToolStripMenuItem.Text = "logo";
            this.logoToolStripMenuItem.Click += new System.EventHandler(this.logoToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rotateToolStripMenuItem.Text = "rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // drowToolStripMenuItem
            // 
            this.drowToolStripMenuItem.Name = "drowToolStripMenuItem";
            this.drowToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.drowToolStripMenuItem.Text = "DrowRect";
            this.drowToolStripMenuItem.Click += new System.EventHandler(this.drowToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.W,
            this.toolStripStatusLabel1,
            this.CL});
            this.statusBar.Location = new System.Drawing.Point(0, 473);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusBar.Size = new System.Drawing.Size(1209, 25);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            // 
            // W
            // 
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(46, 20);
            this.W.Text = "Info : ";
            this.W.Click += new System.EventHandler(this.W_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // CL
            // 
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(48, 20);
            this.CL.Text = "Color:";
            this.CL.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // easyAccessStrip
            // 
            this.easyAccessStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.easyAccessStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.easyAccessStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolstrip,
            this.add_logo,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.easyAccessStrip.Location = new System.Drawing.Point(0, 28);
            this.easyAccessStrip.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.easyAccessStrip.Name = "easyAccessStrip";
            this.easyAccessStrip.Padding = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.easyAccessStrip.Size = new System.Drawing.Size(1209, 28);
            this.easyAccessStrip.TabIndex = 4;
            this.easyAccessStrip.Text = "toolStripEasyAccess";
            // 
            // OpenToolstrip
            // 
            this.OpenToolstrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolstrip.Image = global::FirstMM_HW.Properties.Resources.Untitled;
            this.OpenToolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolstrip.Name = "OpenToolstrip";
            this.OpenToolstrip.Size = new System.Drawing.Size(24, 24);
            this.OpenToolstrip.Text = "open_toolStrip";
            this.OpenToolstrip.ToolTipText = "open";
            this.OpenToolstrip.Click += new System.EventHandler(this.OpenToolstrip_Click);
            // 
            // add_logo
            // 
            this.add_logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_logo.Image = global::FirstMM_HW.Properties.Resources.download;
            this.add_logo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_logo.Name = "add_logo";
            this.add_logo.Size = new System.Drawing.Size(24, 24);
            this.add_logo.Text = "add_logo";
            this.add_logo.Click += new System.EventHandler(this.add_logo_Click_1);
            // 
            // ShowPic
            // 
            this.ShowPic.Location = new System.Drawing.Point(0, 0);
            this.ShowPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPic.Name = "ShowPic";
            this.ShowPic.Size = new System.Drawing.Size(403, 320);
            this.ShowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ShowPic.TabIndex = 0;
            this.ShowPic.TabStop = false;
            this.ShowPic.Click += new System.EventHandler(this.ShowPic_clickup);
            this.ShowPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPic_MouseDown);
            this.ShowPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowPic_MouseMove);
            this.ShowPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPic_MouseUp);
            // 
            // ScrolPanel
            // 
            this.ScrolPanel.AllowDrop = true;
            this.ScrolPanel.AutoScroll = true;
            this.ScrolPanel.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.ScrolPanel.BackColor = System.Drawing.Color.DarkRed;
            this.ScrolPanel.Controls.Add(this.ShowPic);
            this.ScrolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrolPanel.Location = new System.Drawing.Point(0, 28);
            this.ScrolPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScrolPanel.Name = "ScrolPanel";
            this.ScrolPanel.Size = new System.Drawing.Size(1209, 445);
            this.ScrolPanel.TabIndex = 2;
            this.ScrolPanel.EnabledChanged += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.ScrolPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ScrolPanel_Paint);
            this.ScrolPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScrolPanel_MouseMove);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.undoToolStripMenuItem_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // image_fourm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 498);
            this.Controls.Add(this.easyAccessStrip);
            this.Controls.Add(this.ScrolPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip_IMGFRM);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip_IMGFRM;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "image_fourm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPhoto";
            this.menuStrip_IMGFRM.ResumeLayout(false);
            this.menuStrip_IMGFRM.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.easyAccessStrip.ResumeLayout(false);
            this.easyAccessStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPic)).EndInit();
            this.ScrolPanel.ResumeLayout(false);
            this.ScrolPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_IMGFRM;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel W;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brighterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseLum;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toRed2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toBlue2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGreen2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel CL;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip easyAccessStrip;
        private System.Windows.Forms.ToolStripButton OpenToolstrip;
        private System.Windows.Forms.ToolStripButton add_logo;
        private System.Windows.Forms.PictureBox ShowPic;
        private System.Windows.Forms.Panel ScrolPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

