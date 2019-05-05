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
    public partial class UserReport : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        public string g_userEmail = ((Login)loginForm).s_email;
        string g_userId;
        string connectionString = ((Login)loginForm).connectionString;
        public UserReport()
        {
            InitializeComponent();
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

        private void user_report_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand comm;
                string get;

                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = " + g_userId + " and RECEIVERID  = u.USERID and u.EMAIL  like '%@gmail.com%' ";
                comm = new SqlCommand(get, conn);
                label9.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = " + g_userId + " and RECEIVERID = u.USERID and u.EMAIL like '%@hotmail.com%' ";
                comm = new SqlCommand(get, conn);
                label23.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = " + g_userId + "and RECEIVERID  = u.USERID and u.EMAIL  like '%@yahoo.com%' ";
                comm = new SqlCommand(get, conn);
                label28.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = " + g_userId + " and RECEIVERID  = u.USERID and u.EMAIL  like '%@live.com%' ";
                comm = new SqlCommand(get, conn);
                label33.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = " + g_userId + " and RECEIVERID  = u.USERID and u.EMAIL  like '%@outlook.com%' ";
                comm = new SqlCommand(get, conn);
                label38.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = " + g_userId + " and SENDERID  = u.USERID and u.EMAIL like '%@gmail.com%' ";
                comm = new SqlCommand(get, conn);
                label10.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = " + g_userId + " and SENDERID  = u.USERID and u.EMAIL like '%@hotmail.com%' ";
                comm = new SqlCommand(get, conn);
                label22.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = " + g_userId + " and SENDERID  = u.USERID and u.EMAIL like '%@yahoo.com%' ";
                comm = new SqlCommand(get, conn);
                label27.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = " + g_userId + " and SENDERID  = u.USERID and u.EMAIL like '%@live.com%' ";
                comm = new SqlCommand(get, conn);
                label32.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = " + g_userId + " and SENDERID  = u.USERID and u.EMAIL like '%@outlook.com%' ";
                comm = new SqlCommand(get, conn);
                label37.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID =" + g_userId + "and RECEIVERID = u.[USERID] and u.EMAIL like '%@gmail.com%'";
                comm = new SqlCommand(get, conn);
                label18.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID =" + g_userId + "and RECEIVERID = u.[USERID] and u.EMAIL like '%@hotmail.com%'";
                comm = new SqlCommand(get, conn);
                label19.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID =" + g_userId + "and RECEIVERID = u.[USERID] and u.EMAIL like '%@yahoo.com%'";
                comm = new SqlCommand(get, conn);
                label24.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID =" + g_userId + "and RECEIVERID = u.[USERID] and u.EMAIL like '%@live.com%'";
                comm = new SqlCommand(get, conn);
                label29.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID =" + g_userId + "and RECEIVERID = u.[USERID] and u.EMAIL like '%@outlook.com%'";
                comm = new SqlCommand(get, conn);
                label34.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and RECEIVERID =" + g_userId + "and SENDERID = u.[USERID] and u.EMAIL like '%@gmail.com%'";
                comm = new SqlCommand(get, conn);
                label18.Text += " / " + Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and RECEIVERID =" + g_userId + "and SENDERID = u.[USERID] and u.EMAIL like '%@hotmail.com%'";
                comm = new SqlCommand(get, conn);
                label19.Text += " / " + Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and RECEIVERID =" + g_userId + "and SENDERID = u.[USERID] and u.EMAIL like '%@yahoo.com%'";
                comm = new SqlCommand(get, conn);
                label24.Text += " / " + Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and RECEIVERID =" + g_userId + "and SENDERID = u.[USERID] and u.EMAIL like '%@live.com%'";
                comm = new SqlCommand(get, conn);
                label29.Text += " / " + Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and RECEIVERID =" + g_userId + "and SENDERID = u.[USERID] and u.EMAIL like '%@outlook.com%'";
                comm = new SqlCommand(get, conn);
                label34.Text += " / " + Convert.ToString(comm.ExecuteScalar());

                get = "select count(EMAILID) from EMAIL e where SENDERID = " + g_userId;
                comm = new SqlCommand(get, conn);
                label40.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(EMAILID) from EMAIL e where RECEIVERID = " + g_userId;
                comm = new SqlCommand(get, conn);
                label42.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(LISTID) from MAILINGLIST where USERID =" + g_userId;
                comm = new SqlCommand(get, conn);
                label44.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(FOLDERID) from FOLDER where USERID =" + g_userId;
                comm = new SqlCommand(get, conn);
                label46.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e where a.EMAILID = e.EMAILID and (e.SENDERID = " + g_userId + " or e.RECEIVERID = " + g_userId + ")";
                comm = new SqlCommand(get, conn);
                label48.Text = Convert.ToString(comm.ExecuteScalar());

            }
            conn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
