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
        string connectionString = "Data Source=DESKTOP-A32LPMS;Initial Catalog=emailApp;Integrated Security=True";
        string Body;
        string Subject;
        string SentBy;
        string SenderEmail;
        
        public view_email(string id)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string subject_query = "select [SUBJECT] from EMAIL where EMAILID =" + id;
            SqlCommand comm = new SqlCommand(subject_query, conn);
            Subject = Convert.ToString(comm.ExecuteScalar());
            subject_query = "select [BODY] from EMAIL where EMAILID =" + id;
            comm = new SqlCommand(subject_query, conn);
            Body = Convert.ToString(comm.ExecuteScalar());
            subject_query = "select EMAIL from [USER] where USERID = (select SENDERID from EMAIL where EMAILID ='" + id +"')";
            comm = new SqlCommand(subject_query, conn);
            SenderEmail = Convert.ToString(comm.ExecuteScalar());
            subject_query = "select FIRSTNAME from [USER] where USERID = (select SENDERID from EMAIL where EMAILID ='" + id + "')";
            comm = new SqlCommand(subject_query, conn);
            SentBy = Convert.ToString(comm.ExecuteScalar());
            richTextBox1.Text = Body;
            richTextBox2.Text = Subject;
            richTextBox4.Text = SenderEmail;
            richTextBox3.Text = SentBy;
        }

        
    }
}
