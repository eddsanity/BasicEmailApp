using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicEmailApp
{
    public partial class driver : Form
    {
        //gets the e-mail used after successfully logging in and saves it in the driver for future use.
        static Form loginForm = Application.OpenForms["login"];
        string g_user_email = ((login)loginForm).s_email;
        public driver()
        {
            InitializeComponent();
        }

        private void driver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Same SQL query in the form load function to re-load the table containing e-mails and their senders in inbox_data_view
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void driver_Load(object sender, EventArgs e)
        {
            logged_in_as.Text = "logged in as <" + g_user_email + ">";
            //TODO: SQL querIES to load all the data needed for all tabs
            //TODO: Load messages and their senders into the inbox_data_view and sort them from most recent to oldest
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
                string selected_sender = inbox_data_view.CurrentRow.Cells["SenderColumn"].Value.ToString();
                string selected_email = inbox_data_view.CurrentRow.Cells["emailColumn"].Value.ToString();
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
    }
}
