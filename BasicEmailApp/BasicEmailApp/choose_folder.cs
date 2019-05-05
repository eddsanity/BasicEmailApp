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
    public partial class ChooseEmail : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        public string g_userEmail = ((Login)loginForm).s_email;
        string g_userId, g_emailId;
        string connectionString = ((Login)loginForm).connectionString;

        private void add_folder_button_Click(object sender, EventArgs e)
        {
            if (folderDataView.SelectedRows == null) return;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            for (int i = 0; i < folderDataView.SelectedRows.Count; i++)
            {
                string folderId = folderDataView.SelectedRows[i].Cells["FOLDERID"].Value.ToString();
                string addEmailToFolder = "INSERT INTO [FOLDEREMAIL](FOLDERID, EMAILID) VALUES (" + folderId + ", " + g_emailId + ")";
                SqlCommand command = new SqlCommand(addEmailToFolder, conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
            Close();
        }

        private void folder_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folderDataView.CurrentRow != null)
                folderDataView.CurrentRow.Selected = true;
        }

        private void folder_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folderDataView.CurrentRow != null)
                folderDataView.CurrentRow.Selected = true;
        }

        public ChooseEmail(string emailId)
        {
            InitializeComponent();
            // show the names of the folder 
            g_emailId = emailId;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string userIdQuery = "select USERID from [USER] where EMAIL = '" + g_userEmail + "'";
                SqlCommand command = new SqlCommand(userIdQuery, conn);
                g_userId = Convert.ToString(command.ExecuteScalar());

                string notValid = "SELECT [FOLDERID] FROM [FOLDEREMAIL] WHERE [EMAILID] = " + emailId;
                string showFolder = "SELECT [FOLDERID], [NAMEFOLDER] AS [Folder name] FROM [FOLDER] WHERE USERID = " + g_userId;
                string condition = " AND [FOLDERID] NOT IN (" + notValid + ")";
                SqlDataAdapter folderSqlAdpt = new SqlDataAdapter(showFolder + condition, conn);
                DataTable folderDataTable = new DataTable();
                folderSqlAdpt.Fill(folderDataTable);
                folderDataView.DataSource = folderDataTable;
                folderDataView.Columns["FOLDERID"].Visible = false;
                if (folderDataView.CurrentRow != null)
                    folderDataView.CurrentRow.Selected = true;
            }
            conn.Close();
        }
    }
}
