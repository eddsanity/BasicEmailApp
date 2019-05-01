using System;
using System.Collections.Generic;
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
    public partial class view_email : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((login)loginForm).connectionString;
        string Body;
        string Subject;
        string SentBy;
        string SenderEmail;
        string Date;

        //TODO: query to change the value of emailHasAttachments based on the existence of attachments linked to this e-mail
        bool emailHasAttachments = false;
        
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


                view_body.Text = Body;
                view_subject.Text = Subject;
                view_from.Text = SentBy + " <" + SenderEmail + ">";
                view_date.Text = Date;

                this.Text = this.Text + Subject + " from " + SentBy;

                if(!emailHasAttachments)
                {
                    download_attachments.Enabled = false;
                }
                else
                {
                    download_attachments.Enabled = true;
                    
                    //TODO: functionality to download attachments (i.e. download every URL in every attachment linked to this e-mail)
                }
            }
            
        }

        private void view_email_Load(object sender, EventArgs e)
        {

        }
    }
}
