using System;
using System.Windows.Forms;

namespace BowlingMachineApp
{
    public partial class ErrorBox : Form
    {
        public ErrorBox(string title, string message)
        {
            InitializeComponent();
            this.Text = title;
            this.labelMessage.Text = message;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
