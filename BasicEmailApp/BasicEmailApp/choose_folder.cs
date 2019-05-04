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
    public partial class choose_folder : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        public string g_user_email = ((login)loginForm).s_email;
        string g_user_id, g_email_id;
        string connectionString = ((login)loginForm).connectionString;

        private void add_folder_button_Click(object sender, EventArgs e)
        {
            if (folder_data_view.SelectedRows == null) return;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            for (int i = 0; i < folder_data_view.SelectedRows.Count; i++)
            {
                string folder_id = folder_data_view.SelectedRows[i].Cells["FOLDERID"].Value.ToString();
                string add_email_to_folder = "INSERT INTO [FOLDEREMAIL](FOLDERID, EMAILID) VALUES (" + folder_id + ", " + g_email_id + ")";
                SqlCommand ValidateCmd = new SqlCommand(add_email_to_folder, conn);
                ValidateCmd.ExecuteNonQuery();
            }
            conn.Close();
            Close();
        }

        private void folder_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(folder_data_view.CurrentRow != null)
                folder_data_view.CurrentRow.Selected = true;
        }

        private void folder_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folder_data_view.CurrentRow != null)
                folder_data_view.CurrentRow.Selected = true;
        }

        public choose_folder(string email_id)
        {
            InitializeComponent();
            // show the names of the folder 
            g_email_id = email_id;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string user_id_query = "select USERID from [USER] where EMAIL = '" + g_user_email + "'";
                SqlCommand validateCmd = new SqlCommand(user_id_query, conn);
                g_user_id = Convert.ToString(validateCmd.ExecuteScalar());

                string not_valid = "SELECT [FOLDERID] FROM [FOLDEREMAIL] WHERE [EMAILID] = " + email_id;
                string show_folders = "SELECT [FOLDERID], [NAMEFOLDER] AS [Folder name] FROM [FOLDER] WHERE USERID = " + g_user_id;
                string condition = " AND [FOLDERID] NOT IN (" + not_valid + ")";
                SqlDataAdapter foldSqlAdpt = new SqlDataAdapter(show_folders + condition, conn);
                DataTable folder_data_table = new DataTable();
                foldSqlAdpt.Fill(folder_data_table);
                folder_data_view.DataSource = folder_data_table;
                folder_data_view.Columns["FOLDERID"].Visible = false;
                if (folder_data_view.CurrentRow != null)
                    folder_data_view.CurrentRow.Selected = true;
            }
            conn.Close();
        }
    }
}
