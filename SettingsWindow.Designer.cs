namespace BowlingMachineApp
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            laneCounter = new NumericUpDown();
            buttonSave = new Button();
            comboMechanics = new ComboBox();
            comboCalls = new ComboBox();
            buttonCallRem = new Button();
            buttonCallAdd = new Button();
            buttonMechRem = new Button();
            buttonMechAdd = new Button();
            buttonCancel = new Button();
            buttonLogLocation = new Button();
            saveFileLocator = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)laneCounter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Lanes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Calls";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Mechanics";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 225);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 3;
            label4.Text = "Save Location";
            // 
            // laneCounter
            // 
            laneCounter.Location = new Point(126, 18);
            laneCounter.Name = "laneCounter";
            laneCounter.Size = new Size(45, 23);
            laneCounter.TabIndex = 4;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(166, 433);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // comboMechanics
            // 
            comboMechanics.FormattingEnabled = true;
            comboMechanics.Location = new Point(108, 80);
            comboMechanics.Name = "comboMechanics";
            comboMechanics.Size = new Size(121, 23);
            comboMechanics.TabIndex = 7;
            // 
            // comboCalls
            // 
            comboCalls.FormattingEnabled = true;
            comboCalls.Location = new Point(108, 126);
            comboCalls.Name = "comboCalls";
            comboCalls.Size = new Size(121, 23);
            comboCalls.TabIndex = 8;
            // 
            // buttonCallRem
            // 
            buttonCallRem.Location = new Point(348, 129);
            buttonCallRem.Name = "buttonCallRem";
            buttonCallRem.Size = new Size(75, 23);
            buttonCallRem.TabIndex = 9;
            buttonCallRem.Text = "Remove";
            buttonCallRem.UseVisualStyleBackColor = true;
            // 
            // buttonCallAdd
            // 
            buttonCallAdd.Location = new Point(258, 129);
            buttonCallAdd.Name = "buttonCallAdd";
            buttonCallAdd.Size = new Size(75, 23);
            buttonCallAdd.TabIndex = 10;
            buttonCallAdd.Text = "Add";
            buttonCallAdd.UseVisualStyleBackColor = true;
            // 
            // buttonMechRem
            // 
            buttonMechRem.Location = new Point(348, 80);
            buttonMechRem.Name = "buttonMechRem";
            buttonMechRem.Size = new Size(75, 23);
            buttonMechRem.TabIndex = 11;
            buttonMechRem.Text = "Remove";
            buttonMechRem.UseVisualStyleBackColor = true;
            // 
            // buttonMechAdd
            // 
            buttonMechAdd.Location = new Point(258, 80);
            buttonMechAdd.Name = "buttonMechAdd";
            buttonMechAdd.Size = new Size(75, 23);
            buttonMechAdd.TabIndex = 12;
            buttonMechAdd.Text = "Add";
            buttonMechAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(520, 433);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonLogLocation
            // 
            buttonLogLocation.Location = new Point(109, 224);
            buttonLogLocation.Name = "buttonLogLocation";
            buttonLogLocation.Size = new Size(75, 23);
            buttonLogLocation.TabIndex = 14;
            buttonLogLocation.Text = "Select";
            buttonLogLocation.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 492);
            Controls.Add(buttonLogLocation);
            Controls.Add(buttonCancel);
            Controls.Add(buttonMechAdd);
            Controls.Add(buttonMechRem);
            Controls.Add(buttonCallAdd);
            Controls.Add(buttonCallRem);
            Controls.Add(comboCalls);
            Controls.Add(comboMechanics);
            Controls.Add(buttonSave);
            Controls.Add(laneCounter);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SettingsWindow";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)laneCounter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown laneCounter;
        private Button buttonSave;
        private ComboBox comboMechanics;
        private ComboBox comboCalls;
        private Button buttonCallRem;
        private Button buttonCallAdd;
        private Button buttonMechRem;
        private Button buttonMechAdd;
        private Button buttonCancel;
        private Button buttonLogLocation;
        private SaveFileDialog saveFileLocator;
    }
}