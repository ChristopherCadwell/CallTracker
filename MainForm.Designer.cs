namespace BowlingMachineApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        private Button buttonSubmit;
        private Button buttonClear;
        private ComboBox dropMechanic;
        private ComboBox dropCall;
        private MonthCalendar calendar;
        private RichTextBox textAdditional;
        private RichTextBox textDesc;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox dropLane;

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
            buttonSubmit = new Button();
            buttonClear = new Button();
            dropMechanic = new ComboBox();
            dropCall = new ComboBox();
            calendar = new MonthCalendar();
            textAdditional = new RichTextBox();
            textDesc = new RichTextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dropLane = new ComboBox();
            callsDataGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            configureMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            generateMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)callsDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(456, 510);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 0;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(537, 510);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // dropMechanic
            // 
            dropMechanic.AutoCompleteMode = AutoCompleteMode.Suggest;
            dropMechanic.AutoCompleteSource = AutoCompleteSource.ListItems;
            dropMechanic.DropDownStyle = ComboBoxStyle.DropDownList;
            dropMechanic.FormattingEnabled = true;
            dropMechanic.Location = new Point(316, 30);
            dropMechanic.Name = "dropMechanic";
            dropMechanic.Size = new Size(121, 23);
            dropMechanic.TabIndex = 2;
            // 
            // dropCall
            // 
            dropCall.AutoCompleteMode = AutoCompleteMode.Suggest;
            dropCall.AutoCompleteSource = AutoCompleteSource.ListItems;
            dropCall.DropDownStyle = ComboBoxStyle.DropDownList;
            dropCall.FormattingEnabled = true;
            dropCall.Location = new Point(316, 149);
            dropCall.Name = "dropCall";
            dropCall.Size = new Size(121, 23);
            dropCall.TabIndex = 3;
            // 
            // calendar
            // 
            calendar.Location = new Point(12, 33);
            calendar.MaxSelectionCount = 1;
            calendar.Name = "calendar";
            calendar.TabIndex = 4;
            // 
            // textAdditional
            // 
            textAdditional.Location = new Point(537, 51);
            textAdditional.Name = "textAdditional";
            textAdditional.Size = new Size(498, 453);
            textAdditional.TabIndex = 6;
            textAdditional.Text = "";
            // 
            // textDesc
            // 
            textDesc.Location = new Point(12, 222);
            textDesc.Name = "textDesc";
            textDesc.Size = new Size(519, 282);
            textDesc.TabIndex = 7;
            textDesc.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 33);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 8;
            label1.Text = "Mechanic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(752, 33);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 10;
            label3.Text = "Additional Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 204);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 11;
            label4.Text = "Call Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 157);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 12;
            label5.Text = "Call";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 106);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 13;
            label6.Text = "Lane";
            // 
            // dropLane
            // 
            dropLane.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            dropLane.AutoCompleteSource = AutoCompleteSource.ListItems;
            dropLane.DropDownStyle = ComboBoxStyle.DropDownList;
            dropLane.FormattingEnabled = true;
            dropLane.Location = new Point(316, 103);
            dropLane.Name = "dropLane";
            dropLane.Size = new Size(121, 23);
            dropLane.TabIndex = 14;
            // 
            // callsDataGridView
            // 
            callsDataGridView.AllowUserToAddRows = false;
            callsDataGridView.AllowUserToDeleteRows = false;
            callsDataGridView.AllowUserToResizeRows = false;
            callsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            callsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            callsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            callsDataGridView.Location = new Point(12, 539);
            callsDataGridView.Name = "callsDataGridView";
            callsDataGridView.ReadOnly = true;
            callsDataGridView.RowTemplate.Height = 25;
            callsDataGridView.Size = new Size(1023, 509);
            callsDataGridView.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, reportsToolStripMenuItem, themeToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1038, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(93, 22);
            exitMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configureMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // configureMenuItem
            // 
            configureMenuItem.Name = "configureMenuItem";
            configureMenuItem.Size = new Size(127, 22);
            configureMenuItem.Text = "Configure";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // generateMenuItem
            // 
            generateMenuItem.Name = "generateMenuItem";
            generateMenuItem.Size = new Size(121, 22);
            generateMenuItem.Text = "Generate";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem, darkToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(55, 20);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(101, 22);
            lightToolStripMenuItem.Text = "Light";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(101, 22);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(107, 22);
            aboutMenuItem.Text = "About";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1038, 1061);
            Controls.Add(callsDataGridView);
            Controls.Add(dropLane);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textDesc);
            Controls.Add(textAdditional);
            Controls.Add(calendar);
            Controls.Add(dropCall);
            Controls.Add(dropMechanic);
            Controls.Add(buttonClear);
            Controls.Add(buttonSubmit);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Mechanic Call Tracker";
            ((System.ComponentModel.ISupportInitialize)callsDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private DataGridView callsDataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem configureMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem generateMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
    }
}