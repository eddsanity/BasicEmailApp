namespace BasicEmailApp
{
    partial class folder_email
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
            this.folder_email_data_view = new System.Windows.Forms.DataGridView();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_button = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.view_button = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.folder_email_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // folder_email_data_view
            // 
            this.folder_email_data_view.AllowUserToAddRows = false;
            this.folder_email_data_view.AllowUserToResizeColumns = false;
            this.folder_email_data_view.AllowUserToResizeRows = false;
            this.folder_email_data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.folder_email_data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.folder_email_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.folder_email_data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sender,
            this.Subject,
            this.DATE});
            this.folder_email_data_view.Location = new System.Drawing.Point(-2, 30);
            this.folder_email_data_view.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folder_email_data_view.Name = "folder_email_data_view";
            this.folder_email_data_view.ReadOnly = true;
            this.folder_email_data_view.RowHeadersWidth = 20;
            this.folder_email_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.folder_email_data_view.Size = new System.Drawing.Size(899, 531);
            this.folder_email_data_view.TabIndex = 1;
            this.folder_email_data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folder_email_data_view_CellContentClick);
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sent by";
            this.Sender.HeaderText = "Sent by";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "Date";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // delete_button
            // 
            this.delete_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.delete_button.AutoSize = true;
            this.delete_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.Location = new System.Drawing.Point(3, 5);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(117, 20);
            this.delete_button.TabIndex = 13;
            this.delete_button.TabStop = true;
            this.delete_button.Text = "delete selected";
            this.delete_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.delete_button_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "|";
            // 
            // view_button
            // 
            this.view_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.view_button.AutoSize = true;
            this.view_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.view_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_button.Location = new System.Drawing.Point(150, 5);
            this.view_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(103, 20);
            this.view_button.TabIndex = 17;
            this.view_button.TabStop = true;
            this.view_button.Text = "view selected";
            this.view_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.view_button_LinkClicked);
            // 
            // folder_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 564);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.folder_email_data_view);
            this.Name = "folder_email";
            this.Text = "folder email";
            ((System.ComponentModel.ISupportInitialize)(this.folder_email_data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView folder_email_data_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.LinkLabel delete_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel view_button;
    }
}