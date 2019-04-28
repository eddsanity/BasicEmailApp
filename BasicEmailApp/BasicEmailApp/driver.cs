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
    public partial class driver : Form
    {
        //gets the e-mail used after successfully logging in and saves it in the driver for future use.
        static Form loginForm = Application.OpenForms["login"];
        string g_user_email = ((login)loginForm).s_email;
        string connectionString = "Data Source=EYAD;Initial Catalog=emailApp;Integrated Security=True";
        public driver()
        {
            InitializeComponent();
        }

        private void driver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void refreshInbox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                //get table of all e-mails sent to this user
                string get_emails_to_account = "select * from EMAIL inner join [USER] ";
                string get_condition = "on EMAIL.RECEIVERID IN(select USERID from[USER] where [USER].EMAIL = '" + g_user_email + "' OR [USER].USERNAME = '" + g_user_email + "') AND [USER].USERID = EMAIL.RECEIVERID";

                //to get the sender name and display the table properly
                string show_emails_with_sender = "select [USER].FIRSTNAME as [Sent by], [BODY] as [e-mail body], [DATE] as [Date] from [USER] inner join (" + get_emails_to_account + get_condition + ") as Q";
                string show_condition = " on [USER].USERID = Q.SENDERID order by [DATE] DESC";

                SqlDataAdapter sqlAdpt = new SqlDataAdapter(show_emails_with_sender + show_condition, conn);

                //inbox_data_table has all the rows from executing show_emails_with_sender + show_condition
                DataTable inbox_data_table = new DataTable();
                sqlAdpt.Fill(inbox_data_table);

                inbox_data_view.DataSource = inbox_data_table;

            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refreshInbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void driver_Load(object sender, EventArgs e)
        {
            logged_in_as.Text = "logged in as <" + g_user_email + ">";

            //loads data into inbox_grid_view
            refreshInbox();

            //TODO: SQL querIES to load all the data needed for all tabs
            //[DONE] TODO: Load messages and their senders into the inbox_data_view and sort them from most recent to oldest
            //TODO: Load folders in their respective way in the Folders tab
            //TODO: Load mailing list in its respective way in the Mailing List tab

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inbox_data_view.CurrentRow == null)
            {
                status_label.Text = "select something to delete.";
            }
            else
            {
                string selected_sender = inbox_data_view.CurrentRow.Cells["FIRSTNAME"].Value.ToString();
                string selected_email = inbox_data_view.CurrentRow.Cells["BODY"].Value.ToString();
            }
            //TODO: Delete query to delete the emails with the fitting sender and email
            string delete_selected_query = "";

            //TODO: Execute query
            //int rowsDeleted = access.execute(delete_selected_query);

            //if(rowsDeleted > 0)
            //{
            //  status_label.Text = "Deleted " + rowsDeleted.ToString() + "e-mails.";
            //}
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            edit_account editAccForm = new edit_account();
            editAccForm.ShowDialog();
        }

        private void send_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            send_new sendForm = new send_new();
            sendForm.ShowDialog();
        }

        private void inbox_data_view_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //TODO: delete row functionality
        }
    }
}
