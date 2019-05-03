namespace BasicEmailApp
{
    partial class view_email
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
            this.label1 = new System.Windows.Forms.Label();
            this.view_body = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.view_from = new System.Windows.Forms.Label();
            this.view_subject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view_date = new System.Windows.Forms.Label();
            this.attachments_data_view = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download_attachment_button = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.attachments_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject :";
            // 
            // view_body
            // 
            this.view_body.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view_body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view_body.Cursor = System.Windows.Forms.Cursors.Default;
            this.view_body.Location = new System.Drawing.Point(12, 44);
            this.view_body.Name = "view_body";
            this.view_body.ReadOnly = true;
            this.view_body.Size = new System.Drawing.Size(438, 317);
            this.view_body.TabIndex = 2;
            this.view_body.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "From :";
            // 
            // view_from
            // 
            this.view_from.AutoSize = true;
            this.view_from.Location = new System.Drawing.Point(62, 4);
            this.view_from.Name = "view_from";
            this.view_from.Size = new System.Drawing.Size(0, 13);
            this.view_from.TabIndex = 8;
            // 
            // view_subject
            // 
            this.view_subject.AutoSize = true;
            this.view_subject.Location = new System.Drawing.Point(62, 21);
            this.view_subject.Name = "view_subject";
            this.view_subject.Size = new System.Drawing.Size(0, 13);
            this.view_subject.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date : ";
            // 
            // view_date
            // 
            this.view_date.AutoSize = true;
            this.view_date.Location = new System.Drawing.Point(289, 4);
            this.view_date.Name = "view_date";
            this.view_date.Size = new System.Drawing.Size(0, 13);
            this.view_date.TabIndex = 21;
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
            this.attachments_data_view.Location = new System.Drawing.Point(12, 380);
            this.attachments_data_view.Name = "attachments_data_view";
            this.attachments_data_view.ReadOnly = true;
            this.attachments_data_view.RowHeadersWidth = 20;
            this.attachments_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.attachments_data_view.Size = new System.Drawing.Size(438, 109);
            this.attachments_data_view.TabIndex = 24;
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
            // download_attachment_button
            // 
            this.download_attachment_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.download_attachment_button.AutoSize = true;
            this.download_attachment_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.download_attachment_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.download_attachment_button.Location = new System.Drawing.Point(12, 364);
            this.download_attachment_button.Name = "download_attachment_button";
            this.download_attachment_button.Size = new System.Drawing.Size(96, 13);
            this.download_attachment_button.TabIndex = 27;
            this.download_attachment_button.TabStop = true;
            this.download_attachment_button.Text = "download selected";
            this.download_attachment_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.download_attachment_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.download_attachment_button_LinkClicked);
            // 
            // view_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(464, 500);
            this.Controls.Add(this.download_attachment_button);
            this.Controls.Add(this.attachments_data_view);
            this.Controls.Add(this.view_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.view_subject);
            this.Controls.Add(this.view_from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.view_body);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "view_email";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "viewing ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.attachments_data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox view_body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label view_from;
        private System.Windows.Forms.Label view_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label view_date;
        private System.Windows.Forms.DataGridView attachments_data_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.LinkLabel download_attachment_button;
    }
}