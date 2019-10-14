namespace dotnetAss2
{
    partial class TextEditorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewM = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveM = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutM = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyM = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteM = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.New = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.SaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.about = new System.Windows.Forms.ToolStripButton();
            this.Tusername = new System.Windows.Forms.ToolStripLabel();
            this.Testlabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.CutButton = new System.Windows.Forms.ToolStripButton();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.PasteButton = new System.Windows.Forms.ToolStripButton();
            this.RichTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewM,
            this.OpenM,
            this.toolStripSeparator1,
            this.SaveM,
            this.SaveAsM,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // NewM
            // 
            this.NewM.Image = global::dotnetAss2.Properties.Resources.new_file;
            this.NewM.Name = "NewM";
            this.NewM.Size = new System.Drawing.Size(175, 22);
            this.NewM.Text = " New         Ctrl+N";
            this.NewM.Click += new System.EventHandler(this.NewM_Click);
            // 
            // OpenM
            // 
            this.OpenM.Image = global::dotnetAss2.Properties.Resources.folder;
            this.OpenM.Name = "OpenM";
            this.OpenM.Size = new System.Drawing.Size(175, 22);
            this.OpenM.Text = " Open        Ctrl+O";
            this.OpenM.Click += new System.EventHandler(this.OpenM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // SaveM
            // 
            this.SaveM.Image = global::dotnetAss2.Properties.Resources._73123159_2439631539452506_5233864799221186560_n;
            this.SaveM.Name = "SaveM";
            this.SaveM.Size = new System.Drawing.Size(175, 22);
            this.SaveM.Text = " Save         Ctrl+S";
            this.SaveM.Click += new System.EventHandler(this.SaveM_Click);
            // 
            // SaveAsM
            // 
            this.SaveAsM.Image = global::dotnetAss2.Properties.Resources.floppy_disk;
            this.SaveAsM.Name = "SaveAsM";
            this.SaveAsM.Size = new System.Drawing.Size(175, 22);
            this.SaveAsM.Text = " Save As";
            this.SaveAsM.Click += new System.EventHandler(this.SaveAsM_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::dotnetAss2.Properties.Resources.power_button;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.logoutToolStripMenuItem.Text = " Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutM,
            this.CopyM,
            this.PasteM});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // CutM
            // 
            this.CutM.Image = global::dotnetAss2.Properties.Resources.scissors;
            this.CutM.Name = "CutM";
            this.CutM.Size = new System.Drawing.Size(169, 22);
            this.CutM.Text = " Cut         Ctrl+X";
            this.CutM.Click += new System.EventHandler(this.CutM_Click);
            // 
            // CopyM
            // 
            this.CopyM.Image = global::dotnetAss2.Properties.Resources.document;
            this.CopyM.Name = "CopyM";
            this.CopyM.Size = new System.Drawing.Size(169, 22);
            this.CopyM.Text = " Copy       Ctrl+C";
            this.CopyM.Click += new System.EventHandler(this.CopyM_Click);
            // 
            // PasteM
            // 
            this.PasteM.Image = global::dotnetAss2.Properties.Resources.paste;
            this.PasteM.Name = "PasteM";
            this.PasteM.Size = new System.Drawing.Size(169, 22);
            this.PasteM.Text = " Paste       Ctrl+V";
            this.PasteM.Click += new System.EventHandler(this.PasteM_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutM});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutM
            // 
            this.AboutM.Name = "AboutM";
            this.AboutM.Size = new System.Drawing.Size(180, 22);
            this.AboutM.Text = "About...";
            this.AboutM.Click += new System.EventHandler(this.AboutM_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.SaveAs,
            this.toolStripSeparator3,
            this.Bold,
            this.Italic,
            this.Underline,
            this.FontSize,
            this.about,
            this.Tusername,
            this.Testlabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // New
            // 
            this.New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.New.Image = global::dotnetAss2.Properties.Resources.new_file;
            this.New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(23, 22);
            this.New.Text = "toolStripButton1";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = global::dotnetAss2.Properties.Resources.folder;
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "toolStripButton2";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = global::dotnetAss2.Properties.Resources._73123159_2439631539452506_5233864799221186560_n;
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "toolStripButton3";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAs.Image = global::dotnetAss2.Properties.Resources.floppy_disk;
            this.SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(23, 22);
            this.SaveAs.Text = "toolStripButton4";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = global::dotnetAss2.Properties.Resources.bold;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "toolStripButton5";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = global::dotnetAss2.Properties.Resources.italic;
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(23, 22);
            this.Italic.Text = "toolStripButton6";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = global::dotnetAss2.Properties.Resources._72954496_2439081029541619_7739670744023433216_n;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 22);
            this.Underline.Text = "toolStripButton7";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 25);
            this.FontSize.DropDown += new System.EventHandler(this.FontSize_Click);
            this.FontSize.DropDownClosed += new System.EventHandler(this.FontSize_Click);
            this.FontSize.TextUpdate += new System.EventHandler(this.FontSize_Click);
            this.FontSize.Leave += new System.EventHandler(this.FontSize_Click);
            this.FontSize.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // about
            // 
            this.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(23, 22);
            this.about.Text = "toolStripButton8";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Tusername
            // 
            this.Tusername.Name = "Tusername";
            this.Tusername.Size = new System.Drawing.Size(91, 22);
            this.Tusername.Text = "User Name: xxx";
            this.Tusername.Click += new System.EventHandler(this.Tusername_Click);
            // 
            // Testlabel
            // 
            this.Testlabel.ForeColor = System.Drawing.Color.Red;
            this.Testlabel.Name = "Testlabel";
            this.Testlabel.Size = new System.Drawing.Size(13, 22);
            this.Testlabel.Text = "T";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(126, 175);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 53);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutButton,
            this.CopyButton,
            this.PasteButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 80);
            this.toolStrip2.TabIndex = 0;
            // 
            // CutButton
            // 
            this.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutButton.Image = global::dotnetAss2.Properties.Resources.scissors;
            this.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(22, 20);
            this.CutButton.Text = "toolStripButton9";
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = global::dotnetAss2.Properties.Resources.document;
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(22, 20);
            this.CopyButton.Text = "toolStripButton10";
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteButton.Image = global::dotnetAss2.Properties.Resources.paste;
            this.PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(22, 20);
            this.PasteButton.Text = "toolStripButton11";
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // RichTB
            // 
            this.RichTB.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTB.Location = new System.Drawing.Point(27, 53);
            this.RichTB.Name = "RichTB";
            this.RichTB.Size = new System.Drawing.Size(761, 385);
            this.RichTB.TabIndex = 3;
            this.RichTB.Text = "";
            this.RichTB.TextChanged += new System.EventHandler(this.RichTB_TextChanged);
            // 
            // TextEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTB);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditorWindow";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.TextEditorWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewM;
        private System.Windows.Forms.ToolStripMenuItem OpenM;
        private System.Windows.Forms.ToolStripMenuItem SaveM;
        private System.Windows.Forms.ToolStripMenuItem SaveAsM;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutM;
        private System.Windows.Forms.ToolStripMenuItem CopyM;
        private System.Windows.Forms.ToolStripMenuItem PasteM;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton New;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripComboBox FontSize;
        private System.Windows.Forms.ToolStripButton about;
        private System.Windows.Forms.ToolStripLabel Tusername;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton CutButton;
        private System.Windows.Forms.ToolStripButton CopyButton;
        private System.Windows.Forms.ToolStripButton PasteButton;
        private System.Windows.Forms.RichTextBox RichTB;
        private System.Windows.Forms.ToolStripLabel Testlabel;
    }
}