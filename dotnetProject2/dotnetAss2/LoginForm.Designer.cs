namespace dotnetAss2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Username = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.NewuserB = new System.Windows.Forms.Button();
            this.LoginB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("OCR A Extended", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(150, 163);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(167, 32);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.UsernameTxt.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UsernameTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsernameTxt.Location = new System.Drawing.Point(402, 163);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(300, 35);
            this.UsernameTxt.TabIndex = 2;
            this.UsernameTxt.Text = "Username";
            this.UsernameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.UsernameTxt.Enter += new System.EventHandler(this.UsernameTxt_Enter);
            this.UsernameTxt.Leave += new System.EventHandler(this.UsernameTxt_Leave);
            // 
            // LoginTitle
            // 
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("OCR A Extended", 84F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginTitle.Location = new System.Drawing.Point(-14, -12);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(395, 116);
            this.LoginTitle.TabIndex = 3;
            this.LoginTitle.Text = "LOGIN";
            this.LoginTitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.PasswordTxt.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordTxt.Location = new System.Drawing.Point(402, 230);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(300, 35);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.Text = "Password";
            this.PasswordTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.PasswordTxt.Enter += new System.EventHandler(this.PasswordTxt_Enter);
            this.PasswordTxt.Leave += new System.EventHandler(this.PasswordTxt_Leave);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("OCR A Extended", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(150, 230);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(167, 32);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // NewuserB
            // 
            this.NewuserB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NewuserB.FlatAppearance.BorderSize = 3;
            this.NewuserB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.NewuserB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.NewuserB.Font = new System.Drawing.Font("OCR A Extended", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewuserB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewuserB.Location = new System.Drawing.Point(90, 358);
            this.NewuserB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewuserB.Name = "NewuserB";
            this.NewuserB.Size = new System.Drawing.Size(186, 45);
            this.NewuserB.TabIndex = 6;
            this.NewuserB.Text = "New User";
            this.NewuserB.UseVisualStyleBackColor = true;
            this.NewuserB.Click += new System.EventHandler(this.NewuserB_Click);
            // 
            // LoginB
            // 
            this.LoginB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginB.FlatAppearance.BorderSize = 3;
            this.LoginB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.LoginB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.LoginB.Font = new System.Drawing.Font("OCR A Extended", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginB.Location = new System.Drawing.Point(336, 358);
            this.LoginB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(186, 45);
            this.LoginB.TabIndex = 7;
            this.LoginB.Text = "Login";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // ExitB
            // 
            this.ExitB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExitB.FlatAppearance.BorderSize = 3;
            this.ExitB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.ExitB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.ExitB.Font = new System.Drawing.Font("OCR A Extended", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitB.Location = new System.Drawing.Point(590, 358);
            this.ExitB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(186, 45);
            this.ExitB.TabIndex = 8;
            this.ExitB.Text = "Exit";
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Font = new System.Drawing.Font("OCR A Extended", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MessageBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageBox.Location = new System.Drawing.Point(192, 287);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(141, 20);
            this.MessageBox.TabIndex = 9;
            this.MessageBox.Text = "Message box";
            this.MessageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageBox.Click += new System.EventHandler(this.MessageBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.NewuserB);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginTitle);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("OCR A Extended", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = " Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label LoginTitle;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button NewuserB;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Label MessageBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

