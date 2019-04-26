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
        public login()
        {
            InitializeComponent();
        }

        private void l_regButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //hides the login form, shows the register form.
            this.Hide();
            register r = new register();
            r.ShowDialog();
        }
    }
}
