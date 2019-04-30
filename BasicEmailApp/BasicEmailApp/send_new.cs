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
    public partial class send_new : Form
    {
        //gets the e-mail used after successfully logging in and saves it future use.
        static Form loginForm = Application.OpenForms["login"];
        string g_user_email = ((login)loginForm).s_email;
        string g_user_id;
        string connectionString = "Data Source=DESKTOP-QF9IM65\\TESTSQL;Initial Catalog=EmailProject;Integrated Security=True";
        public send_new(string sender_email = "", string sender_body = "")
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            receiver_email.Text = sender_email;
            message_body.Text = sender_body;

            if (conn.State == ConnectionState.Open)
            {
                // get userID from email
                string user_id_query = "select USERID from [USER] where EMAIL = '" + g_user_email + "';";
                SqlCommand validateCmd = new SqlCommand(user_id_query, conn);
                g_user_id = Convert.ToString(validateCmd.ExecuteScalar());

                // fill combobox with mailing lists
                string mailing_lists_query = "select NAMEMAILINGLIST, LISTID from MAILINGLIST where USERID = " + g_user_id + ";";
                SqlDataAdapter sqlAdpt = new SqlDataAdapter(mailing_lists_query, conn);
                DataSet mailing_lists_data_set = new DataSet();
                sqlAdpt.Fill(mailing_lists_data_set, "List");
                mailing_list.DisplayMember = "NAMEMAILINGLIST";
                mailing_list.ValueMember = "LISTID";
                mailing_list.DataSource = mailing_lists_data_set.Tables["List"];
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string send_query = "insert into EMAIL(SENDERID, SUBJECT, BODY, DATE, RECEIVERID) " +
                                "values (" + g_user_id + ", '" + subject.Text + "', '" + message_body.Text + "', GETDATE(), ";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            //TODO: Validate the receiver's e-mail and receiver != sender
            if (!check_send_to_list.Checked)
            {
                // get receiver userID from email
                string user_id_query = "select USERID from [USER] where EMAIL = '" + receiver_email.Text + "';";
                SqlCommand validateCmd = new SqlCommand(user_id_query, conn);
                string receiver_user_id = Convert.ToString(validateCmd.ExecuteScalar());
                bool receiverEmailValid = (receiver_user_id.Length != 0) && (receiver_user_id != g_user_id);
                if (!receiverEmailValid)
                {
                    MessageBox.Show("Invalid receiver email.", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // send to receiver email
                    SqlCommand command = new SqlCommand(send_query + receiver_user_id + ");", conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Email sent.", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // close send window
                    this.Close();
                }
            }
            else
            {
                // send to mailing list
                if (mailing_list.Items.Count == 0)
                {
                    MessageBox.Show("You do not have mailing lists.", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string mailing_list_id = mailing_list.SelectedValue.ToString();
                    string mailing_lists_users_query = "select USERID from MAILINGLISTUSERS where LISTID = " + mailing_list_id + ";";
                    SqlDataAdapter sqlAdpt = new SqlDataAdapter(mailing_lists_users_query, conn);
                    DataSet receivers_data_set = new DataSet();
                    sqlAdpt.Fill(receivers_data_set, "Receivers");
                    foreach (DataRow row in receivers_data_set.Tables["Receivers"].Rows)
                    {
                        string receiver_user_id = row["USERID"].ToString();
                        SqlCommand command = new SqlCommand(send_query + receiver_user_id + ");", conn);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Email sent to '" + mailing_list.Text + "' mailing list.", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // close send window
                    this.Close();
                }
            }

            conn.Close();
        }
    }
}
