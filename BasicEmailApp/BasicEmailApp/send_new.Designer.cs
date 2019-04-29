namespace BasicEmailApp
{
    partial class send_new
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
            this.send_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.receiver_email = new System.Windows.Forms.TextBox();
            this.message_body = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailing_list = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check_send_to_list = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.Green;
            this.send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_button.Location = new System.Drawing.Point(6, 454);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(484, 23);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "send";
            this.send_button.UseVisualStyleBackColor = false;
            this.send_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To: ";
            // 
            // receiver_email
            // 
            this.receiver_email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.receiver_email.Location = new System.Drawing.Point(73, 10);
            this.receiver_email.Name = "receiver_email";
            this.receiver_email.Size = new System.Drawing.Size(195, 20);
            this.receiver_email.TabIndex = 2;
            // 
            // message_body
            // 
            this.message_body.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.message_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message_body.Location = new System.Drawing.Point(6, 100);
            this.message_body.Name = "message_body";
            this.message_body.Size = new System.Drawing.Size(484, 259);
            this.message_body.TabIndex = 3;
            this.message_body.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "HANDLE ATTACHING SOMETHING HERE";
            // 
            // subject
            // 
            this.subject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subject.Location = new System.Drawing.Point(73, 36);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(398, 20);
            this.subject.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject: ";
            // 
            // mailing_list
            // 
            this.mailing_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mailing_list.FormattingEnabled = true;
            this.mailing_list.Location = new System.Drawing.Point(73, 62);
            this.mailing_list.Name = "mailing_list";
            this.mailing_list.Size = new System.Drawing.Size(195, 21);
            this.mailing_list.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mailing List: ";
            // 
            // check_send_to_list
            // 
            this.check_send_to_list.AutoSize = true;
            this.check_send_to_list.Location = new System.Drawing.Point(284, 65);
            this.check_send_to_list.Name = "check_send_to_list";
            this.check_send_to_list.Size = new System.Drawing.Size(78, 17);
            this.check_send_to_list.TabIndex = 10;
            this.check_send_to_list.Text = "Send to list";
            this.check_send_to_list.UseVisualStyleBackColor = true;
            // 
            // send_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(502, 489);
            this.Controls.Add(this.check_send_to_list);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailing_list);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.message_body);
            this.Controls.Add(this.receiver_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "send_new";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receiver_email;
        private System.Windows.Forms.RichTextBox message_body;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mailing_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_send_to_list;
    }
}