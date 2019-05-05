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
    public partial class MailinglistCreate : Form
    {
        static Form driverForm = Application.OpenForms["driver"];
        static Form loginForm = Application.OpenForms["login"];
        string g_userId;
        string connectionString = ((Login)loginForm).connectionString;
        public MailinglistCreate(string id)
        {
            InitializeComponent();
            g_userId = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            mailinglistName.Text = mailinglistName.Text.Replace("'", "''");
            if (conn.State == ConnectionState.Open)
            {
                string addMailinglist = "insert into MAILINGLIST(USERID , NAMEMAILINGLIST) values(" + g_userId + ", '" + mailinglistName.Text + "')";
                SqlCommand comm = new SqlCommand(addMailinglist, conn);
                comm.ExecuteNonQuery();
                mailinglistName.Text = mailinglistName.Text.Replace("''", "'");
                mailinglist_msg.Text = "Successfully created!";
                ((Driver)driverForm).refresh_inbox();
            }
            conn.Close();
            this.Close();
        }
    }
}
