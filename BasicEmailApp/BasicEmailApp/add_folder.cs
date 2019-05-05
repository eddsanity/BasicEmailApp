using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BasicEmailApp
{
    public partial class AddFolder : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((Login)loginForm).connectionString;
        string g_userID;

        public AddFolder(string userID)
        {
            InitializeComponent();
            g_userID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            folderName.Text = folderName.Text.Replace("'", "''");
            string addFolderQuery = "INSERT INTO [FOLDER] (NAMEFOLDER, USERID) VALUES ('" + folderName.Text + "'," + g_userID + ");";
            SqlCommand command = new SqlCommand(addFolderQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();
            folderName.Text = folderName.Text.Replace("''", "'");
            MessageBox.Show("Folder added successfully");
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
