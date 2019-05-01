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
    public partial class mailinglist_create : Form
    {
        static Form driverForm = Application.OpenForms["driver"];
        static Form loginForm = Application.OpenForms["login"];
        string g_user_id;
        string connectionString = ((login)loginForm).connectionString;
        public mailinglist_create(string id)
        {
            InitializeComponent();
            g_user_id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string add_mailing_list = "insert into MAILINGLIST(USERID , NAMEMAILINGLIST) values(" + g_user_id + ", '" + mailinglist_name.Text + "')";
            SqlCommand comm = new SqlCommand(add_mailing_list, conn);
            comm.ExecuteNonQuery();
            mailinglist_msg.Text = "Successfully created!";
            ((driver)driverForm).refreshInbox();
            conn.Close();
            this.Close();
        }
    }
}
