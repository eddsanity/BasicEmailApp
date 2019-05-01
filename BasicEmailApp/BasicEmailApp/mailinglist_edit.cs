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
    public partial class mailinglist_edit : Form
    {
        string Listid;
        string g_user_id;
        static Form driverForm = Application.OpenForms["driver"];
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((login)loginForm).connectionString;
        public mailinglist_edit(string id, string listid)
        {
            InitializeComponent();
            g_user_id = id;
            Listid = listid;
        }

        private void mailinglist_edit_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_mailinglist_users = "select u.EMAIL as Email , u.USERID from [USER] u ,MAILINGLISTUSERS m where u.USERID = m.USERID and m.LISTID=" + Listid;
            SqlDataAdapter sqlAdpt = new SqlDataAdapter(get_mailinglist_users, conn);
            DataTable users_table = new DataTable();
            sqlAdpt.Fill(users_table);
            users_in_mailinglist.DataSource = users_table;
            users_in_mailinglist.Columns["USERID"].Visible = false;
            if (users_in_mailinglist.CurrentRow != null)
                users_in_mailinglist.CurrentRow.Selected = true;
            conn.Close();
        }
        private void update_basic_info_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string user_email = email.Text;
            string check = "select count(EMAIL) from [USER] where (EMAIL = '" + user_email + "')";
            SqlCommand comm = new SqlCommand(check, conn);
            int check1 = Convert.ToInt16(comm.ExecuteScalar());
            if (check1 == 1)
            {
                string get_user_id = "select USERID from [USER] where EMAIL = '" + user_email + "'";
                comm = new SqlCommand(get_user_id, conn);
                string user_id = Convert.ToString(comm.ExecuteScalar());
                check = "select count(USERID) from MAILINGLISTUSERS where LISTID =" + Listid + "and USERID = " + user_id;
                comm = new SqlCommand(check, conn);
                check1 = Convert.ToInt16(comm.ExecuteScalar());
                if (check1 != 1)
                {
                    string add_user = "insert into MAILINGLISTUSERS(LISTID , USERID) values (" + Listid + "," + user_id + ")";
                    //MessageBox.Show(add_user, "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comm = new SqlCommand(add_user, conn);
                    comm.ExecuteNonQuery();
                    user_msg.Text = "Email successfully added!";
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
            if (users_in_mailinglist.CurrentRow == null)
            {
                MessageBox.Show("Select an Email to delete", "Delete user failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (users_in_mailinglist.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < users_in_mailinglist.SelectedRows.Count; i++)
                    {
                        string selected_email = users_in_mailinglist.SelectedRows[i].Cells["USERID"].Value.ToString();
                        string delete_selected_query = "delete from MAILINGLISTUSERS where USERID = " + selected_email + " and LISTID = " + Listid;
                        SqlCommand comm = new SqlCommand(delete_selected_query, conn);
                        comm.ExecuteNonQuery();
                    }
                    user_msg.Text = "Delete successful!";
                    refresh();
                    if (users_in_mailinglist.CurrentRow != null)
                        users_in_mailinglist.CurrentRow.Selected = true;

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
            if (newname.Text != "")
            {
                string change_name = "update MAILINGLIST set NAMEMAILINGLIST = '" + newname.Text + "' where LISTID =" + Listid;
                SqlCommand comm = new SqlCommand(change_name, conn);
                comm.ExecuteNonQuery();
                ((driver)driverForm).refreshInbox();
                conn.Close();
            }
            this.Close();
        }

        private void users_in_mailinglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selects the entire row instead of individual cells
            users_in_mailinglist.CurrentRow.Selected = true;
        }
    }
}
