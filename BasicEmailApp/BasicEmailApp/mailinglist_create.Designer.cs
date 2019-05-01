namespace BasicEmailApp
{
    partial class mailinglist_create
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
            this.mailinglist_name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.mailinglist_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mailing List Name :";
            // 
            // mailinglist_name
            // 
            this.mailinglist_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mailinglist_name.Location = new System.Drawing.Point(12, 25);
            this.mailinglist_name.Name = "mailinglist_name";
            this.mailinglist_name.Size = new System.Drawing.Size(290, 20);
            this.mailinglist_name.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mailinglist_msg
            // 
            this.mailinglist_msg.AutoSize = true;
            this.mailinglist_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mailinglist_msg.Location = new System.Drawing.Point(12, 72);
            this.mailinglist_msg.Name = "mailinglist_msg";
            this.mailinglist_msg.Size = new System.Drawing.Size(0, 13);
            this.mailinglist_msg.TabIndex = 6;
            // 
            // mailinglist_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 86);
            this.Controls.Add(this.mailinglist_msg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mailinglist_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mailinglist_create";
            this.Opacity = 0.9D;
            this.Text = "Create Mailing List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailinglist_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label mailinglist_msg;
    }
}