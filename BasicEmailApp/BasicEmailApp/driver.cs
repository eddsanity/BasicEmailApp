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
        public string g_user_email = ((login)loginForm).s_email;
        string g_user_id;
        string connectionString = ((login)loginForm).connectionString;
        bool closed_by_logout=false;
        public driver()
        {
            InitializeComponent();
            // get userID from email
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string user_id_query = "select USERID from [USER] where EMAIL = '" + g_user_email + "'";
                SqlCommand validateCmd = new SqlCommand(user_id_query, conn);
                g_user_id = Convert.ToString(validateCmd.ExecuteScalar());
            }
            conn.Close();
        }
   
        private void driver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closed_by_logout == false)
            {
                Application.Exit();
            }
            closed_by_logout = false;
        }

        public void refreshInbox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                //get table of all e-mails sent to this user THAT ARE NOT ARCHIVED
                string get_emails_to_account = "select * from EMAIL where EMAIL.RECEIVERID = " + g_user_id + " AND EMAIL.ARCHIVED = 0";

                //gets the sender's name and display the table properly
                string show_emails_with_sender = "select Q.BODY, Q.SENDERID, Q.EMAILID , [USER].FIRSTNAME as [Sent by], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + get_emails_to_account + ") as Q";
                string show_condition = " on [USER].USERID = Q.SENDERID order by [DATE] DESC";

                SqlDataAdapter sqlAdpt = new SqlDataAdapter(show_emails_with_sender + show_condition, conn);

                //inbox_data_table has all the rows from executing show_emails_with_sender + show_condition
                DataTable inbox_data_table = new DataTable();
                sqlAdpt.Fill(inbox_data_table);
                inbox_data_view.DataSource = inbox_data_table;
                inbox_data_view.Columns["EMAILID"].Visible = false;
                inbox_data_view.Columns["SENDERID"].Visible = false;
                inbox_data_view.Columns["BODY"].Visible = false;
                logged_in_as.Text = "logged in as <" + g_user_email + ">";
                if (inbox_data_view.CurrentRow != null)
                    inbox_data_view.CurrentRow.Selected = true;

                //updates the archived tab

                //all e-mails sent to this user THAT ARE ARCHIVED
                get_emails_to_account = "select * from EMAIL where EMAIL.RECEIVERID = " + g_user_id + " AND EMAIL.ARCHIVED = 1";
                show_emails_with_sender = "select Q.BODY, Q.SENDERID, Q.EMAILID , [USER].FIRSTNAME as [Sent by], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + get_emails_to_account + ") as Q";
                show_condition = " on [USER].USERID = Q.SENDERID order by [DATE] DESC";
                //gets the sender's name and displays the table properly
                SqlDataAdapter ArchSqlAdpt = new SqlDataAdapter(show_emails_with_sender + show_condition, conn);
                DataTable archive_data_table = new DataTable();
                ArchSqlAdpt.Fill(archive_data_table);
                archive_data_view.DataSource = archive_data_table;
                archive_data_view.Columns["EMAILID"].Visible = false;
                archive_data_view.Columns["SENDERID"].Visible = false;
                archive_data_view.Columns["BODY"].Visible = false;
                if (archive_data_view.CurrentRow != null)
                    archive_data_view.CurrentRow.Selected = true;
                //updates the mailinglist tab

                string show_mailinglists = "select NAMEMAILINGLIST as NAME , LISTID from MAILINGLIST where USERID =" + g_user_id;
                SqlDataAdapter MailinglistSqlAdpt = new SqlDataAdapter(show_mailinglists, conn);
                DataTable mailinglist_data_table = new DataTable();
                MailinglistSqlAdpt.Fill(mailinglist_data_table);
                mailinglist_data_view.DataSource = mailinglist_data_table;
                mailinglist_data_view.Columns["LISTID"].Visible = false;
                if (mailinglist_data_view.CurrentRow != null)
                    mailinglist_data_view.CurrentRow.Selected = true;

                // show the names of the folder 
                string show_folders = "SELECT [FOLDERID], [NAMEFOLDER] AS [Folder name] FROM [FOLDER] WHERE USERID = " + g_user_id;
                SqlDataAdapter foldSqlAdpt = new SqlDataAdapter(show_folders, conn);
                DataTable folder_data_table = new DataTable();
                foldSqlAdpt.Fill(folder_data_table);
                folder_data_view.DataSource = folder_data_table;
                folder_data_view.Columns["FOLDERID"].Visible = false;
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
            this.Text = this.Text + " | " + g_user_email;
            //loads data into inbox_grid_view
            refreshInbox();
            
           
            //TODO: SQL querIES to load all the data needed for all tabs
            //[DONE] TODO: Load messages and their senders into the inbox_data_view and sort them from most recent to oldest
            //TODO: Load folders in their respective way in the Folders tab
            //TODO: Load mailing list in its respective way in the Mailing List tab
            //[DONE] TODO: Load archived messages into archived inbox
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (inbox_data_view.CurrentRow == null)
            {
                status_label.Text = "select Email to delete.";
            }
            else
            {
                if (inbox_data_view.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < inbox_data_view.SelectedRows.Count; i++)
                    {
                        string selected_email = inbox_data_view.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                        string delete_selected_query = "delete from EMAIL where EMAILID =" + selected_email;
                        SqlCommand comm = new SqlCommand(delete_selected_query, conn);
                        comm.ExecuteNonQuery();
                    }
                    status_label.Text = "delete successful.";
                    refreshInbox();
                    if (inbox_data_view.CurrentRow != null)
                        inbox_data_view.CurrentRow.Selected = true;

                }
                /*string selected_email = inbox_data_view.CurrentRow.Cells["EMAILID"].Value.ToString();
                string delete_selected_query = "delete from EMAIL where EMAILID =" + selected_email;
                SqlCommand validateCmd = new SqlCommand(delete_selected_query, conn);
                validateCmd.ExecuteNonQuery();
                status_label.Text = "delete successful.";
                refreshInbox();*/
            }
            conn.Close();
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

        private void view_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inbox_data_view.CurrentRow == null)
            {
                status_label.Text = "select Email to view.";
            }
            else
            {
                string selected_email = inbox_data_view.CurrentRow.Cells["EMAILID"].Value.ToString();
                view_email View = new view_email(selected_email);
                View.ShowDialog();
            }
        }

        private void inbox_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selects the entire row instead of individual cells
            if(inbox_data_view.CurrentRow!=null)
                inbox_data_view.CurrentRow.Selected = true;
        }



        private void delete_archived_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (archive_data_view.CurrentRow == null)
            {
                status_label.Text = "select Email to delete.";
            }
            else
            {
                if (archive_data_view.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < archive_data_view.SelectedRows.Count; i++)
                    {
                        string selected_email = archive_data_view.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                        string delete_selected_query = "delete from EMAIL where EMAILID =" + selected_email;
                        SqlCommand comm = new SqlCommand(delete_selected_query, conn);
                        comm.ExecuteNonQuery();
                    }
                    status_label.Text = "delete successful.";
                    refreshInbox();
                    if (inbox_data_view.CurrentRow != null)
                        inbox_data_view.CurrentRow.Selected = true;

                }
                refreshInbox();
            }
            conn.Close();
        }

        private void view_archived_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archive_data_view.CurrentRow == null)
            {
                status_label.Text = "select Email to view.";
            }
            else
            {
                string selected_email = archive_data_view.CurrentRow.Cells["EMAILID"].Value.ToString();
                view_email View = new view_email(selected_email);
                View.ShowDialog();
            }
        }

        private void archive_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (archive_data_view.CurrentRow != null)
                archive_data_view.CurrentRow.Selected = true; 
        }

        private void archive_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inbox_data_view.SelectedRows == null) return;
            
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (inbox_data_view.SelectedRows.Count > 0)
            {
                for (int i = 0; i < inbox_data_view.SelectedRows.Count; i++)
                {
                    string selected_email = inbox_data_view.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                    string update_query_selected = "UPDATE [EMAIL] SET ARCHIVED = 1 WHERE EMAILID = " + selected_email;
                    SqlCommand validateCmd = new SqlCommand(update_query_selected, conn);
                    validateCmd.ExecuteNonQuery();
                    refreshInbox();
                }
            }
            conn.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archive_data_view.SelectedRows == null) return;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (archive_data_view.SelectedRows.Count > 0)
            {
                for (int i = 0; i < archive_data_view.SelectedRows.Count; i++)
                {
                    string selected_email = archive_data_view.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                    string update_query_selected = "UPDATE [EMAIL] SET ARCHIVED = 0 WHERE EMAILID = " + selected_email;
                    SqlCommand validateCmd = new SqlCommand(update_query_selected, conn);
                    validateCmd.ExecuteNonQuery();
                    refreshInbox();
                }
            }
            conn.Close();
        }

        private void reply_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inbox_data_view.SelectedRows.Count != 1) return;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sender_id = inbox_data_view.SelectedRows[0].Cells["SENDERID"].Value.ToString();
            string sender_email_query = "SELECT [EMAIL] FROM [USER] WHERE USERID = " + sender_id;

            SqlCommand validateCmd = new SqlCommand(sender_email_query, conn);
            string sender_email = validateCmd.ExecuteScalar().ToString();

            conn.Close();

            send_new sendForm = new send_new(sender_email);
            sendForm.ShowDialog();
        }

        private void forward_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inbox_data_view.SelectedRows.Count != 1) return;
            string sender_body = inbox_data_view.SelectedRows[0].Cells["BODY"].Value.ToString();
            send_new sendForm = new send_new("", sender_body);
            sendForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archive_data_view.SelectedRows.Count != 1) return;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sender_id = archive_data_view.SelectedRows[0].Cells["SENDERID"].Value.ToString();
            string sender_email_query = "SELECT [EMAIL] FROM [USER] WHERE USERID = " + sender_id;

            SqlCommand validateCmd = new SqlCommand(sender_email_query, conn);
            string sender_email = validateCmd.ExecuteScalar().ToString();

            conn.Close();

            send_new sendForm = new send_new(sender_email);
            sendForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archive_data_view.SelectedRows.Count != 1) return;
            string sender_body = archive_data_view.SelectedRows[0].Cells["BODY"].Value.ToString();
            send_new sendForm = new send_new("", sender_body);
            sendForm.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (mailinglist_data_view.CurrentRow == null)
            {
                status_label.Text = "select Mailing List to delete.";
            }
            else
            {
                if (mailinglist_data_view.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < mailinglist_data_view.SelectedRows.Count; i++)
                    {
                        string selected_email = mailinglist_data_view.SelectedRows[i].Cells["LISTID"].Value.ToString();
                        string delete_all_users = "delete from MAILINGLISTUSERS where LISTID = " + selected_email;
                        string delete_selected_query = "delete from MAILINGLIST where LISTID =" + selected_email;
                        SqlCommand comm = new SqlCommand(delete_all_users, conn);
                        comm.ExecuteNonQuery();
                        comm = new SqlCommand(delete_selected_query, conn);
                        comm.ExecuteNonQuery();
                    }
                    status_label.Text = "delete successful.";
                    refreshInbox();
                    if (inbox_data_view.CurrentRow != null)
                        inbox_data_view.CurrentRow.Selected = true;

                }
            }
            conn.Close();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mailinglist_create create = new mailinglist_create(g_user_id);
            create.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mailinglist_data_view.CurrentRow == null)
            {
                status_label.Text = "select Mailing List to edit.";
            }
            else
            {
                string selected_mailinglist = mailinglist_data_view.CurrentRow.Cells["LISTID"].Value.ToString();
                mailinglist_edit edit = new mailinglist_edit(g_user_id, selected_mailinglist);
                edit.ShowDialog();
            }
        }

        private void mailinglist_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mailinglist_data_view.CurrentRow != null)
                mailinglist_data_view.CurrentRow.Selected = true;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            closed_by_logout = true;
            ((login)loginForm).Show();
            ((login)loginForm).l_email.Text = "";
            ((login)loginForm).set_pwd_to_null();
            this.Close();
        }

        private void folder_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            folder_data_view.CurrentRow.Selected = true;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            add_folder add_folder_form = new add_folder(g_user_id);
            add_folder_form.ShowDialog();
            refreshInbox();
        }

        private void linkLabel8_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folder_data_view.SelectedRows == null) return;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            for (int i = 0; i < folder_data_view.SelectedRows.Count; i++)
            {
                string folder_id = folder_data_view.SelectedRows[i].Cells["FOLDERID"].Value.ToString();
                string delete_folder_query = "DELETE FROM [FOLDER] WHERE [FOLDERID] = " + folder_id;
                SqlCommand ValidateCmd = new SqlCommand(delete_folder_query, conn);
                ValidateCmd.ExecuteNonQuery();
            }
            conn.Close();
            refreshInbox();
        }

        private void linkLabel8_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folder_data_view.SelectedRows.Count != 1) return;
            string folder_id = folder_data_view.SelectedRows[0].Cells["FOLDERID"].Value.ToString();
            folder_email folder_email_form = new folder_email(folder_id);
            folder_email_form.ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inbox_data_view.SelectedRows.Count != 1) return;
            string email_id = inbox_data_view.SelectedRows[0].Cells["EMAILID"].Value.ToString();
            choose_folder folder_form = new choose_folder(email_id);
            folder_form.ShowDialog();
        }

        private void linkLabel9_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archive_data_view.SelectedRows.Count != 1) return;
            string email_id = archive_data_view.SelectedRows[0].Cells["EMAILID"].Value.ToString();
            choose_folder folder_form = new choose_folder(email_id);
            folder_form.ShowDialog();
        }
    }
}
