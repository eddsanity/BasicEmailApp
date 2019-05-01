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
    public partial class edit_account : Form
    {
        //gets the e-mail used after successfully logging in and saves it in the driver for future use.
        static Form loginForm = Application.OpenForms["login"];
        static Form driverForm = Application.OpenForms["driver"];
        string g_user_email = ((login)loginForm).s_email;
        string g_user_id;
        string connectionString = "Data Source=DESKTOP-QF9IM65\\TESTSQL;Initial Catalog=EmailProject;Integrated Security=True";
        public edit_account()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string user_id_query = "select USERID from [USER] where EMAIL = '" + g_user_email + "'" ;
                SqlCommand validateCmd = new SqlCommand(user_id_query, conn);
                g_user_id = Convert.ToString(validateCmd.ExecuteScalar());
                
            }
            conn.Close();
        }

        private void edit_account_Load(object sender, EventArgs e)
        {
            basic_email.Text = g_user_email;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if(conn.State == ConnectionState.Open)
            {
                string load_query = "select FIRSTNAME from [USER] where (USERID = " + g_user_id +")";
                SqlCommand loadCmd = new SqlCommand(load_query, conn);
                basic_firstname.Text = loadCmd.ExecuteScalar().ToString();
                load_query = "select LASTNAME from [USER] where (USERID = " + g_user_id + ")";
                loadCmd = new SqlCommand(load_query, conn);
                basic_lastname.Text = loadCmd.ExecuteScalar().ToString();
            }
            
        }

        private void update_basic_info_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                string check_account = "select count(EMAIL) from [USER] where (USERID = " + g_user_id + ") AND PASSWORD = '" + basic_pwd.Text + "'";
                SqlCommand validateCmd = new SqlCommand(check_account, conn);
                int account_checker = Convert.ToInt16(validateCmd.ExecuteScalar());
                int d = 0;
                foreach (char c in basic_email.Text)
                {
                    if (c == '@' || c == '.') d++;
                }
                if (account_checker == 1 && d >= 2)
                {
                    string update_query = "update [USER] set FIRSTNAME = '" + basic_firstname.Text + "', LASTNAME = '" + basic_lastname.Text + "', EMAIL = '" + basic_email.Text + "' ";
                    string condition = "where (USERID = " + g_user_id + ") AND PASSWORD = '" + basic_pwd.Text + "';";
                    SqlCommand updateCmd = new SqlCommand(update_query + condition, conn);
                    updateCmd.ExecuteNonQuery();
                    g_user_email = basic_email.Text;
                    lb.Text = "Changes saved!";
                    ((login)loginForm).s_email = g_user_email;
                    ((driver)driverForm).g_user_email = g_user_email;
                    ((driver)driverForm).refreshInbox();
                }
                else
                {
                    if (d < 2)
                    {
                        MessageBox.Show("Invalid Email", "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (account_checker != 1)
                    {
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
            if (password_nPwd.Text == password_nPwd2.Text)
            {
                if (conn.State == ConnectionState.Open)
                {
                    string check_account = "select count(EMAIL) from [USER] where (USERID = " + g_user_id + ") AND PASSWORD = '" + password_oPwd.Text + "'";
                    SqlCommand validateCmd = new SqlCommand(check_account, conn);
                    int account_checker = Convert.ToInt16(validateCmd.ExecuteScalar());
                    if (account_checker == 1)
                    {
                        string update_query = "update [USER] set PASSWORD = '" + password_nPwd.Text + "' ";
                        string condition = "where (USERID = " + g_user_id + ") AND PASSWORD = '" + password_oPwd.Text + "';";
                        SqlCommand updateCmd = new SqlCommand(update_query + condition, conn);
                        updateCmd.ExecuteNonQuery();
                        lb2.Text = "Changes saved!";
                    }
                    else
                    {
                        lb.Text = "";
                        MessageBox.Show("Wrong password", "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            } else
                MessageBox.Show("Passwords don't match", "update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
        }

        private void password_nPwd2_Leave(object sender, EventArgs e)
        {
            if (password_nPwd.Text != password_nPwd2.Text)
                lb1.Text = "Passwords don't match!";
            else lb1.Text = "";
        }
    }
}
