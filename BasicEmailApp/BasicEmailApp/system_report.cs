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
    public partial class SystemReport : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((Login)loginForm).connectionString;
        public SystemReport()
        {
            InitializeComponent();

        }

        private void system_report_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand comm;
                string get;

                get = "select count([USERID]) from [USER] where EMAIL like '%@gmail.com%' ";
                comm = new SqlCommand(get, conn);
                label55.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count([USERID]) from [USER] where EMAIL like '%@hotmail.com%' ";
                comm = new SqlCommand(get, conn);
                label54.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count([USERID]) from [USER] where EMAIL like '%@yahoo.com%' ";
                comm = new SqlCommand(get, conn);
                label53.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count([USERID]) from [USER] where EMAIL like '%@live.com%' ";
                comm = new SqlCommand(get, conn);
                label52.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count([USERID]) from [USER] where EMAIL like '%@outlook.com%' ";
                comm = new SqlCommand(get, conn);
                label51.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = USERID and u.EMAIL like '%@gmail.com%' ";
                comm = new SqlCommand(get, conn);
                label9.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = USERID and u.EMAIL like '%@hotmail.com%' ";
                comm = new SqlCommand(get, conn);
                label23.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = USERID and u.EMAIL like '%@yahoo.com%' ";
                comm = new SqlCommand(get, conn);
                label28.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = USERID and u.EMAIL like '%@live.com%' ";
                comm = new SqlCommand(get, conn);
                label33.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = USERID and u.EMAIL like '%@outlook.com%' ";
                comm = new SqlCommand(get, conn);
                label38.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = USERID and u.EMAIL like '%@gmail.com%' ";
                comm = new SqlCommand(get, conn);
                label10.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = USERID and u.EMAIL like '%@hotmail.com%' ";
                comm = new SqlCommand(get, conn);
                label22.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = USERID and u.EMAIL like '%@yahoo.com%' ";
                comm = new SqlCommand(get, conn);
                label27.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = USERID and u.EMAIL like '%@live.com%' ";
                comm = new SqlCommand(get, conn);
                label32.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(EMAILID) from EMAIL e , [USER] u where RECEIVERID = USERID and u.EMAIL like '%@outlook.com%' ";
                comm = new SqlCommand(get, conn);
                label37.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(LISTID) from MAILINGLIST m , [USER] u where u.USERID = m.USERID and u.EMAIL like '%@gmail.com%'";
                comm = new SqlCommand(get, conn);
                label12.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(LISTID) from MAILINGLIST m , [USER] u where u.USERID = m.USERID and u.EMAIL like '%@hotmail.com%'";
                comm = new SqlCommand(get, conn);
                label21.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(LISTID) from MAILINGLIST m , [USER] u where u.USERID = m.USERID and u.EMAIL like '%@yahoo.com%'";
                comm = new SqlCommand(get, conn);
                label26.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(LISTID) from MAILINGLIST m , [USER] u where u.USERID = m.USERID and u.EMAIL like '%@live.com%'";
                comm = new SqlCommand(get, conn);
                label31.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(LISTID) from MAILINGLIST m , [USER] u where u.USERID = m.USERID and u.EMAIL like '%@outlook.com%'";
                comm = new SqlCommand(get, conn);
                label36.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(FOLDERID) from FOLDER f , [USER] u where u.USERID = f.USERID and u.EMAIL like '%@gmail.com%'";
                comm = new SqlCommand(get, conn);
                label17.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(FOLDERID) from FOLDER f , [USER] u where u.USERID = f.USERID and u.EMAIL like '%@hotmail.com%'";
                comm = new SqlCommand(get, conn);
                label20.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(FOLDERID) from FOLDER f , [USER] u where u.USERID = f.USERID and u.EMAIL like '%@yahoo.com%'";
                comm = new SqlCommand(get, conn);
                label25.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(FOLDERID) from FOLDER f , [USER] u where u.USERID = f.USERID and u.EMAIL like '%@live.com%'";
                comm = new SqlCommand(get, conn);
                label30.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(FOLDERID) from FOLDER f , [USER] u where u.USERID = f.USERID and u.EMAIL like '%@outlook.com%'";
                comm = new SqlCommand(get, conn);
                label35.Text = Convert.ToString(comm.ExecuteScalar());

                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID = u.USERID and u.EMAIL like '%@gmail.com%'";
                comm = new SqlCommand(get, conn);
                label18.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID = u.USERID and u.EMAIL like '%@hotmail.com%'";
                comm = new SqlCommand(get, conn);
                label19.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID = u.USERID and u.EMAIL like '%@yahoo.com%'";
                comm = new SqlCommand(get, conn);
                label24.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID = u.USERID and u.EMAIL like '%@live.com%'";
                comm = new SqlCommand(get, conn);
                label29.Text = Convert.ToString(comm.ExecuteScalar());
                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and SENDERID = u.USERID and u.EMAIL like '%@outlook.com%'";
                comm = new SqlCommand(get, conn);
                label34.Text = Convert.ToString(comm.ExecuteScalar());

                int temp , usernum;
                double avg;
                string temp2;
                get = "select count(USERID) from [USER]";
                comm = new SqlCommand(get, conn);
                temp2 = Convert.ToString(comm.ExecuteScalar());
                usernum = Convert.ToInt32(temp2);
                label50.Text = usernum.ToString();

                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = USERID";
                comm = new SqlCommand(get, conn);
                label40.Text = Convert.ToString(comm.ExecuteScalar());
                temp = Convert.ToInt32(label40.Text);
                avg = (double)temp / (double)usernum;
                avg = Math.Round(avg, 2);
                label39.Text = avg.ToString();

                get = "select count(EMAILID) from EMAIL e , [USER] u where SENDERID = USERID";
                comm = new SqlCommand(get, conn);
                label42.Text = Convert.ToString(comm.ExecuteScalar());
                temp = Convert.ToInt32(label42.Text);
                avg = (double)temp / (double)usernum;
                avg = Math.Round(avg, 2);
                label41.Text = avg.ToString();

                get = "select count(LISTID) from MAILINGLIST";
                comm = new SqlCommand(get, conn);
                label44.Text = Convert.ToString(comm.ExecuteScalar());
                temp = Convert.ToInt32(label44.Text);
                avg = (double)temp / (double)usernum;
                avg = Math.Round(avg, 2);
                label43.Text = avg.ToString();

                get = "select count(FOLDERID) from FOLDER";
                comm = new SqlCommand(get, conn);
                label46.Text = Convert.ToString(comm.ExecuteScalar());
                temp = Convert.ToInt32(label46.Text);
                avg = (double)temp / (double)usernum;
                avg = Math.Round(avg, 2);
                label45.Text = avg.ToString();

                get = "select count(ATTACHMENTID) from ATTACHMENT a , EMAIL e , [USER] u where a.EMAILID = e.EMAILID and e.SENDERID = u.USERID";
                comm = new SqlCommand(get, conn);
                label48.Text = Convert.ToString(comm.ExecuteScalar());
                temp = Convert.ToInt32(label48.Text);
                avg = (double)temp / (double)usernum;
                avg = Math.Round(avg, 2);
                label47.Text = avg.ToString();
            }
            conn.Close();
        }
    }
}
