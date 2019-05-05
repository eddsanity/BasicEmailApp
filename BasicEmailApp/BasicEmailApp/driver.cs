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
    public partial class Driver : Form
    {
        //gets the e-mail used after successfully logging in and saves it in the driver for future use.
        static Form loginForm = Application.OpenForms["login"];
        public string g_userEmail = ((Login)loginForm).s_email;
        string g_userId;
        string connectionString = ((Login)loginForm).connectionString;
        bool closedByLogout = false;
        public Driver()
        {
            InitializeComponent();
            // get userID from email
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                g_userEmail = g_userEmail.Replace("'", "''");
                string userIdQuery = "select USERID from [USER] where EMAIL = '" + g_userEmail + "'";
                SqlCommand command = new SqlCommand(userIdQuery, conn);
                g_userId = Convert.ToString(command.ExecuteScalar());
            }
            conn.Close();
        }

        private void driver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedByLogout == false)
            {
                Application.Exit();
            }
            closedByLogout = false;
        }

        public void refresh_inbox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                //get table of all e-mails sent to this user THAT ARE NOT ARCHIVED
                string getEmailToAccount = "select * from EMAIL where EMAIL.RECEIVERID = " + g_userId + " AND EMAIL.ARCHIVED = 0";

                //gets the sender's name and display the table properly
                string showEmailWithSender = "select Q.BODY, Q.SENDERID, Q.EMAILID , [USER].FIRSTNAME as [Sent by], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + getEmailToAccount + ") as Q";
                string showCondition = " on [USER].USERID = Q.SENDERID order by [DATE] DESC";

                SqlDataAdapter sqlAdpt = new SqlDataAdapter(showEmailWithSender + showCondition, conn);

                //inbox_data_table has all the rows from executing show_emails_with_sender + show_condition
                DataTable inboxDataTable = new DataTable();
                sqlAdpt.Fill(inboxDataTable);
                this.inboxDataView.DataSource = inboxDataTable;
                this.inboxDataView.Columns["EMAILID"].Visible = false;
                this.inboxDataView.Columns["SENDERID"].Visible = false;
                this.inboxDataView.Columns["BODY"].Visible = false;
                loggedInAs.Text = "logged in as <" + g_userEmail + ">";
                if (this.inboxDataView.CurrentRow != null)
                    this.inboxDataView.CurrentRow.Selected = true;

                //updates the archived tab

                //all e-mails sent to this user THAT ARE ARCHIVED
                getEmailToAccount = "select * from EMAIL where EMAIL.RECEIVERID = " + g_userId + " AND EMAIL.ARCHIVED = 1";
                showEmailWithSender = "select Q.BODY, Q.SENDERID, Q.EMAILID , [USER].FIRSTNAME as [Sent by], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + getEmailToAccount + ") as Q";
                showCondition = " on [USER].USERID = Q.SENDERID order by [DATE] DESC";
                //gets the sender's name and displays the table properly
                SqlDataAdapter ArchSqlAdpt = new SqlDataAdapter(showEmailWithSender + showCondition, conn);
                DataTable archiveDataTable = new DataTable();
                ArchSqlAdpt.Fill(archiveDataTable);
                archiveDataView.DataSource = archiveDataTable;
                archiveDataView.Columns["EMAILID"].Visible = false;
                archiveDataView.Columns["SENDERID"].Visible = false;
                archiveDataView.Columns["BODY"].Visible = false;
                if (archiveDataView.CurrentRow != null)
                    archiveDataView.CurrentRow.Selected = true;
                //updates the mailinglist tab

                string showMailinglist = "select NAMEMAILINGLIST as NAME , LISTID from MAILINGLIST where USERID =" + g_userId;
                SqlDataAdapter MailinglistSqlAdpt = new SqlDataAdapter(showMailinglist, conn);
                DataTable mailinglistDataTable = new DataTable();
                MailinglistSqlAdpt.Fill(mailinglistDataTable);
                mailinglistDataView.DataSource = mailinglistDataTable;
                mailinglistDataView.Columns["LISTID"].Visible = false;
                if (mailinglistDataView.CurrentRow != null)
                    mailinglistDataView.CurrentRow.Selected = true;

                // show the names of the folder 
                string showFolder = "SELECT [FOLDERID], [NAMEFOLDER] AS [Folder name] FROM [FOLDER] WHERE USERID = " + g_userId;
                SqlDataAdapter foldSqlAdpt = new SqlDataAdapter(showFolder, conn);
                DataTable folderDataTable = new DataTable();
                foldSqlAdpt.Fill(folderDataTable);
                folderDataView.DataSource = folderDataTable;
                folderDataView.Columns["FOLDERID"].Visible = false;
                if (folderDataView.CurrentRow != null)
                    folderDataView.CurrentRow.Selected = true;

                getEmailToAccount = "select * from EMAIL where EMAIL.SENDERID = " + g_userId;
                showEmailWithSender = "select Q.BODY, Q.EMAILID, [USER].FIRSTNAME as [Sent to], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + getEmailToAccount + ") as Q";
                showCondition = " on [USER].USERID = Q.RECEIVERID order by [DATE] DESC";
                SqlDataAdapter sentSqlAdpt = new SqlDataAdapter(showEmailWithSender + showCondition, conn);
                DataTable sentDataTable = new DataTable();
                sentSqlAdpt.Fill(sentDataTable);
                sentDataView.DataSource = sentDataTable;
                sentDataView.Columns["EMAILID"].Visible = false;
                sentDataView.Columns["BODY"].Visible = false;
                if (sentDataView.CurrentRow != null)
                    sentDataView.CurrentRow.Selected = true;
            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refresh_inbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void driver_Load(object sender, EventArgs e)
        {
            loggedInAs.Text = "logged in as <" + g_userEmail + ">";
            this.Text = this.Text + " | " + g_userEmail;
            //loads data into inbox_grid_view
            refresh_inbox();


            //[DONE] TODO: SQL querIES to load all the data needed for all tabs
            //[DONE] TODO: Load messages and their senders into the inbox_data_view and sort them from most recent to oldest
            //[DONE] TODO: Load folders in their respective way in the Folders tab
            //[DONE] TODO: Load mailing list in its respective way in the Mailing List tab
            //[DONE] TODO: Load archived messages into archived inbox
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (inboxDataView.CurrentRow == null)
            {
                statusLabel.Text = "select Email to delete.";
            }
            else
            {
                if (inboxDataView.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < inboxDataView.SelectedRows.Count; i++)
                    {
                        string selectedEmail = inboxDataView.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                        string deleteSelectedQuery = "delete from EMAIL where EMAILID =" + selectedEmail;
                        SqlCommand comm = new SqlCommand(deleteSelectedQuery, conn);
                        comm.ExecuteNonQuery();
                    }
                    statusLabel.Text = "delete successful.";
                    refresh_inbox();
                    if (inboxDataView.CurrentRow != null)
                        inboxDataView.CurrentRow.Selected = true;
                }
                /*string selected_email = inbox_data_view.CurrentRow.Cells["EMAILID"].Value.ToString();
                string delete_selected_query = "delete from EMAIL where EMAILID =" + selected_email;
                SqlCommand command = new SqlCommand(delete_selected_query, conn);
                command.ExecuteNonQuery();
                status_label.Text = "delete successful.";
                refreshInbox();*/
            }
            conn.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditAccount editAccForm = new EditAccount();
            editAccForm.ShowDialog();
        }

        private void send_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendNew sendForm = new SendNew();
            sendForm.ShowDialog();
        }

        private void view_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inboxDataView.CurrentRow == null)
            {
                statusLabel.Text = "select Email to view.";
            }
            else
            {
                string selectedEmail = inboxDataView.CurrentRow.Cells["EMAILID"].Value.ToString();
                ViewEmail view = new ViewEmail(selectedEmail);
                view.ShowDialog();
            }
        }

        private void inbox_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selects the entire row instead of individual cells
            if (inboxDataView.CurrentRow != null)
                inboxDataView.CurrentRow.Selected = true;
        }



        private void delete_archived_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (archiveDataView.CurrentRow == null)
            {
                statusLabel.Text = "select Email to delete.";
            }
            else
            {
                if (archiveDataView.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < archiveDataView.SelectedRows.Count; i++)
                    {
                        string selectedEmail = archiveDataView.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                        string deleteSelectedEmail = "delete from EMAIL where EMAILID =" + selectedEmail;
                        SqlCommand command = new SqlCommand(deleteSelectedEmail, conn);
                        command.ExecuteNonQuery();
                    }
                    statusLabel.Text = "delete successful.";
                    refresh_inbox();
                    if (inboxDataView.CurrentRow != null)
                        inboxDataView.CurrentRow.Selected = true;

                }
                refresh_inbox();
            }
            conn.Close();
        }

        private void view_archived_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archiveDataView.CurrentRow == null)
            {
                statusLabel.Text = "select Email to view.";
            }
            else
            {
                string selectedEmail = archiveDataView.CurrentRow.Cells["EMAILID"].Value.ToString();
                ViewEmail view = new ViewEmail(selectedEmail);
                view.ShowDialog();
            }
        }

        private void archive_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (archiveDataView.CurrentRow != null)
                archiveDataView.CurrentRow.Selected = true;
        }

        private void archive_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inboxDataView.CurrentRow == null) return;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (inboxDataView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < inboxDataView.SelectedRows.Count; i++)
                {
                    string selectedEmail = inboxDataView.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                    string updateQuerySelected = "UPDATE [EMAIL] SET ARCHIVED = 1 WHERE EMAILID = " + selectedEmail;
                    SqlCommand command = new SqlCommand(updateQuerySelected, conn);
                    command.ExecuteNonQuery();

                }
                refresh_inbox();
            }
            conn.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archiveDataView.CurrentRow == null) return;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (archiveDataView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < archiveDataView.SelectedRows.Count; i++)
                {
                    string selectedEmail = archiveDataView.SelectedRows[i].Cells["EMAILID"].Value.ToString();
                    string updateQuerySelected = "UPDATE [EMAIL] SET ARCHIVED = 0 WHERE EMAILID = " + selectedEmail;
                    SqlCommand command = new SqlCommand(updateQuerySelected, conn);
                    command.ExecuteNonQuery();
                }
                refresh_inbox();
            }
            conn.Close();
        }

        private void reply_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inboxDataView.SelectedRows.Count != 1) return;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string senderId = inboxDataView.SelectedRows[0].Cells["SENDERID"].Value.ToString();
            string SendEmailQuery = "SELECT [EMAIL] FROM [USER] WHERE USERID = " + senderId;

            SqlCommand command = new SqlCommand(SendEmailQuery, conn);
            string sendEmail = command.ExecuteScalar().ToString();

            conn.Close();

            SendNew sendForm = new SendNew(sendEmail);
            sendForm.ShowDialog();
        }

        private void forward_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inboxDataView.SelectedRows.Count != 1) return;
            string sendBody = inboxDataView.SelectedRows[0].Cells["BODY"].Value.ToString();
            SendNew sendForm = new SendNew("", sendBody);
            sendForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archiveDataView.SelectedRows.Count != 1) return;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string senderId = archiveDataView.SelectedRows[0].Cells["SENDERID"].Value.ToString();
            string senderEmailQuery = "SELECT [EMAIL] FROM [USER] WHERE USERID = " + senderId;

            SqlCommand command = new SqlCommand(senderEmailQuery, conn);
            string senderEmail = command.ExecuteScalar().ToString();

            conn.Close();

            SendNew sendForm = new SendNew(senderEmail);
            sendForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archiveDataView.SelectedRows.Count != 1) return;
            string senderBody = archiveDataView.SelectedRows[0].Cells["BODY"].Value.ToString();
            SendNew sendForm = new SendNew("", senderBody);
            sendForm.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (mailinglistDataView.CurrentRow == null)
            {
                statusLabel.Text = "select Mailing List to delete.";
            }
            else
            {
                if (mailinglistDataView.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < mailinglistDataView.SelectedRows.Count; i++)
                    {
                        string selectedEmail = mailinglistDataView.SelectedRows[i].Cells["LISTID"].Value.ToString();
                        string deleteAllUser = "delete from MAILINGLISTUSERS where LISTID = " + selectedEmail;
                        string deleteSelectedQuery = "delete from MAILINGLIST where LISTID =" + selectedEmail;
                        SqlCommand command = new SqlCommand(deleteAllUser, conn);
                        command.ExecuteNonQuery();
                        command = new SqlCommand(deleteSelectedQuery, conn);
                        command.ExecuteNonQuery();
                    }
                    statusLabel.Text = "delete successful.";
                    refresh_inbox();
                    if (inboxDataView.CurrentRow != null)
                        inboxDataView.CurrentRow.Selected = true;

                }
            }
            conn.Close();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MailinglistCreate create = new MailinglistCreate(g_userId);
            create.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mailinglistDataView.CurrentRow == null)
            {
                statusLabel.Text = "select Mailing List to edit.";
            }
            else
            {
                string selectedMailinglist = mailinglistDataView.CurrentRow.Cells["LISTID"].Value.ToString();
                MailinglistEdit edit = new MailinglistEdit(g_userId, selectedMailinglist);
                edit.ShowDialog();
            }
        }

        private void mailinglist_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (mailinglistDataView.CurrentRow != null)
                mailinglistDataView.CurrentRow.Selected = true;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            closedByLogout = true;
            ((Login)loginForm).Show();
            ((Login)loginForm).l_email.Text = "";
            ((Login)loginForm).set_pwd_to_null();
            this.Close();
        }

        private void folder_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folderDataView.CurrentRow != null)
                folderDataView.CurrentRow.Selected = true;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddFolder addFolderForm = new AddFolder(g_userId);
            addFolderForm.ShowDialog();
            refresh_inbox();
        }

        private void linkLabel8_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folderDataView.SelectedRows == null) return;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            for (int i = 0; i < folderDataView.SelectedRows.Count; i++)
            {
                string folderId = folderDataView.SelectedRows[i].Cells["FOLDERID"].Value.ToString();
                string deleteFolderQuery = "DELETE FROM [FOLDER] WHERE [FOLDERID] = " + folderId;
                SqlCommand command = new SqlCommand(deleteFolderQuery, conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
            refresh_inbox();
        }

        private void linkLabel8_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folderDataView.SelectedRows.Count != 1) return;
            string folderId = folderDataView.SelectedRows[0].Cells["FOLDERID"].Value.ToString();
            FolderEmail folderEmailForm = new FolderEmail(folderId);
            folderEmailForm.ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inboxDataView.SelectedRows.Count != 1) return;
            string emailId = inboxDataView.SelectedRows[0].Cells["EMAILID"].Value.ToString();
            ChooseEmail folderForm = new ChooseEmail(emailId);
            folderForm.ShowDialog();
        }

        private void linkLabel9_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (archiveDataView.SelectedRows.Count != 1) return;
            string emailId = archiveDataView.SelectedRows[0].Cells["EMAILID"].Value.ToString();
            ChooseEmail folderForm = new ChooseEmail(emailId);
            folderForm.ShowDialog();
        }

        private void sent_data_view_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sentDataView.SelectedRows.Count != 1) return;
            string emailId = sentDataView.SelectedRows[0].Cells["EMAILID"].Value.ToString();
            ViewEmail viewForm = new ViewEmail(emailId);
            viewForm.ShowDialog();
            refresh_inbox();
        }


        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sentDataView.SelectedRows.Count != 1) return;
            string senderBody = sentDataView.SelectedRows[0].Cells["BODY"].Value.ToString();
            SendNew sendForm = new SendNew("", senderBody);
            sendForm.ShowDialog();
        }

        private void folder_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (folderDataView.CurrentRow != null)
                folderDataView.CurrentRow.Selected = true;
        }

        private void folder_data_view_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (folderDataView.CurrentRow != null)
                folderDataView.CurrentRow.Selected = true;
        }

        private void search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (searchBar.Text != "")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                searchBar.Text = searchBar.Text.Replace("'", "''");
                //get table of all e-mails sent to this user THAT ARE NOT ARCHIVED
                string getEmailToAccount = "select * from EMAIL where EMAIL.RECEIVERID = " + g_userId + " AND EMAIL.ARCHIVED = 0";

                //gets the sender's name and display the table properly
                string showEmailsWithSender = "select Q.BODY, Q.SENDERID, Q.EMAILID , [USER].FIRSTNAME as [Sent by], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + getEmailToAccount + ") as Q";
                string showCondition = " on [USER].USERID = Q.SENDERID and ([USER].FIRSTNAME = '" + searchBar.Text + "' or [SUBJECT] = '" + searchBar.Text + "' or [USER].EMAIL = '" + searchBar.Text + "') order by [DATE] DESC";

                SqlDataAdapter sqlAdpt = new SqlDataAdapter(showEmailsWithSender + showCondition, conn);

                //inbox_data_table has all the rows from executing show_emails_with_sender + show_condition
                DataTable inboxDataTable = new DataTable();
                sqlAdpt.Fill(inboxDataTable);
                inboxDataView.DataSource = inboxDataTable;
                inboxDataView.Columns["EMAILID"].Visible = false;
                inboxDataView.Columns["SENDERID"].Visible = false;
                inboxDataView.Columns["BODY"].Visible = false;
                loggedInAs.Text = "logged in as <" + g_userEmail + ">";
                if (inboxDataView.CurrentRow != null)
                    inboxDataView.CurrentRow.Selected = true;
                searchBar.Text = searchBar.Text.Replace("''", "'");
                conn.Close();
            }
            else refresh_inbox();
        }

        private void search2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (searchBar2.Text != "")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                searchBar2.Text = searchBar2.Text.Replace("'", "''");
                string showMailinglist = "select NAMEMAILINGLIST as NAME , LISTID from MAILINGLIST where USERID =" + g_userId + "and NAMEMAILINGLIST ='" + searchBar2.Text + "'";
                SqlDataAdapter MailinglistSqlAdpt = new SqlDataAdapter(showMailinglist, conn);
                DataTable mailinglistDataTable = new DataTable();
                MailinglistSqlAdpt.Fill(mailinglistDataTable);
                mailinglistDataView.DataSource = mailinglistDataTable;
                mailinglistDataView.Columns["LISTID"].Visible = false;
                if (mailinglistDataView.CurrentRow != null)
                    mailinglistDataView.CurrentRow.Selected = true;
                searchBar2.Text = searchBar2.Text.Replace("''", "'");
                conn.Close();
            }
            else refresh_inbox();
        }

        private void search3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (searchBar3.Text != "")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                searchBar3.Text = searchBar3.Text.Replace("'", "''");
                // show the names of the folder 
                string showFolder = "SELECT [FOLDERID], [NAMEFOLDER] AS [Folder name] FROM [FOLDER] WHERE USERID = " + g_userId + "and [NAMEFOLDER] ='" + searchBar3.Text + "'";
                SqlDataAdapter foldSqlAdpt = new SqlDataAdapter(showFolder, conn);
                DataTable folderDataTable = new DataTable();
                foldSqlAdpt.Fill(folderDataTable);
                folderDataView.DataSource = folderDataTable;
                folderDataView.Columns["FOLDERID"].Visible = false;
                searchBar3.Text = searchBar3.Text.Replace("''", "'");
                conn.Close();
            }
            else refresh_inbox();
        }

        private void search4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (searchBar4.Text != "")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                searchBar4.Text = searchBar4.Text.Replace("'", "''");
                //all e-mails sent to this user THAT ARE ARCHIVED
                string getEmailToAccount = "select * from EMAIL where EMAIL.RECEIVERID = " + g_userId + " AND EMAIL.ARCHIVED = 1";
                string showEmailWithSender = "select Q.BODY, Q.SENDERID, Q.EMAILID , [USER].FIRSTNAME as [Sent by], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + getEmailToAccount + ") as Q";
                string showCondition = " on [USER].USERID = Q.SENDERID and ([USER].FIRSTNAME = '" + searchBar4.Text + "' or [SUBJECT] = '" + searchBar4.Text + "' or [USER].EMAIL = '" + searchBar4.Text + "') order by [DATE] DESC";
                //gets the sender's name and displays the table properly
                SqlDataAdapter ArchSqlAdpt = new SqlDataAdapter(showEmailWithSender + showCondition, conn);
                DataTable archiveDataTable = new DataTable();
                ArchSqlAdpt.Fill(archiveDataTable);
                archiveDataView.DataSource = archiveDataTable;
                archiveDataView.Columns["EMAILID"].Visible = false;
                archiveDataView.Columns["SENDERID"].Visible = false;
                archiveDataView.Columns["BODY"].Visible = false;
                if (archiveDataView.CurrentRow != null)
                    archiveDataView.CurrentRow.Selected = true;
                searchBar4.Text = searchBar4.Text.Replace("''", "'");
                conn.Close();
            }
            else refresh_inbox();
        }

        private void search5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (searchBar5.Text != "")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                searchBar5.Text = searchBar5.Text.Replace("'", "''");
                string getEmailToAccount = "select * from EMAIL where EMAIL.SENDERID = " + g_userId;
                string showEmailWithSender = "select Q.BODY, Q.EMAILID, [USER].FIRSTNAME as [Sent to], [SUBJECT] as [Subject], [DATE] as [Date] from [USER] inner join (" + getEmailToAccount + ") as Q";
                string showCondition = " on [USER].USERID = Q.RECEIVERID and ([USER].FIRSTNAME = '" + searchBar5.Text + "' or [SUBJECT] = '" + searchBar5.Text + "' or [USER].EMAIL = '" + searchBar5.Text + "') order by [DATE] DESC";
                SqlDataAdapter sentSqlAdpt = new SqlDataAdapter(showEmailWithSender + showCondition, conn);
                DataTable sentDataTable = new DataTable();
                sentSqlAdpt.Fill(sentDataTable);
                sentDataView.DataSource = sentDataTable;
                sentDataView.Columns["EMAILID"].Visible = false;
                sentDataView.Columns["BODY"].Visible = false;
                searchBar5.Text = searchBar5.Text.Replace("''", "'");
                conn.Close();
            }
            else refresh_inbox();
        }

        private void sent_data_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sentDataView.CurrentRow != null)
                sentDataView.CurrentRow.Selected = true;
        }

        private void sent_data_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sentDataView.CurrentRow != null)
                sentDataView.CurrentRow.Selected = true;
        }

        private void generateR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserReport userReport = new UserReport();
            userReport.ShowDialog();
        }

        private void generateR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_report us = new user_report();
            us.ShowDialog();
        }
    }
}
