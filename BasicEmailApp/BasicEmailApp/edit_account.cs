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
    public partial class EditAccount : Form
    {
        //gets the e-mail used after successfully logging in and saves it in the driver for future use.
        static Form loginForm = Application.OpenForms["login"];
        static Form driverForm = Application.OpenForms["driver"];
        string g_userEmail = ((Login)loginForm).s_email;
        string g_userId;
        string connectionString = ((Login)loginForm).connectionString;
        public EditAccount()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string userIdQuery = "select USERID from [USER] where EMAIL = '" + g_userEmail + "'";
                SqlCommand command = new SqlCommand(userIdQuery, conn);
                g_userId = Convert.ToString(command.ExecuteScalar());

            }
            conn.Close();
        }

        private void edit_account_Load(object sender, EventArgs e)
        {
            basicEmail.Text = g_userEmail;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string loadQuery = "select FIRSTNAME from [USER] where (USERID = " + g_userId + ")";
                SqlCommand loadCmd = new SqlCommand(loadQuery, conn);
                basicFirstName.Text = loadCmd.ExecuteScalar().ToString();
                loadQuery = "select LASTNAME from [USER] where (USERID = " + g_userId + ")";
                loadCmd = new SqlCommand(loadQuery, conn);
                basicLastName.Text = loadCmd.ExecuteScalar().ToString();
            }

        }

        private void update_basic_info_Click(object sender, EventArgs e)
        {
            basicPwd.Text = basicPwd.Text.Replace("'", "''");
            basicFirstName.Text = basicFirstName.Text.Replace("'", "''");
            basicLastName.Text = basicLastName.Text.Replace("'", "''");
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            bool invalidChar = false;
            if (conn.State == ConnectionState.Open)
            {
                string checkAccount = "select count(EMAIL) from [USER] where (USERID = " + g_userId + ") AND PASSWORD = '" + basicPwd.Text + "'";
                SqlCommand command = new SqlCommand(checkAccount, conn);
                int accountChecker = Convert.ToInt16(command.ExecuteScalar());
                int d = 0;
                foreach (char c in basicEmail.Text)
                {
                    if (c == '@' || c == '.') d++;
                    if (c < 'a' && c > 'z' && c != '_' && c != '@' && c != '.') invalidChar = true;
                }
                if (accountChecker == 1 && d >= 2 && !invalidChar)
                {
                    string updateQuery = "update [USER] set FIRSTNAME = '" + basicFirstName.Text + "', LASTNAME = '" + basicLastName.Text + "', EMAIL = '" + basicEmail.Text + "' ";
                    string condition = "where (USERID = " + g_userId + ") AND PASSWORD = '" + basicPwd.Text + "';";
                    SqlCommand updateCmd = new SqlCommand(updateQuery + condition, conn);
                    updateCmd.ExecuteNonQuery();
                    g_userEmail = basicEmail.Text;
                    basicPwd.Text = basicPwd.Text.Replace("''", "'");
                    basicFirstName.Text = basicFirstName.Text.Replace("''", "'");
                    basicLastName.Text = basicLastName.Text.Replace("''", "'");
                    lb.Text = "Changes saved!";
                    ((Login)loginForm).s_email = g_userEmail;
                    ((Driver)driverForm).g_userEmail = g_userEmail;
                    ((Driver)driverForm).refresh_inbox();
                }
                else
                {
                    if (d < 2 || invalidChar)
                    {
                        basicPwd.Text = basicPwd.Text.Replace("''", "'");
                        basicFirstName.Text = basicFirstName.Text.Replace("''", "'");
                        basicLastName.Text = basicLastName.Text.Replace("''", "'");
                        basicEmail.Text = basicEmail.Text.Replace("''", "'");
                        MessageBox.Show("Invalid Email", "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (accountChecker != 1)
                    {
                        basicPwd.Text = basicPwd.Text.Replace("''", "'");
                        basicFirstName.Text = basicFirstName.Text.Replace("''", "'");
                        basicLastName.Text = basicLastName.Text.Replace("''", "'");
                        basicEmail.Text = basicEmail.Text.Replace("''", "'");
                        lb.Text = "";
                        MessageBox.Show("Wrong password", "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (passwordPwd.Text == passwordPwd2.Text)
            {
                if (conn.State == ConnectionState.Open)
                {
                    string checkAccount = "select count(EMAIL) from [USER] where (USERID = " + g_userId + ") AND PASSWORD = '" + password_oPwd.Text + "'";
                    SqlCommand command = new SqlCommand(checkAccount, conn);
                    int accountChecker = Convert.ToInt16(command.ExecuteScalar());
                    if (accountChecker == 1)
                    {
                        string updateQuery = "update [USER] set PASSWORD = '" + passwordPwd.Text + "' ";
                        string condition = "where (USERID = " + g_userId + ") AND PASSWORD = '" + password_oPwd.Text + "';";
                        SqlCommand updateCmd = new SqlCommand(updateQuery + condition, conn);
                        updateCmd.ExecuteNonQuery();
                        lb2.Text = "Changes saved!";
                    }
                    else
                    {
                        lb.Text = "";
                        MessageBox.Show("Wrong password", "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
                MessageBox.Show("Passwords don't match", "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
        }

        private void password_nPwd2_Leave(object sender, EventArgs e)
        {
            if (passwordPwd.Text != passwordPwd2.Text)
                lb1.Text = "Passwords don't match!";
            else lb1.Text = "";
        }
    }
}
