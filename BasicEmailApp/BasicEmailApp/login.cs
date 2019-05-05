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
    public partial class Login : Form
    {
        public string s_email = "";
        string serverName = "DESKTOP-QF9IM65";
        public string connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = "Data Source=" + serverName + ";Initial Catalog=emailApp;Integrated Security=True";
        }

        private void l_regButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //shows the register form.
            Register registerForm = new Register();
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
                string checkAccount = "select count(EMAIL) from [USER] where (EMAIL = '" + l_email.Text + "') AND PASSWORD = '" + l_pwd.Text + "'";
                SqlCommand command = new SqlCommand(checkAccount, conn);
                int accountChecker = Convert.ToInt16(command.ExecuteScalar());
                if (accountChecker == 1)
                {
                    l_email.Text = l_email.Text.Replace("''", "'");
                    l_pwd.Text = l_pwd.Text.Replace("''", "'");
                    s_email = l_email.Text;
                    this.Hide();
                    Driver driverForm = new Driver();
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
            SystemReport systemReport = new SystemReport();
            systemReport.ShowDialog();
        }
    }
}
