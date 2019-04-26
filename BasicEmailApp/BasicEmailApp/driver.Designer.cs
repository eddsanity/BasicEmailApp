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
            this.inbox_data_view = new System.Windows.Forms.DataGridView();
            this.mailing_list_tab = new System.Windows.Forms.TabPage();
            this.refresh_button = new System.Windows.Forms.LinkLabel();
            this.folders_tab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.sorting_option = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.LinkLabel();
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
            this.inbox_tab.Controls.Add(this.inbox_data_view);
            this.inbox_tab.Location = new System.Drawing.Point(4, 4);
            this.inbox_tab.Name = "inbox_tab";
            this.inbox_tab.Padding = new System.Windows.Forms.Padding(3);
            this.inbox_tab.Size = new System.Drawing.Size(898, 545);
            this.inbox_tab.TabIndex = 0;
            this.inbox_tab.Text = "Inbox";
            // 
            // inbox_data_view
            // 
            this.inbox_data_view.AllowUserToAddRows = false;
            this.inbox_data_view.AllowUserToDeleteRows = false;
            this.inbox_data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.inbox_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inbox_data_view.Location = new System.Drawing.Point(0, 3);
            this.inbox_data_view.Name = "inbox_data_view";
            this.inbox_data_view.ReadOnly = true;
            this.inbox_data_view.Size = new System.Drawing.Size(898, 542);
            this.inbox_data_view.TabIndex = 0;
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
            // refresh_button
            // 
            this.refresh_button.ActiveLinkColor = System.Drawing.Color.Red;
            this.refresh_button.AutoSize = true;
            this.refresh_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.refresh_button.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refresh_button.Location = new System.Drawing.Point(195, 10);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(67, 13);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.TabStop = true;
            this.refresh_button.Text = "refresh inbox";
            this.refresh_button.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refresh_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
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
            this.sorting_option.Location = new System.Drawing.Point(73, 7);
            this.sorting_option.Name = "sorting_option";
            this.sorting_option.Size = new System.Drawing.Size(102, 21);
            this.sorting_option.TabIndex = 4;
            this.sorting_option.Text = "Most Recent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            // 
            // send_button
            // 
            this.send_button.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.send_button.AutoSize = true;
            this.send_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.send_button.LinkColor = System.Drawing.Color.Green;
            this.send_button.Location = new System.Drawing.Point(285, 10);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(60, 13);
            this.send_button.TabIndex = 7;
            this.send_button.TabStop = true;
            this.send_button.Text = "send e-mail";
            this.send_button.VisitedLinkColor = System.Drawing.Color.Green;
            // 
            // driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(910, 603);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel send_button;
    }
}