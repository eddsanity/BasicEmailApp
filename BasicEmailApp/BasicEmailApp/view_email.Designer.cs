namespace BasicEmailApp
{
    partial class ViewEmail
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
            this.viewBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewForm = new System.Windows.Forms.Label();
            this.viewSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewDate = new System.Windows.Forms.Label();
            this.attachmentDataView = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.download_attachment_button = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentDataView)).BeginInit();
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
            this.viewBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewBody.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewBody.Location = new System.Drawing.Point(12, 44);
            this.viewBody.Name = "view_body";
            this.viewBody.ReadOnly = true;
            this.viewBody.Size = new System.Drawing.Size(438, 317);
            this.viewBody.TabIndex = 2;
            this.viewBody.Text = "";
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
            this.viewForm.AutoSize = true;
            this.viewForm.Location = new System.Drawing.Point(62, 4);
            this.viewForm.Name = "view_from";
            this.viewForm.Size = new System.Drawing.Size(0, 13);
            this.viewForm.TabIndex = 8;
            // 
            // view_subject
            // 
            this.viewSubject.AutoSize = true;
            this.viewSubject.Location = new System.Drawing.Point(62, 21);
            this.viewSubject.Name = "view_subject";
            this.viewSubject.Size = new System.Drawing.Size(0, 13);
            this.viewSubject.TabIndex = 9;
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
            this.viewDate.AutoSize = true;
            this.viewDate.Location = new System.Drawing.Point(289, 4);
            this.viewDate.Name = "view_date";
            this.viewDate.Size = new System.Drawing.Size(0, 13);
            this.viewDate.TabIndex = 21;
            // 
            // attachments_data_view
            // 
            this.attachmentDataView.AllowUserToAddRows = false;
            this.attachmentDataView.AllowUserToResizeColumns = false;
            this.attachmentDataView.AllowUserToResizeRows = false;
            this.attachmentDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.attachmentDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.attachmentDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.URL});
            this.attachmentDataView.Location = new System.Drawing.Point(12, 380);
            this.attachmentDataView.Name = "attachments_data_view";
            this.attachmentDataView.ReadOnly = true;
            this.attachmentDataView.RowHeadersWidth = 20;
            this.attachmentDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.attachmentDataView.Size = new System.Drawing.Size(438, 109);
            this.attachmentDataView.TabIndex = 24;
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
            this.Controls.Add(this.attachmentDataView);
            this.Controls.Add(this.viewDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewSubject);
            this.Controls.Add(this.viewForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.viewBody);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "view_email";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "viewing ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.attachmentDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox viewBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label viewForm;
        private System.Windows.Forms.Label viewSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label viewDate;
        private System.Windows.Forms.DataGridView attachmentDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.LinkLabel download_attachment_button;
    }
}