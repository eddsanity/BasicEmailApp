namespace BasicEmailApp
{
    partial class login
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
            this.button1 = new System.Windows.Forms.Button();
            this.l_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l_regButton = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(44, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_email
            // 
            this.l_email.BackColor = System.Drawing.SystemColors.Window;
            this.l_email.Location = new System.Drawing.Point(44, 23);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(164, 20);
            this.l_email.TabIndex = 1;
            this.l_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // l_pwd
            // 
            this.l_pwd.BackColor = System.Drawing.SystemColors.Window;
            this.l_pwd.Location = new System.Drawing.Point(44, 74);
            this.l_pwd.Name = "l_pwd";
            this.l_pwd.Size = new System.Drawing.Size(164, 20);
            this.l_pwd.TabIndex = 3;
            this.l_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l_pwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t have an e-mail yet?";
            // 
            // l_regButton
            // 
            this.l_regButton.AutoSize = true;
            this.l_regButton.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.l_regButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_regButton.Location = new System.Drawing.Point(165, 136);
            this.l_regButton.Name = "l_regButton";
            this.l_regButton.Size = new System.Drawing.Size(43, 13);
            this.l_regButton.TabIndex = 6;
            this.l_regButton.TabStop = true;
            this.l_regButton.Text = "Sign up";
            this.l_regButton.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.l_regButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_regButton_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(256, 169);
            this.Controls.Add(this.l_regButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail application - sign in";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox l_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel l_regButton;
        public System.Windows.Forms.TextBox l_email;
    }
}

