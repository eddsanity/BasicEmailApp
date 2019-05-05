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
    public partial class login : Form
    {
        public string s_email = "";
        string serverName = "DESKTOP-A32LPMS";
        public string connectionString;
        public login()
        {
            InitializeComponent();
            connectionString = "Data Source=" + serverName + ";Initial Catalog=emailApp;Integrated Security=True";
        }

        private void l_regButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //shows the register form.
            register registerForm = new register();
            registerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            l_email.Text = l_email.Text.Replace("'", "''");
            l_pwd.Text = l_pwd.Text.Replace("'", "''");
            if (conn.State == ConnectionState.Open)
            {
                //check if an account with this e-mail and this password exist
                string check_account = "select count(EMAIL) from [USER] where (EMAIL = '" + l_email.Text + "') AND PASSWORD = '" + l_pwd.Text + "'";
                SqlCommand validateCmd = new SqlCommand(check_account, conn);
                int account_checker = Convert.ToInt16(validateCmd.ExecuteScalar());
                if (account_checker == 1)
                {
                    l_email.Text = l_email.Text.Replace("''", "'");
                    l_pwd.Text = l_pwd.Text.Replace("''", "'");
                    s_email = l_email.Text;
                    this.Hide();
                    driver driverForm = new driver();
                    driverForm.ShowDialog();
                }
                else
                {
                    l_email.Text = l_email.Text.Replace("''", "'");
                    l_pwd.Text = l_pwd.Text.Replace("''", "'");
                    MessageBox.Show("Login failed, check your credentials.", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }
        public void set_pwd_to_null()
        {
            l_pwd.Text = "";
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void generateR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            system_report sr = new system_report();
            sr.ShowDialog();
        }
    }
}
