using System;
using System.Windows.Forms;

namespace BowlingMachineApp
{
    public partial class InfoBox : Form
    {
        public InfoBox(string title, string message)
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
