namespace dotnetAss2
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.text = new System.Windows.Forms.Label();
            this.Okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(60, 57);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(68, 17);
            this.text.TabIndex = 0;
            this.text.Text = "label1";
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // Okay
            // 
            this.Okay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Okay.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okay.Location = new System.Drawing.Point(288, 248);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(101, 52);
            this.Okay.TabIndex = 1;
            this.Okay.Text = "OK!";
            this.Okay.UseVisualStyleBackColor = false;
            this.Okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 325);
            this.ControlBox = false;
            this.Controls.Add(this.Okay);
            this.Controls.Add(this.text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button Okay;
    }
}