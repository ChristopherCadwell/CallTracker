﻿namespace CallTracker
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
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(0, 30);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(0, 15);
            labelMessage.TabIndex = 0;
            labelMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonOK
            // 
            buttonOK.Dock = DockStyle.Bottom;
            buttonOK.Location = new Point(0, 101);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(173, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // InfoBox
            // 
            AutoScroll = true;
            ClientSize = new Size(173, 124);
            Controls.Add(buttonOK);
            Controls.Add(labelMessage);
            Name = "InfoBox";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
        private Button buttonOK;
    }
}
