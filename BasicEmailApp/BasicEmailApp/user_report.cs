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
    public partial class user_report : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        public string g_user_email = ((login)loginForm).s_email;
        string g_user_id;
        string connectionString = ((login)loginForm).connectionString;
        public user_report()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                g_user_email = g_user_email.Replace("'", "''");
                string user_id_query = "select USERID from [USER] where EMAIL = '" + g_user_email + "'";
                SqlCommand validateCmd = new SqlCommand(user_id_query, conn);
                g_user_id = Convert.ToString(validateCmd.ExecuteScalar());
            }
            conn.Close();
        }

        private void user_report_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int totalu, temp2;
                double avg;
                string temp;
                string get_avg_users = "select count(USERID) as num from [USER]";
                string get_temail = "select count(EMAILID) from EMAIL where SENDERID = '" + g_user_id + "'";
                string get_temailr = "select count(EMAILID) from EMAIL where RECEIVERID = '" + g_user_id + "'";
                string get_tmailinglist = "select count(LISTID) from MAILINGLIST where USERID = '" + g_user_id + "'"; ;
                string get_tfolder = "select count(FOLDERID) from FOLDER where USERID = '" + g_user_id + "'";
                string get_tattachment = "select count(ATTACHMENTID) from ATTACHMENT a, EMAIL e, [USER] u where e.SENDERID=u.USERID and e.EMAILID=a.EMAILID";
                SqlCommand comm = new SqlCommand(get_avg_users, conn);
                temp = Convert.ToString(comm.ExecuteScalar());
                totalu = Convert.ToInt32(temp);
                comm = new SqlCommand(get_temail, conn);
                temail.Text = Convert.ToString(comm.ExecuteScalar());
                temp2 = Convert.ToInt32(temail.Text);
                avg = (double)temp2 / (double)totalu;
                aemail.Text = avg.ToString();

                comm = new SqlCommand(get_tmailinglist, conn);
                tmailinglist.Text = Convert.ToString(comm.ExecuteScalar());
                temp2 = Convert.ToInt32(tmailinglist.Text);
                avg = (double)temp2 / (double)totalu;
                amailinglist.Text = avg.ToString();

                comm = new SqlCommand(get_tfolder, conn);
                tfolder.Text = Convert.ToString(comm.ExecuteScalar());
                temp2 = Convert.ToInt32(tfolder.Text);
                avg = (double)temp2 / (double)totalu;
                afolder.Text = avg.ToString();

                comm = new SqlCommand(get_tattachment, conn);
                tattachment.Text = Convert.ToString(comm.ExecuteScalar());
                temp2 = Convert.ToInt32(tattachment.Text);
                avg = (double)temp2 / (double)totalu;
                aattachment.Text = avg.ToString();

                comm = new SqlCommand(get_temailr, conn);
                temailr.Text = Convert.ToString(comm.ExecuteScalar());
                temp2 = Convert.ToInt32(temailr.Text);
                avg = (double)temp2 / (double)totalu;
                aemailr.Text = avg.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
