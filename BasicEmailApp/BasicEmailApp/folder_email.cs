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
    public partial class FolderEmail : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((Login)loginForm).connectionString;
        string g_folderId;

        public FolderEmail(string folderId)
        {
            InitializeComponent();
            g_folderId = folderId;
            refresh_folder();
        }

        private void refresh_folder()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string getEmailInFolder = "SELECT [EMAIL].EMAILID, [USER].FIRSTNAME AS [Sent by], [EMAIL].SUBJECT AS [Subject], [EMAIL].DATE AS [Date] " + 
                    "FROM [USER], [FOLDEREMAIL], [EMAIL]";
                string joinCondition = "WHERE [FOLDEREMAIL].EMAILID = [EMAIL].EMAILID AND [EMAIL].RECEIVERID = [USER].USERID AND [FOLDEREMAIL].FOLDERID = " + g_folderId;

                SqlDataAdapter sqlAdpt = new SqlDataAdapter(getEmailInFolder + joinCondition, conn);

                DataTable folderEmailDataTable = new DataTable();
                sqlAdpt.Fill(folderEmailDataTable);
                folderEmailDataView.DataSource = folderEmailDataTable;
                folderEmailDataView.Columns["EMAILID"].Visible = false;

            }
        }

        private void delete_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folderEmailDataView.SelectedRows == null || folderEmailDataView.SelectedRows.Count == 0) return;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            for (int i = 0; i < folderEmailDataView.SelectedRows.Count; i++)
            {
                string emailId = folderEmailDataView.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                string deleteEmailQuery = "DELETE FROM [FOLDEREMAIL] WHERE EMAILID = " + emailId;
                SqlCommand command = new SqlCommand(deleteEmailQuery, conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
            refresh_folder();
            MessageBox.Show("deleted successfuly");
        }

        private void folder_email_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folderEmailDataView.CurrentRow != null)
                folderEmailDataView.CurrentRow.Selected = true;
        }

        private void view_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folderEmailDataView.SelectedRows == null || folderEmailDataView.SelectedRows.Count != 1) return;
            string selectedEmail = folderEmailDataView.CurrentRow.Cells["EMAILID"].Value.ToString();
            ViewEmail view = new ViewEmail(selectedEmail);
            view.ShowDialog();
        }

        private void folder_email_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folderEmailDataView.CurrentRow != null)
                folderEmailDataView.CurrentRow.Selected = true;
        }
    }
}
