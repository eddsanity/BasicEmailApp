namespace BasicEmailApp
{
    partial class register
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
            this.label1 = new System.Windows.Forms.Label();
            this.r_email = new System.Windows.Forms.TextBox();
            this.r_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.r_pwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pwdMsg = new System.Windows.Forms.Label();
            this.emMsg = new System.Windows.Forms.Label();
            this.r_firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(36, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "sign up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "e-mail";
            // 
            // r_email
            // 
            this.r_email.Location = new System.Drawing.Point(36, 136);
            this.r_email.Name = "r_email";
            this.r_email.Size = new System.Drawing.Size(154, 20);
            this.r_email.TabIndex = 2;
            this.r_email.Leave += new System.EventHandler(this.r_email_Leave);
            // 
            // r_pwd
            // 
            this.r_pwd.Location = new System.Drawing.Point(36, 195);
            this.r_pwd.Name = "r_pwd";
            this.r_pwd.Size = new System.Drawing.Size(154, 20);
            this.r_pwd.TabIndex = 4;
            this.r_pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // r_pwd2
            // 
            this.r_pwd2.Location = new System.Drawing.Point(36, 248);
            this.r_pwd2.Name = "r_pwd2";
            this.r_pwd2.Size = new System.Drawing.Size(154, 20);
            this.r_pwd2.TabIndex = 6;
            this.r_pwd2.UseSystemPasswordChar = true;
            this.r_pwd2.TextChanged += new System.EventHandler(this.r_pwd2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "verify password";
            // 
            // pwdMsg
            // 
            this.pwdMsg.AutoSize = true;
            this.pwdMsg.ForeColor = System.Drawing.Color.Red;
            this.pwdMsg.Location = new System.Drawing.Point(33, 268);
            this.pwdMsg.Name = "pwdMsg";
            this.pwdMsg.Size = new System.Drawing.Size(0, 13);
            this.pwdMsg.TabIndex = 7;
            // 
            // emMsg
            // 
            this.emMsg.AutoSize = true;
            this.emMsg.ForeColor = System.Drawing.Color.Red;
            this.emMsg.Location = new System.Drawing.Point(36, 159);
            this.emMsg.Name = "emMsg";
            this.emMsg.Size = new System.Drawing.Size(0, 13);
            this.emMsg.TabIndex = 8;
            // 
            // r_firstname
            // 
            this.r_firstname.Location = new System.Drawing.Point(36, 26);
            this.r_firstname.Name = "r_firstname";
            this.r_firstname.Size = new System.Drawing.Size(154, 20);
            this.r_firstname.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last Name";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(235, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.r_firstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emMsg);
            this.Controls.Add(this.pwdMsg);
            this.Controls.Add(this.r_pwd2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.r_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.r_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "register";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "sign up";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox r_email;
        private System.Windows.Forms.TextBox r_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox r_pwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pwdMsg;
        private System.Windows.Forms.Label emMsg;
        private System.Windows.Forms.TextBox r_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}