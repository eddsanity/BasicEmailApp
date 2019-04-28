namespace BasicEmailApp
{
    partial class driver
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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.inbox_tab = new System.Windows.Forms.TabPage();
            this.forward_button = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.reply_button = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.archive_button = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.view_button = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.LinkLabel();
            this.inbox_data_view = new System.Windows.Forms.DataGridView();
            this.mailing_list_tab = new System.Windows.Forms.TabPage();
            this.folders_tab = new System.Windows.Forms.TabPage();
            this.archive_tab = new System.Windows.Forms.TabPage();
            this.refresh_button = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.sorting_option = new System.Windows.Forms.ComboBox();
            this.sep2 = new System.Windows.Forms.Label();
            this.sep3 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.LinkLabel();
            this.edit_button = new System.Windows.Forms.LinkLabel();
            this.sep4 = new System.Windows.Forms.Label();
            this.logged_in_as = new System.Windows.Forms.Label();
            this.sep1 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FIRSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BODY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_control.SuspendLayout();
            this.inbox_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_control.Controls.Add(this.inbox_tab);
            this.tab_control.Controls.Add(this.mailing_list_tab);
            this.tab_control.Controls.Add(this.folders_tab);
            this.tab_control.Controls.Add(this.archive_tab);
            this.tab_control.HotTrack = true;
            this.tab_control.Location = new System.Drawing.Point(1, 32);
            this.tab_control.Multiline = true;
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(906, 571);
            this.tab_control.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_control.TabIndex = 0;
            // 
            // inbox_tab
            // 
            this.inbox_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inbox_tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inbox_tab.Controls.Add(this.forward_button);
            this.inbox_tab.Controls.Add(this.label7);
            this.inbox_tab.Controls.Add(this.reply_button);
            this.inbox_tab.Controls.Add(this.label6);
            this.inbox_tab.Controls.Add(this.archive_button);
            this.inbox_tab.Controls.Add(this.label5);
            this.inbox_tab.Controls.Add(this.view_button);
            this.inbox_tab.Controls.Add(this.label4);
            this.inbox_tab.Controls.Add(this.delete_button);
            this.inbox_tab.Controls.Add(this.inbox_data_view);
            this.inbox_tab.Location = new System.Drawing.Point(4, 4);
            this.inbox_tab.Name = "inbox_tab";
            this.inbox_tab.Padding = new System.Windows.Forms.Padding(3);
            this.inbox_tab.Size = new System.Drawing.Size(898, 545);
            this.inbox_tab.TabIndex = 0;
            this.inbox_tab.Text = "Inbox";
            // 
            // forward_button
            // 
            this.forward_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.forward_button.AutoSize = true;
            this.forward_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forward_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.forward_button.Location = new System.Drawing.Point(401, 2);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(85, 13);
            this.forward_button.TabIndex = 22;
            this.forward_button.TabStop = true;
            this.forward_button.Text = "forward selected";
            this.forward_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "|";
            // 
            // reply_button
            // 
            this.reply_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.reply_button.AutoSize = true;
            this.reply_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.reply_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reply_button.Location = new System.Drawing.Point(297, 2);
            this.reply_button.Name = "reply_button";
            this.reply_button.Size = new System.Drawing.Size(84, 13);
            this.reply_button.TabIndex = 20;
            this.reply_button.TabStop = true;
            this.reply_button.Text = "reply to selected";
            this.reply_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "|";
            // 
            // archive_button
            // 
            this.archive_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.archive_button.AutoSize = true;
            this.archive_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.archive_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.archive_button.Location = new System.Drawing.Point(194, 2);
            this.archive_button.Name = "archive_button";
            this.archive_button.Size = new System.Drawing.Size(85, 13);
            this.archive_button.TabIndex = 18;
            this.archive_button.TabStop = true;
            this.archive_button.Text = "archive selected";
            this.archive_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "|";
            // 
            // view_button
            // 
            this.view_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.view_button.AutoSize = true;
            this.view_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.view_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_button.Location = new System.Drawing.Point(103, 2);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(72, 13);
            this.view_button.TabIndex = 16;
            this.view_button.TabStop = true;
            this.view_button.Text = "view selected";
            this.view_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "|";
            // 
            // delete_button
            // 
            this.delete_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.delete_button.AutoSize = true;
            this.delete_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.Location = new System.Drawing.Point(3, 2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(79, 13);
            this.delete_button.TabIndex = 12;
            this.delete_button.TabStop = true;
            this.delete_button.Text = "delete selected";
            this.delete_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // inbox_data_view
            // 
            this.inbox_data_view.AllowUserToAddRows = false;
            this.inbox_data_view.AllowUserToResizeColumns = false;
            this.inbox_data_view.AllowUserToResizeRows = false;
            this.inbox_data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.inbox_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inbox_data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIRSTNAME,
            this.BODY,
            this.DATE});
            this.inbox_data_view.Location = new System.Drawing.Point(0, 18);
            this.inbox_data_view.Name = "inbox_data_view";
            this.inbox_data_view.ReadOnly = true;
            this.inbox_data_view.RowHeadersWidth = 20;
            this.inbox_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inbox_data_view.Size = new System.Drawing.Size(898, 527);
            this.inbox_data_view.TabIndex = 0;
            this.inbox_data_view.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.inbox_data_view_UserDeletingRow);
            // 
            // mailing_list_tab
            // 
            this.mailing_list_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mailing_list_tab.Location = new System.Drawing.Point(4, 4);
            this.mailing_list_tab.Name = "mailing_list_tab";
            this.mailing_list_tab.Padding = new System.Windows.Forms.Padding(3);
            this.mailing_list_tab.Size = new System.Drawing.Size(898, 545);
            this.mailing_list_tab.TabIndex = 1;
            this.mailing_list_tab.Text = "Mailing List";
            // 
            // folders_tab
            // 
            this.folders_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.folders_tab.Location = new System.Drawing.Point(4, 4);
            this.folders_tab.Name = "folders_tab";
            this.folders_tab.Size = new System.Drawing.Size(898, 545);
            this.folders_tab.TabIndex = 2;
            this.folders_tab.Text = "Folders";
            // 
            // archive_tab
            // 
            this.archive_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.archive_tab.Location = new System.Drawing.Point(4, 4);
            this.archive_tab.Name = "archive_tab";
            this.archive_tab.Size = new System.Drawing.Size(898, 545);
            this.archive_tab.TabIndex = 3;
            this.archive_tab.Text = "Archive";
            // 
            // refresh_button
            // 
            this.refresh_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refresh_button.AutoSize = true;
            this.refresh_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.refresh_button.LinkColor = System.Drawing.Color.Green;
            this.refresh_button.Location = new System.Drawing.Point(462, 9);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(67, 13);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.TabStop = true;
            this.refresh_button.Text = "refresh inbox";
            this.refresh_button.VisitedLinkColor = System.Drawing.Color.Green;
            this.refresh_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sort by inbox: ";
            // 
            // sorting_option
            // 
            this.sorting_option.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sorting_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sorting_option.FormattingEnabled = true;
            this.sorting_option.Items.AddRange(new object[] {
            "Oldest",
            "Most Recent",
            "Sender"});
            this.sorting_option.Location = new System.Drawing.Point(340, 6);
            this.sorting_option.Name = "sorting_option";
            this.sorting_option.Size = new System.Drawing.Size(102, 21);
            this.sorting_option.TabIndex = 4;
            this.sorting_option.Text = "Most Recent";
            // 
            // sep2
            // 
            this.sep2.AutoSize = true;
            this.sep2.Location = new System.Drawing.Point(448, 9);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(9, 13);
            this.sep2.TabIndex = 5;
            this.sep2.Text = "|";
            // 
            // sep3
            // 
            this.sep3.AutoSize = true;
            this.sep3.Location = new System.Drawing.Point(532, 9);
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(9, 13);
            this.sep3.TabIndex = 6;
            this.sep3.Text = "|";
            // 
            // send_button
            // 
            this.send_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.send_button.AutoSize = true;
            this.send_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.send_button.LinkColor = System.Drawing.Color.Green;
            this.send_button.Location = new System.Drawing.Point(552, 9);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(60, 13);
            this.send_button.TabIndex = 7;
            this.send_button.TabStop = true;
            this.send_button.Text = "send e-mail";
            this.send_button.VisitedLinkColor = System.Drawing.Color.Green;
            this.send_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.send_button_LinkClicked);
            // 
            // edit_button
            // 
            this.edit_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.edit_button.AutoSize = true;
            this.edit_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.edit_button.LinkColor = System.Drawing.Color.Green;
            this.edit_button.Location = new System.Drawing.Point(643, 9);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(66, 13);
            this.edit_button.TabIndex = 8;
            this.edit_button.TabStop = true;
            this.edit_button.Text = "edit account";
            this.edit_button.VisitedLinkColor = System.Drawing.Color.Green;
            this.edit_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // sep4
            // 
            this.sep4.AutoSize = true;
            this.sep4.Location = new System.Drawing.Point(618, 9);
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(9, 13);
            this.sep4.TabIndex = 9;
            this.sep4.Text = "|";
            // 
            // logged_in_as
            // 
            this.logged_in_as.AutoSize = true;
            this.logged_in_as.Location = new System.Drawing.Point(12, 9);
            this.logged_in_as.Name = "logged_in_as";
            this.logged_in_as.Size = new System.Drawing.Size(10, 13);
            this.logged_in_as.TabIndex = 10;
            this.logged_in_as.Text = ".";
            // 
            // sep1
            // 
            this.sep1.AutoSize = true;
            this.sep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sep1.Location = new System.Drawing.Point(237, 9);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(10, 13);
            this.sep1.TabIndex = 11;
            this.sep1.Text = "|";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(730, 16);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 13);
            this.status_label.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "status:";
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.DataPropertyName = "Sent by";
            this.FIRSTNAME.HeaderText = "Sent by";
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.ReadOnly = true;
            this.FIRSTNAME.Width = 120;
            // 
            // BODY
            // 
            this.BODY.DataPropertyName = "e-mail body";
            this.BODY.HeaderText = "E-mail body";
            this.BODY.Name = "BODY";
            this.BODY.ReadOnly = true;
            this.BODY.Width = 650;
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "Date";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Width = 107;
            // 
            // driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(910, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.logged_in_as);
            this.Controls.Add(this.sep4);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.sep3);
            this.Controls.Add(this.sep2);
            this.Controls.Add(this.sorting_option);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "driver";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.driver_FormClosed);
            this.Load += new System.EventHandler(this.driver_Load);
            this.tab_control.ResumeLayout(false);
            this.inbox_tab.ResumeLayout(false);
            this.inbox_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox_data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage inbox_tab;
        private System.Windows.Forms.TabPage mailing_list_tab;
        private System.Windows.Forms.DataGridView inbox_data_view;
        private System.Windows.Forms.LinkLabel refresh_button;
        private System.Windows.Forms.TabPage folders_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sorting_option;
        private System.Windows.Forms.Label sep2;
        private System.Windows.Forms.Label sep3;
        private System.Windows.Forms.LinkLabel send_button;
        private System.Windows.Forms.LinkLabel edit_button;
        private System.Windows.Forms.Label sep4;
        private System.Windows.Forms.Label logged_in_as;
        private System.Windows.Forms.Label sep1;
        private System.Windows.Forms.LinkLabel delete_button;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage archive_tab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel forward_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel reply_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel archive_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel view_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BODY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
    }
}