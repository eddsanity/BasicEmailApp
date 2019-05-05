namespace BasicEmailApp
{
    partial class ChooseEmail
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
            this.folderDataView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_folder_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.folderDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // folder_data_view
            // 
            this.folderDataView.AllowUserToAddRows = false;
            this.folderDataView.AllowUserToResizeColumns = false;
            this.folderDataView.AllowUserToResizeRows = false;
            this.folderDataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.folderDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.folderDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7});
            this.folderDataView.Location = new System.Drawing.Point(-1, 0);
            this.folderDataView.Name = "folder_data_view";
            this.folderDataView.ReadOnly = true;
            this.folderDataView.RowHeadersWidth = 20;
            this.folderDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.folderDataView.Size = new System.Drawing.Size(562, 291);
            this.folderDataView.TabIndex = 17;
            this.folderDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folder_data_view_CellClick);
            this.folderDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.folder_data_view_CellContentClick);
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
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(559, 320);
            this.Controls.Add(this.add_folder_button);
            this.Controls.Add(this.folderDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "choose_folder";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "choose folder";
            ((System.ComponentModel.ISupportInitialize)(this.folderDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView folderDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button add_folder_button;
    }
}