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
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailing_list_tab = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailinglist_data_view = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.folders_tab = new System.Windows.Forms.TabPage();
            this.archive_tab = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.archive_data_view = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.view_archived = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.delete_archived = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.LinkLabel();
            this.sep3 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.LinkLabel();
            this.edit_button = new System.Windows.Forms.LinkLabel();
            this.sep4 = new System.Windows.Forms.Label();
            this.logged_in_as = new System.Windows.Forms.Label();
            this.sep1 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.tab_control.SuspendLayout();
            this.inbox_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inbox_data_view)).BeginInit();
            this.mailing_list_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailinglist_data_view)).BeginInit();
            this.archive_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_data_view)).BeginInit();
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
            this.tab_control.Size = new System.Drawing.Size(921, 571);
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
            this.inbox_tab.Size = new System.Drawing.Size(913, 545);
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
            this.forward_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forward_button_LinkClicked);
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
            this.reply_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reply_button_LinkClicked);
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
            this.archive_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.archive_button_LinkClicked);
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
            this.view_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.view_button_LinkClicked);
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
            this.Sender,
            this.Subject,
            this.DATE});
            this.inbox_data_view.Location = new System.Drawing.Point(0, 18);
            this.inbox_data_view.Name = "inbox_data_view";
            this.inbox_data_view.ReadOnly = true;
            this.inbox_data_view.RowHeadersWidth = 20;
            this.inbox_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inbox_data_view.Size = new System.Drawing.Size(913, 527);
            this.inbox_data_view.TabIndex = 0;
            this.inbox_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inbox_data_view_CellClick);
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sent by";
            this.Sender.HeaderText = "Sent by";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            this.Sender.Width = 120;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 650;
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "Date";
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            this.DATE.Width = 104;
            // 
            // mailing_list_tab
            // 
            this.mailing_list_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mailing_list_tab.Controls.Add(this.label12);
            this.mailing_list_tab.Controls.Add(this.label1);
            this.mailing_list_tab.Controls.Add(this.mailinglist_data_view);
            this.mailing_list_tab.Controls.Add(this.linkLabel6);
            this.mailing_list_tab.Controls.Add(this.linkLabel5);
            this.mailing_list_tab.Controls.Add(this.linkLabel4);
            this.mailing_list_tab.Location = new System.Drawing.Point(4, 4);
            this.mailing_list_tab.Name = "mailing_list_tab";
            this.mailing_list_tab.Padding = new System.Windows.Forms.Padding(3);
            this.mailing_list_tab.Size = new System.Drawing.Size(913, 545);
            this.mailing_list_tab.TabIndex = 1;
            this.mailing_list_tab.Text = "Mailing List";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(9, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "|";
            // 
            // mailinglist_data_view
            // 
            this.mailinglist_data_view.AllowUserToAddRows = false;
            this.mailinglist_data_view.AllowUserToResizeColumns = false;
            this.mailinglist_data_view.AllowUserToResizeRows = false;
            this.mailinglist_data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.mailinglist_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mailinglist_data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.mailinglist_data_view.Location = new System.Drawing.Point(0, 19);
            this.mailinglist_data_view.Name = "mailinglist_data_view";
            this.mailinglist_data_view.ReadOnly = true;
            this.mailinglist_data_view.RowHeadersWidth = 20;
            this.mailinglist_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mailinglist_data_view.Size = new System.Drawing.Size(913, 527);
            this.mailinglist_data_view.TabIndex = 3;
            this.mailinglist_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailinglist_data_view_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 890;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel6.Location = new System.Drawing.Point(118, 3);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(24, 13);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "edit";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel5.Location = new System.Drawing.Point(60, 3);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(37, 13);
            this.linkLabel5.TabIndex = 1;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "create";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel4.Location = new System.Drawing.Point(3, 3);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(36, 13);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "delete";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // folders_tab
            // 
            this.folders_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.folders_tab.Location = new System.Drawing.Point(4, 4);
            this.folders_tab.Name = "folders_tab";
            this.folders_tab.Size = new System.Drawing.Size(913, 545);
            this.folders_tab.TabIndex = 2;
            this.folders_tab.Text = "Folders";
            // 
            // archive_tab
            // 
            this.archive_tab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.archive_tab.Controls.Add(this.linkLabel1);
            this.archive_tab.Controls.Add(this.archive_data_view);
            this.archive_tab.Controls.Add(this.label8);
            this.archive_tab.Controls.Add(this.view_archived);
            this.archive_tab.Controls.Add(this.linkLabel2);
            this.archive_tab.Controls.Add(this.delete_archived);
            this.archive_tab.Controls.Add(this.label9);
            this.archive_tab.Controls.Add(this.label11);
            this.archive_tab.Controls.Add(this.linkLabel3);
            this.archive_tab.Controls.Add(this.label10);
            this.archive_tab.Location = new System.Drawing.Point(4, 4);
            this.archive_tab.Name = "archive_tab";
            this.archive_tab.Size = new System.Drawing.Size(913, 545);
            this.archive_tab.TabIndex = 3;
            this.archive_tab.Text = "Archive";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(401, 2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 13);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "forward selected";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // archive_data_view
            // 
            this.archive_data_view.AllowUserToAddRows = false;
            this.archive_data_view.AllowUserToResizeColumns = false;
            this.archive_data_view.AllowUserToResizeRows = false;
            this.archive_data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.archive_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.archive_data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.archive_data_view.Location = new System.Drawing.Point(0, 18);
            this.archive_data_view.Name = "archive_data_view";
            this.archive_data_view.ReadOnly = true;
            this.archive_data_view.RowHeadersWidth = 20;
            this.archive_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.archive_data_view.Size = new System.Drawing.Size(913, 527);
            this.archive_data_view.TabIndex = 15;
            this.archive_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.archive_data_view_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Sent by";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sent by";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 650;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "|";
            // 
            // view_archived
            // 
            this.view_archived.ActiveLinkColor = System.Drawing.Color.Red;
            this.view_archived.AutoSize = true;
            this.view_archived.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.view_archived.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_archived.Location = new System.Drawing.Point(103, 2);
            this.view_archived.Name = "view_archived";
            this.view_archived.Size = new System.Drawing.Size(72, 13);
            this.view_archived.TabIndex = 25;
            this.view_archived.TabStop = true;
            this.view_archived.Text = "view selected";
            this.view_archived.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.view_archived.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.view_archived_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(297, 2);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(84, 13);
            this.linkLabel2.TabIndex = 29;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "reply to selected";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // delete_archived
            // 
            this.delete_archived.ActiveLinkColor = System.Drawing.Color.Red;
            this.delete_archived.AutoSize = true;
            this.delete_archived.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.delete_archived.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_archived.Location = new System.Drawing.Point(3, 2);
            this.delete_archived.Name = "delete_archived";
            this.delete_archived.Size = new System.Drawing.Size(79, 13);
            this.delete_archived.TabIndex = 23;
            this.delete_archived.TabStop = true;
            this.delete_archived.Text = "delete selected";
            this.delete_archived.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_archived.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.delete_archived_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(9, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "|";
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel3.Location = new System.Drawing.Point(187, 2);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(97, 13);
            this.linkLabel3.TabIndex = 27;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "unarchive selected";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "|";
            // 
            // refresh_button
            // 
            this.refresh_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refresh_button.AutoSize = true;
            this.refresh_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.refresh_button.LinkColor = System.Drawing.Color.Green;
            this.refresh_button.Location = new System.Drawing.Point(257, 9);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(67, 13);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.TabStop = true;
            this.refresh_button.Text = "refresh inbox";
            this.refresh_button.VisitedLinkColor = System.Drawing.Color.Green;
            this.refresh_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // sep3
            // 
            this.sep3.AutoSize = true;
            this.sep3.Location = new System.Drawing.Point(327, 9);
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
            this.send_button.Location = new System.Drawing.Point(347, 9);
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
            this.edit_button.Location = new System.Drawing.Point(438, 9);
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
            this.sep4.Location = new System.Drawing.Point(413, 9);
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
            this.status_label.Location = new System.Drawing.Point(621, 9);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 13);
            this.status_label.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "status:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(570, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(9, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "|";
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.Green;
            this.linkLabel7.Location = new System.Drawing.Point(525, 9);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(39, 13);
            this.linkLabel7.TabIndex = 16;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "log out";
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.Green;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(924, 603);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.logged_in_as);
            this.Controls.Add(this.sep4);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.sep3);
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
            this.mailing_list_tab.ResumeLayout(false);
            this.mailing_list_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailinglist_data_view)).EndInit();
            this.archive_tab.ResumeLayout(false);
            this.archive_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_data_view)).EndInit();
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
        private System.Windows.Forms.DataGridView archive_data_view;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel view_archived;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel delete_archived;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.DataGridView mailinglist_data_view;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel7;
    }
}