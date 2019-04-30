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
            this.download_attachments = new System.Windows.Forms.LinkLabel();
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
            this.view_body.Location = new System.Drawing.Point(0, 37);
            this.view_body.Name = "view_body";
            this.view_body.ReadOnly = true;
            this.view_body.Size = new System.Drawing.Size(852, 471);
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
            this.view_from.Location = new System.Drawing.Point(64, 4);
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
            // download_attachments
            // 
            this.download_attachments.ActiveLinkColor = System.Drawing.Color.Red;
            this.download_attachments.AutoSize = true;
            this.download_attachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_attachments.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.download_attachments.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.download_attachments.Location = new System.Drawing.Point(12, 511);
            this.download_attachments.Name = "download_attachments";
            this.download_attachments.Size = new System.Drawing.Size(136, 13);
            this.download_attachments.TabIndex = 19;
            this.download_attachments.TabStop = true;
            this.download_attachments.Text = "Download attachments";
            this.download_attachments.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // view_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(852, 526);
            this.Controls.Add(this.download_attachments);
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
            this.Load += new System.EventHandler(this.view_email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox view_body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label view_from;
        private System.Windows.Forms.Label view_subject;
        private System.Windows.Forms.LinkLabel download_attachments;
    }
}