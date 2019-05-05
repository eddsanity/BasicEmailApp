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
    public partial class Register : Form
    {
        bool emailIsTaken = true;
        bool pwdIsValid = false;
        bool usernameIsTaken = true;

        static Form loginForm = Application.OpenForms["login"];
        string connectionString = ((Login)loginForm).connectionString;
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            r_fname.Text = r_fname.Text.Replace("'", "''");
            r_lname.Text = r_lname.Text.Replace("'", "''");
            r_username.Text = r_username.Text.Replace("'", "''");
            r_pwd.Text = r_pwd.Text.Replace("'", "''");
            r_pwd2.Text = r_pwd2.Text.Replace("'", "''");
            if (conn.State == ConnectionState.Open)
            {
                if (!emailIsTaken && !usernameIsTaken && pwdIsValid)
                {
                    //insert into [USER]
                    string insertQuery = "insert into [USER](FIRSTNAME, LASTNAME, USERNAME, EMAIL, PASSWORD) ";
                    string insertArg = " values('" + r_fname.Text + "', '" + r_lname.Text + "', '" + r_username.Text + "', '" + r_email.Text + "', '" + r_pwd.Text + "')";
                    string finalQuery = insertQuery + insertArg;
                    SqlCommand command = new SqlCommand(finalQuery, conn);
                    command.ExecuteNonQuery();
                    r_fname.Text = r_fname.Text.Replace("''", "'");
                    r_lname.Text = r_lname.Text.Replace("''", "'");
                    r_username.Text = r_username.Text.Replace("''", "'");
                    r_pwd.Text = r_pwd.Text.Replace("''", "'");
                    r_pwd2.Text = r_pwd2.Text.Replace("''", "'");
                    MessageBox.Show("Signed up successfully!", "Signed up", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //closes the sign up form after sign up is complete, returns to the sign in window.
                    this.Close();
                }
                else if (usernameIsTaken)
                {
                    r_fname.Text = r_fname.Text.Replace("''", "'");
                    r_lname.Text = r_lname.Text.Replace("''", "'");
                    r_username.Text = r_username.Text.Replace("''", "'");
                    r_pwd.Text = r_pwd.Text.Replace("''", "'");
                    r_pwd2.Text = r_pwd2.Text.Replace("''", "'");
                    MessageBox.Show("Username is invalid, try another one.", "sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (emailIsTaken)
                {
                    r_fname.Text = r_fname.Text.Replace("''", "'");
                    r_lname.Text = r_lname.Text.Replace("''", "'");
                    r_username.Text = r_username.Text.Replace("''", "'");
                    r_pwd.Text = r_pwd.Text.Replace("''", "'");
                    r_pwd2.Text = r_pwd2.Text.Replace("''", "'");
                    MessageBox.Show("E-mail is invalid, try another one.", "sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                r_fname.Text = r_fname.Text.Replace("''", "'");
                r_lname.Text = r_lname.Text.Replace("''", "'");
                r_username.Text = r_username.Text.Replace("''", "'");
                r_pwd.Text = r_pwd.Text.Replace("''", "'");
                r_pwd2.Text = r_pwd2.Text.Replace("''", "'");
            }
            conn.Close();

        }

        private void r_pwd2_TextChanged(object sender, EventArgs e)
        {
            if (r_pwd.Text != r_pwd2.Text)
            {
                pwdMsg.Text = "Passwords don't match";
                pwdIsValid = false;
            }
            else
            {
                pwdMsg.Text = "";
                pwdIsValid = true;
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
        }

        private void r_email_Leave(object sender, EventArgs e)
        {
            //check if e-mail is formatted correctly. Increment once when it finds a '@', a 2nd time when it finds a '.'
            //basically checks for %@%.%
            int d = 0;
            bool invalidChar = false;
            foreach (char c in r_email.Text)
            {
                if (c == '@' || c == '.') d++;
                else if ((c < 'a' || c > 'z') && c != '_') invalidChar = true;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                if (!invalidChar)
                {
                    string validateEmailQuery = "select count(EMAIL) from [USER] where EMAIL = '" + r_email.Text + "'";
                    SqlCommand command = new SqlCommand(validateEmailQuery, conn);
                    int emailChecker = Convert.ToInt16(command.ExecuteScalar());
                    if (emailChecker > 0 || r_email.Text == "" || d < 2)
                    {
                        emailIsTaken = true;
                        emMsg.ForeColor = Color.Red;
                        emMsg.Text = "invalid e-mail!";
                    }
                    else
                    {
                        emailIsTaken = false;
                        emMsg.ForeColor = Color.Green;
                        r_email.Text = r_email.Text.Replace("''", "'");
                        emMsg.Text = "e-mail OK!";
                    }
                }
                else
                {
                    emailIsTaken = true;
                    emMsg.ForeColor = Color.Red;
                    emMsg.Text = "invalid e-mail!";
                }
                conn.Close();
            }
        }

        private void r_username_Leave(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            r_username.Text = r_username.Text.Replace("'", "''");
            if (conn.State == ConnectionState.Open)
            {
                string validateUsernameQuery = "select count(USERNAME) from [USER] where USERNAME = '" + r_username.Text + "'";
                SqlCommand command = new SqlCommand(validateUsernameQuery, conn);
                int usernameChecker = Convert.ToInt16(command.ExecuteScalar());
                if (usernameChecker > 0 || r_username.Text == "")
                {
                    usernameIsTaken = true;
                    usrMsg.ForeColor = Color.Red;
                    r_username.Text = r_username.Text.Replace("''", "'");
                    usrMsg.Text = "invalid username!";
                }
                else
                {
                    usernameIsTaken = false;
                    usrMsg.ForeColor = Color.Green;
                    r_username.Text = r_username.Text.Replace("''", "'");
                    usrMsg.Text = "username OK!";
                }
            }
            conn.Close();
        }
    }
}
