namespace BasicEmailApp
{
    partial class mailinglist_edit
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
            this.newname = new System.Windows.Forms.TextBox();
            this.users_in_mailinglist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.update_basic_info = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.user_msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.users_in_mailinglist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mailing List new name :";
            // 
            // newname
            // 
            this.newname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newname.Location = new System.Drawing.Point(12, 25);
            this.newname.Name = "newname";
            this.newname.Size = new System.Drawing.Size(482, 20);
            this.newname.TabIndex = 1;
            // 
            // users_in_mailinglist
            // 
            this.users_in_mailinglist.AllowUserToAddRows = false;
            this.users_in_mailinglist.AllowUserToResizeColumns = false;
            this.users_in_mailinglist.AllowUserToResizeRows = false;
            this.users_in_mailinglist.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.users_in_mailinglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.users_in_mailinglist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.users_in_mailinglist.Location = new System.Drawing.Point(12, 115);
            this.users_in_mailinglist.Name = "users_in_mailinglist";
            this.users_in_mailinglist.ReadOnly = true;
            this.users_in_mailinglist.RowHeadersWidth = 20;
            this.users_in_mailinglist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.users_in_mailinglist.Size = new System.Drawing.Size(485, 344);
            this.users_in_mailinglist.TabIndex = 2;
            this.users_in_mailinglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_in_mailinglist_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 463;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email :";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.email.Location = new System.Drawing.Point(53, 49);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(441, 20);
            this.email.TabIndex = 4;
            // 
            // update_basic_info
            // 
            this.update_basic_info.BackColor = System.Drawing.Color.Brown;
            this.update_basic_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_basic_info.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_basic_info.Location = new System.Drawing.Point(12, 75);
            this.update_basic_info.Name = "update_basic_info";
            this.update_basic_info.Size = new System.Drawing.Size(122, 23);
            this.update_basic_info.TabIndex = 14;
            this.update_basic_info.Text = "Add email";
            this.update_basic_info.UseVisualStyleBackColor = false;
            this.update_basic_info.Click += new System.EventHandler(this.update_basic_info_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(365, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete email";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(172, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user_msg
            // 
            this.user_msg.AutoSize = true;
            this.user_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.user_msg.Location = new System.Drawing.Point(12, 101);
            this.user_msg.Name = "user_msg";
            this.user_msg.Size = new System.Drawing.Size(0, 13);
            this.user_msg.TabIndex = 18;
            // 
            // mailinglist_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 503);
            this.Controls.Add(this.user_msg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.update_basic_info);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.users_in_mailinglist);
            this.Controls.Add(this.newname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mailinglist_edit";
            this.Opacity = 0.9D;
            this.Text = "Edit Mailing List";
            this.Load += new System.EventHandler(this.mailinglist_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_in_mailinglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newname;
        private System.Windows.Forms.DataGridView users_in_mailinglist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button update_basic_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label user_msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}