using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicEmailApp
{
    public partial class edit_account : Form
    {
        //gets the e-mail used after successfully logging in and saves it in the driver for future use.
        static Form loginForm = Application.OpenForms["login"];
        string g_user_email = ((login)loginForm).s_email;
        public edit_account()
        {
            InitializeComponent();
        }

        private void edit_account_Load(object sender, EventArgs e)
        {
            basic_email.Text = g_user_email;
            //TODO: Load all other user data into their respective textBoxes (except old "current" password)
        }

        private void update_basic_info_Click(object sender, EventArgs e)
        {
            //TODO: Update user's First Name, Last Name and E-mail if the password is the current e-mails correct password
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(password_nPwd.Text == password_nPwd2.Text)
            {
                //TODO: Update user's password and replace it with password_nPwd.Text
            }
        }
    }
}
