namespace BasicEmailApp
{
    partial class SendNew
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
            this.subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailing_list = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check_send_to_list = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.delete_attachment_button = new System.Windows.Forms.LinkLabel();
            this.add_attachment_button = new System.Windows.Forms.LinkLabel();
            this.attachments_data_view = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.attachments_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.Green;
            this.send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_button.Location = new System.Drawing.Point(9, 497);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(481, 23);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "Send";
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
            this.mailing_list.SelectedIndexChanged += new System.EventHandler(this.mailing_list_SelectedIndexChanged);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(97, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(9, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "|";
            // 
            // delete_attachment_button
            // 
            this.delete_attachment_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.delete_attachment_button.AutoSize = true;
            this.delete_attachment_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_attachment_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_attachment_button.Location = new System.Drawing.Point(111, 366);
            this.delete_attachment_button.Name = "delete_attachment_button";
            this.delete_attachment_button.Size = new System.Drawing.Size(79, 13);
            this.delete_attachment_button.TabIndex = 25;
            this.delete_attachment_button.TabStop = true;
            this.delete_attachment_button.Text = "delete selected";
            this.delete_attachment_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_attachment_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.delete_attachment_button_LinkClicked);
            // 
            // add_attachment_button
            // 
            this.add_attachment_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.add_attachment_button.AutoSize = true;
            this.add_attachment_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.add_attachment_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_attachment_button.Location = new System.Drawing.Point(9, 366);
            this.add_attachment_button.Name = "add_attachment_button";
            this.add_attachment_button.Size = new System.Drawing.Size(87, 13);
            this.add_attachment_button.TabIndex = 24;
            this.add_attachment_button.TabStop = true;
            this.add_attachment_button.Text = "add attachement";
            this.add_attachment_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add_attachment_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.add_attachment_button_LinkClicked);
            // 
            // attachments_data_view
            // 
            this.attachments_data_view.AllowUserToAddRows = false;
            this.attachments_data_view.AllowUserToResizeColumns = false;
            this.attachments_data_view.AllowUserToResizeRows = false;
            this.attachments_data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.attachments_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.attachments_data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.URL});
            this.attachments_data_view.Location = new System.Drawing.Point(6, 382);
            this.attachments_data_view.Name = "attachments_data_view";
            this.attachments_data_view.ReadOnly = true;
            this.attachments_data_view.RowHeadersWidth = 20;
            this.attachments_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.attachments_data_view.Size = new System.Drawing.Size(484, 109);
            this.attachments_data_view.TabIndex = 23;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 120;
            // 
            // URL
            // 
            this.URL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // send_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(502, 532);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.delete_attachment_button);
            this.Controls.Add(this.add_attachment_button);
            this.Controls.Add(this.attachments_data_view);
            this.Controls.Add(this.check_send_to_list);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailing_list);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message_body);
            this.Controls.Add(this.receiver_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "send_new";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send";
            ((System.ComponentModel.ISupportInitialize)(this.attachments_data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receiver_email;
        private System.Windows.Forms.RichTextBox message_body;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mailing_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_send_to_list;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel delete_attachment_button;
        private System.Windows.Forms.LinkLabel add_attachment_button;
        private System.Windows.Forms.DataGridView attachments_data_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
    }
}