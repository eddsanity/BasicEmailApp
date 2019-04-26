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
    public partial class register : Form
    {
        bool emailIsTaken = true;
        bool pwdIsValid = false;
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!emailIsTaken && pwdIsValid)
            {
                //TODO: insert account into DB.

                //closes the sign up form after sign up is complete.
                this.Close();
            }
        }

        private void r_pwd2_TextChanged(object sender, EventArgs e)
        {
            if(r_pwd.Text != r_pwd2.Text)
            {
                pwdMsg.Text = "Passwords don't match";
            }
            else
            {
                pwdMsg.Text = "";
                pwdIsValid = true;
            }
        }

        private void register_Load(object sender, EventArgs e)
        {}

        private void r_email_Leave(object sender, EventArgs e)
        {
            //TO-DO: if e-mail is taken, change the emMsg content, leave emailIsTaken as it is
            //if e-mail is available, change the value of emailIsValid to true and empty emMsg.
            emailIsTaken = false;
        }
    }
}
