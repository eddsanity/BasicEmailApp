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
    public partial class send_new : Form
    {
        //gets the e-mail used after successfully logging in and saves it in the driver for future use.
        static Form loginForm = Application.OpenForms["login"];
        string g_user_email = ((login)loginForm).s_email;
        public send_new()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Validate the receiver's e-mail and check for the message body not to be empty
            //TODO: Send e-mail (insert query) using the sender's e-mail, receiver's, date, message body, attachment.
        }
    }
}
