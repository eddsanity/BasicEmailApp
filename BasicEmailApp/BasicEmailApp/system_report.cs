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
    public partial class system_report : Form
    {
        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((login)loginForm).connectionString;
        public system_report()
        {
            InitializeComponent();

        }


        private void system_report_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int totalu, temp2;
                double avg;
                string temp;
                string get_avg_users = "select count(USERID) as num from [USER]";
                string get_temail = "select count(EMAILID) from EMAIL";
                string get_tmailinglist = "select count(LISTID) from MAILINGLIST";
                string get_tfolder = "select count(FOLDERID) from FOLDER";
                string get_tattachment = "select count(ATTACHMENTID) from ATTACHMENT";
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
            }
        }
    }
}
