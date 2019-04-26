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
    public partial class driver : Form
    {
        public driver()
        {
            InitializeComponent();
        }

        private void driver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Same SQL query in the form load function to re-load the table containing e-mails and their senders in inbox_data_view
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void driver_Load(object sender, EventArgs e)
        {
            //TODO: SQL querIES to load all the data needed for all tabs
            //TODO: Load messages and their senders into the inbox_data_view and sort them from most recent to oldest
            //TODO: Load folders in their respective way in the Folders tab
            //TODO: Load mailing list in its respective way in the Mailing List tab
        }
    }
}
