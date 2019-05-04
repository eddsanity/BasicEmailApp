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
    public partial class view_email : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((login)loginForm).connectionString;
        string Body;
        string Subject;
        string SentBy;
        string SenderEmail;
        string Date;
        
        public view_email(string id)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                //get e-mail's subject
                string query = "select [SUBJECT] from EMAIL where EMAILID =" + id;
                SqlCommand comm = new SqlCommand(query, conn);
                Subject = Convert.ToString(comm.ExecuteScalar());

                //get e-mail's body
                query = "select [BODY] from EMAIL where EMAILID =" + id;
                comm = new SqlCommand(query, conn);
                Body = Convert.ToString(comm.ExecuteScalar());

                //get e-mail's date
                query = "select [DATE] from [EMAIL] where EMAILID = " + id;
                comm = new SqlCommand(query, conn);
                Date = Convert.ToString(comm.ExecuteScalar());

                //get sender's e-mail
                query = "select EMAIL from [USER] where USERID = (select SENDERID from EMAIL where EMAILID ='" + id + "')";
                comm = new SqlCommand(query, conn);
                SenderEmail = Convert.ToString(comm.ExecuteScalar());

                //get sender's firstname
                query = "select FIRSTNAME from [USER] where USERID = (select SENDERID from EMAIL where EMAILID ='" + id + "')";
                comm = new SqlCommand(query, conn);
                SentBy = Convert.ToString(comm.ExecuteScalar());

                // get attachments
                query = "select TYPE as Type, URL from ATTACHMENT where EMAILID = " + id;
                SqlDataAdapter sqlAdpt = new SqlDataAdapter(query, conn);
                DataTable attachments_data_table = new DataTable();
                sqlAdpt.Fill(attachments_data_table);
                attachments_data_view.DataSource = attachments_data_table;

                view_body.Text = Body;
                view_subject.Text = Subject;
                view_from.Text = SentBy + " <" + SenderEmail + ">";
                view_date.Text = Date;

                this.Text = this.Text + Subject + " from " + SentBy;
            }
            
        }

        private void download_attachment_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WebClient client = new WebClient();
            string user_path = System.Environment.GetEnvironmentVariable("USERPROFILE");
            foreach (DataGridViewRow attachment_row in attachments_data_view.SelectedRows)
            {
                string url = attachment_row.Cells["URL"].Value.ToString();
                string filename = url.Split('/').Last();
                try
                {
                    client.DownloadFile(url, user_path + "\\Downloads\\" + filename);
                } catch(System.Net.WebException)
                {
                    MessageBox.Show("Invalid URL " + url, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
