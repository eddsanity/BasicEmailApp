namespace BasicEmailApp
{
    partial class choose_folder
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
            this.folder_data_view = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_folder_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.folder_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // folder_data_view
            // 
            this.folder_data_view.AllowUserToAddRows = false;
            this.folder_data_view.AllowUserToResizeColumns = false;
            this.folder_data_view.AllowUserToResizeRows = false;
            this.folder_data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.folder_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.folder_data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7});
            this.folder_data_view.Location = new System.Drawing.Point(-1, 0);
            this.folder_data_view.Name = "folder_data_view";
            this.folder_data_view.ReadOnly = true;
            this.folder_data_view.RowHeadersWidth = 20;
            this.folder_data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.folder_data_view.Size = new System.Drawing.Size(562, 291);
            this.folder_data_view.TabIndex = 17;
            this.folder_data_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folder_data_view_CellClick);
            this.folder_data_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folder_data_view_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Folder name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Folder name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // add_folder_button
            // 
            this.add_folder_button.AutoSize = true;
            this.add_folder_button.BackColor = System.Drawing.Color.Brown;
            this.add_folder_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_folder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_folder_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_folder_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.add_folder_button.Location = new System.Drawing.Point(0, 295);
            this.add_folder_button.Name = "add_folder_button";
            this.add_folder_button.Size = new System.Drawing.Size(559, 25);
            this.add_folder_button.TabIndex = 18;
            this.add_folder_button.Text = "add";
            this.add_folder_button.UseVisualStyleBackColor = false;
            this.add_folder_button.Click += new System.EventHandler(this.add_folder_button_Click);
            // 
            // choose_folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 320);
            this.Controls.Add(this.add_folder_button);
            this.Controls.Add(this.folder_data_view);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "choose_folder";
            this.Text = "choose folder";
            ((System.ComponentModel.ISupportInitialize)(this.folder_data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView folder_data_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button add_folder_button;
    }
}