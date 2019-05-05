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
using System.Net;

namespace BasicEmailApp
{
    public partial class ViewEmail : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((Login)loginForm).connectionString;
        string Body;
        string Subject;
        string SentBy;
        string SenderEmail;
        string Date;
        
        public ViewEmail(string id)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                //get e-mail's subject
                string query = "select [SUBJECT] from EMAIL where EMAILID =" + id;
                SqlCommand command = new SqlCommand(query, conn);
                Subject = Convert.ToString(command.ExecuteScalar());

                //get e-mail's body
                query = "select [BODY] from EMAIL where EMAILID =" + id;
                command = new SqlCommand(query, conn);
                Body = Convert.ToString(command.ExecuteScalar());

                //get e-mail's date
                query = "select [DATE] from [EMAIL] where EMAILID = " + id;
                command = new SqlCommand(query, conn);
                Date = Convert.ToString(command.ExecuteScalar());

                //get sender's e-mail
                query = "select EMAIL from [USER] where USERID = (select SENDERID from EMAIL where EMAILID ='" + id + "')";
                command = new SqlCommand(query, conn);
                SenderEmail = Convert.ToString(command.ExecuteScalar());

                //get sender's firstname
                query = "select FIRSTNAME from [USER] where USERID = (select SENDERID from EMAIL where EMAILID ='" + id + "')";
                command = new SqlCommand(query, conn);
                SentBy = Convert.ToString(command.ExecuteScalar());

                // get attachments
                query = "select TYPE as Type, URL from ATTACHMENT where EMAILID = " + id;
                SqlDataAdapter sqlAdpt = new SqlDataAdapter(query, conn);
                DataTable attachmentDataTable = new DataTable();
                sqlAdpt.Fill(attachmentDataTable);
                attachmentDataView.DataSource = attachmentDataTable;

                viewBody.Text = Body;
                viewSubject.Text = Subject;
                viewForm.Text = SentBy + " <" + SenderEmail + ">";
                viewDate.Text = Date;

                this.Text = this.Text + Subject + " from " + SentBy;
            }
            
        }

        private void download_attachment_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WebClient client = new WebClient();
            string userPath = System.Environment.GetEnvironmentVariable("USERPROFILE");
            foreach (DataGridViewRow attachment_row in attachmentDataView.SelectedRows)
            {
                string url = attachment_row.Cells["URL"].Value.ToString();
                string fileName = url.Split('/').Last();
                try
                {
                    client.DownloadFile(url, userPath + "\\Downloads\\" + fileName);
                } catch(System.Net.WebException)
                {
                    MessageBox.Show("Invalid URL " + url, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
