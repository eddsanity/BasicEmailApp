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
    public partial class folder_email : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((login)loginForm).connectionString;
        string g_folder_id;

        public folder_email(string folder_id)
        {
            InitializeComponent();
            g_folder_id = folder_id;
            refreshFolder();
        }

        private void refreshFolder()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string get_emails_in_folder = "SELECT [EMAIL].EMAILID, [USER].FIRSTNAME AS [Sent by], [EMAIL].SUBJECT AS [Subject], [EMAIL].DATE AS [Date] " + 
                    "FROM [USER], [FOLDEREMAIL], [EMAIL]";
                string join_condition = "WHERE [FOLDEREMAIL].EMAILID = [EMAIL].EMAILID AND [EMAIL].RECEIVERID = [USER].USERID AND [FOLDEREMAIL].FOLDERID = " + g_folder_id;

                SqlDataAdapter sqlAdpt = new SqlDataAdapter(get_emails_in_folder + join_condition, conn);

                DataTable folder_email_data_table = new DataTable();
                sqlAdpt.Fill(folder_email_data_table);
                folder_email_data_view.DataSource = folder_email_data_table;
                folder_email_data_view.Columns["EMAILID"].Visible = false;

            }
        }

        private void delete_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folder_email_data_view.SelectedRows == null || folder_email_data_view.SelectedRows.Count == 0) return;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            for (int i = 0; i < folder_email_data_view.SelectedRows.Count; i++)
            {
                string email_id = folder_email_data_view.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                string delete_email_query = "DELETE FROM [FOLDEREMAIL] WHERE EMAILID = " + email_id;
                SqlCommand ValidateCmd = new SqlCommand(delete_email_query, conn);
                ValidateCmd.ExecuteNonQuery();
            }
            conn.Close();
            refreshFolder();
            MessageBox.Show("deleted successfuly");
        }

        private void folder_email_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folder_email_data_view.CurrentRow != null)
                folder_email_data_view.CurrentRow.Selected = true;
        }

        private void view_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folder_email_data_view.SelectedRows == null || folder_email_data_view.SelectedRows.Count != 1) return;
            string selected_email = folder_email_data_view.CurrentRow.Cells["EMAILID"].Value.ToString();
            view_email View = new view_email(selected_email);
            View.ShowDialog();
        }

        private void folder_email_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folder_email_data_view.CurrentRow != null)
                folder_email_data_view.CurrentRow.Selected = true;
        }
    }
}
