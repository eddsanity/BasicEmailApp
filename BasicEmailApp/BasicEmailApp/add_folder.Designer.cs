namespace BasicEmailApp
{
    partial class add_folder
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
            this.add_button = new System.Windows.Forms.Button();
            this.folder_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.AutoSize = true;
            this.add_button.BackColor = System.Drawing.Color.Brown;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_button.Location = new System.Drawing.Point(58, 82);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(224, 32);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // folder_name
            // 
            this.folder_name.Location = new System.Drawing.Point(116, 34);
            this.folder_name.Name = "folder_name";
            this.folder_name.Size = new System.Drawing.Size(226, 26);
            this.folder_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(352, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folder_name);
            this.Controls.Add(this.add_button);
            this.Name = "add_folder";
            this.Text = "Add folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox folder_name;
        private System.Windows.Forms.Label label1;
    }
}