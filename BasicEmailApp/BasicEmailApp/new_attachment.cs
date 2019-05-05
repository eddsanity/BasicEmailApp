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
    public partial class NewAttachment : Form
    {
        public NewAttachment()
        {
            InitializeComponent();
        }

        private void AddAttachBtn_Click(object sender, EventArgs e)
        {
            SendNew sendEmailForm = (SendNew)Application.OpenForms["send_new"];
            sendEmailForm.add_attachment(TypeTextBox.Text, URLTextBox.Text);
            this.Close();
        }
    }
}
