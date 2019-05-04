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
        static Form driverForm = Application.OpenForms["driver"];
        string g_user_email = ((login)loginForm).s_email;
        string g_user_id;
        string connectionString = ((login)loginForm).connectionString;
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
            string send_query = "insert into EMAIL(SENDERID, SUBJECT, BODY, DATE, ARCHIVED, RECEIVERID) " +
                                "values (" + g_user_id + ", '" + subject.Text + "', '" + message_body.Text + "', GETDATE(), 0, ";

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
                    // get EmailID
                    string latest_email_query = "select EMAILID from EMAIL where SENDERID=" + g_user_id +
                                                " and DATE = (select max(DATE) from Email" +
                                                " where SENDERID=" + g_user_id + ")";
                    SqlCommand EmailIDCmd = new SqlCommand(latest_email_query, conn);
                    string email_id = Convert.ToString(EmailIDCmd.ExecuteScalar());

                    foreach (DataGridViewRow attachment_row in attachments_data_view.Rows)
                    {
                        string type = attachment_row.Cells["Type"].Value.ToString();
                        string url = attachment_row.Cells["URL"].Value.ToString();
                        string attachment_query = "insert into ATTACHMENT(EMAILID, TYPE, URL) " +
                                                  "values(" + email_id + ", '" + type + "', '" + url + "')";
                        SqlCommand add_attachement_command = new SqlCommand(attachment_query, conn);
                        add_attachement_command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Email sent.", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // close send window
                    ((driver)driverForm).refreshInbox();
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

        private void add_attachment_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new_attachment attachForm = new new_attachment();
            attachForm.ShowDialog();
        }

        public void add_attachment(string type, string url)
        {
            attachments_data_view.Rows.Add(type, url);
        }

        private void delete_attachment_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (attachments_data_view.SelectedRows == null) return;
            foreach (DataGridViewRow row in attachments_data_view.SelectedRows)
            {
                attachments_data_view.Rows.RemoveAt(row.Index);
            }
        }

        private void mailing_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
