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
    public partial class login : Form
    {
        public string s_email = "";
        public login()
        {
            InitializeComponent();
        }

        private void l_regButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //shows the register form.
            register registerForm = new register();
            registerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool emailIsValid = true; //dummy value, should be replaced by a query that checks if email is valid.
            bool pwdIsValid = true;   //dummy value, should be replaced by a query that checks if this password is the correct password for l_email.Text
            if(emailIsValid && pwdIsValid)
            {
                s_email = l_email.Text;
                this.Hide();
                driver driverForm = new BasicEmailApp.driver();
                driverForm.ShowDialog();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
