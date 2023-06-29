namespace BowlingMachineApp
{
    partial class InfoBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMessage = new Label();
            buttonOK = new Button();
            SuspendLayout();
            // labelMessage
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(0, 30);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(75, 15);
            labelMessage.TabIndex = 0;
            labelMessage.TextAlign = ContentAlignment.TopCenter;
            // buttonOK
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOK.Location = new Point(0, 70);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            buttonOK.Dock = DockStyle.Bottom;
            // CustomMessageBox
            ClientSize = new Size(500, 150);
            Controls.Add(buttonOK);
            Controls.Add(labelMessage);
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScroll = true;
            ResumeLayout(false);
        }

        #endregion

        private Label labelMessage;
        private Button buttonOK;
    }
}
