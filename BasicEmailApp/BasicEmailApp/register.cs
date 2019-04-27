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
    public partial class register : Form
    {
        bool emailIsTaken = true;
        bool pwdIsValid = false;
        bool usernameIsTaken = true;
        int numberOfUsers;

        string connectionString = "Data Source=EYAD;Initial Catalog=emailApp;Integrated Security=True";
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                if (!emailIsTaken && !usernameIsTaken && pwdIsValid)
                {
                    //get number of users for userID
                    string countUserQuery = "select count(USERID) from [USER]";
                    SqlCommand countCommand = new SqlCommand(countUserQuery, conn);
                    numberOfUsers = Convert.ToInt16(countCommand.ExecuteScalar());
                    countCommand.Dispose();

                    //insert into [USER]
                    string insertQuery = "insert into [USER](USERID, FIRSTNAME, LASTNAME, USERNAME, EMAIL, PASSWORD) ";
                    string insertArg = " values(" + numberOfUsers + ", '" + r_fname.Text + "', '" + r_lname.Text + "', '" + r_username.Text + "', '" + r_email.Text + "', '" + r_pwd.Text + "')";
                    string finalQuery = insertQuery + insertArg;
                    SqlCommand command = new SqlCommand(finalQuery, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Signed up successfully!", "Signed up", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //closes the sign up form after sign up is complete, returns to the sign in window.
                    this.Close();
                }
                else if (usernameIsTaken)
                    MessageBox.Show("Username is invalid, try another one.", "sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (emailIsTaken)
                    MessageBox.Show("E-mail is invalid, try another one.", "sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void r_pwd2_TextChanged(object sender, EventArgs e)
        {
            if(r_pwd.Text != r_pwd2.Text)
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
            foreach(char c in r_email.Text)
            {
                if (c == '@' || c == '.') d++;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                string validate_email_query = "select count(EMAIL) from [USER] where EMAIL = '" + r_email.Text + "'";
                SqlCommand validateCmd = new SqlCommand(validate_email_query, conn);
                int email_exists = Convert.ToInt16(validateCmd.ExecuteScalar());
                if (email_exists > 0 || r_email.Text == "" || d < 2)
                {
                    emailIsTaken = true;
                    emMsg.ForeColor = Color.Red;
                    emMsg.Text = "invalid e-mail!";
                }
                else
                {
                    emailIsTaken = false;
                    emMsg.ForeColor = Color.Green;
                    emMsg.Text = "e-mail OK!";
                }
            }
            
        }

        private void r_username_Leave(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                string validate_username_query = "select count(USERNAME) from [USER] where USERNAME = '" + r_username.Text + "'";
                SqlCommand validateCmd = new SqlCommand(validate_username_query, conn);
                int username_count = Convert.ToInt16(validateCmd.ExecuteScalar());
                if (username_count > 0 || r_username.Text == "")
                {
                    usernameIsTaken = true;
                    usrMsg.ForeColor = Color.Red;
                    usrMsg.Text = "invalid username!";
                }
                else
                {
                    usernameIsTaken = false;
                    usrMsg.ForeColor = Color.Green;
                    usrMsg.Text = "username OK!";
                }
            }
        }
    }
}
