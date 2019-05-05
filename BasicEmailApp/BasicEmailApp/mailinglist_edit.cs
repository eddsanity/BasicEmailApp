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
    public partial class MailinglistEdit : Form
    {
        string g_listId;
        string g_userId;
        static Form driverForm = Application.OpenForms["driver"];
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((Login)loginForm).connectionString;
        public MailinglistEdit(string id, string listId)
        {
            InitializeComponent();
            g_userId = id;
            g_listId = listId;
        }

        private void mailinglist_edit_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string getMailinglistUser = "select u.EMAIL as Email , u.USERID from [USER] u ,MAILINGLISTUSERS m where u.USERID = m.USERID and m.LISTID=" + g_listId;
            SqlDataAdapter sqlAdpt = new SqlDataAdapter(getMailinglistUser, conn);
            DataTable userDataTable = new DataTable();
            sqlAdpt.Fill(userDataTable);
            userDataView.DataSource = userDataTable;
            userDataView.Columns["USERID"].Visible = false;
            if (userDataView.CurrentRow != null)
                userDataView.CurrentRow.Selected = true;
            conn.Close();
        }
        private void update_basic_info_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string userEmail = email.Text.Replace("'", "''");
            string check = "select count(EMAIL) from [USER] where (EMAIL = '" + userEmail + "')";
            SqlCommand command = new SqlCommand(check, conn);
            int check1 = Convert.ToInt16(command.ExecuteScalar());
            if (check1 == 1)
            {
                string getUserId = "select USERID from [USER] where EMAIL = '" + userEmail + "'";
                command = new SqlCommand(getUserId, conn);
                string userId = Convert.ToString(command.ExecuteScalar());
                check = "select count(USERID) from MAILINGLISTUSERS where LISTID =" + g_listId + "and USERID = " + userId;
                command = new SqlCommand(check, conn);
                check1 = Convert.ToInt16(command.ExecuteScalar());
                if (check1 != 1)
                {
                    string addUser = "insert into MAILINGLISTUSERS(LISTID , USERID) values (" + g_listId + "," + userId + ")";
                    //MessageBox.Show(add_user, "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command = new SqlCommand(addUser, conn);
                    command.ExecuteNonQuery();
                    userMsg.Text = "Email successfully added!";
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Email already in Mailing List", "Add user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email doesn't exist!", "Add user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (userDataView.CurrentRow == null)
            {
                MessageBox.Show("Select an Email to delete", "Delete user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userDataView.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < userDataView.SelectedRows.Count; i++)
                    {
                        string selectedEmail = userDataView.SelectedRows[i].Cells["USERID"].Value.ToString();
                        string deleteSelectedEmail = "delete from MAILINGLISTUSERS where USERID = " + selectedEmail + " and LISTID = " + g_listId;
                        SqlCommand command = new SqlCommand(deleteSelectedEmail, conn);
                        command.ExecuteNonQuery();
                    }
                    userMsg.Text = "Delete successful!";
                    refresh();
                    if (userDataView.CurrentRow != null)
                        userDataView.CurrentRow.Selected = true;

                }
            }
            conn.Close();
        }

        private void users_in_mailinglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            newName.Text = newName.Text.Replace("'", "''");
            if (newName.Text != "")
            {
                string changeName = "update MAILINGLIST set NAMEMAILINGLIST = '" + newName.Text + "' where LISTID =" + g_listId;
                SqlCommand command = new SqlCommand(changeName, conn);
                command.ExecuteNonQuery();
                ((Driver)driverForm).refresh_inbox();
                conn.Close();
            }
            this.Close();
        }

        private void users_in_mailinglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userDataView.CurrentRow != null)
                userDataView.CurrentRow.Selected = true;
        }
    }
}
