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
    public partial class add_folder : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((login)loginForm).connectionString;
        string g_user_id;
        public add_folder(string user_id)
        {
            InitializeComponent();
            g_user_id = user_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string add_folder_query = "INSERT INTO [FOLDER] (NAMEFOLDER, USERID) VALUES ('" + folder_name.Text + "'," + g_user_id + ");";
            SqlCommand validateCmd = new SqlCommand(add_folder_query, conn);
            validateCmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Folder added successfully");
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
