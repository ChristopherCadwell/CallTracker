
using System.Text.Json;
using System.Windows.Forms;

namespace BowlingMachineApp
{
    public partial class SettingsWindow : Form
    {
        private Settings settings;
        private string settingsFilePath;
        public SettingsWindow()
        {
            InitializeComponent();

            settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

            // Event Handlers
            this.buttonCallAdd.Click += new System.EventHandler(this.btnAddCall_Click);
            this.buttonCallRem.Click += new System.EventHandler(this.btnRemoveCall_Click);
            this.buttonMechAdd.Click += new System.EventHandler(this.btnAddMechanic_Click);
            this.buttonMechRem.Click += new System.EventHandler(this.btnRemoveMechanic_Click);
            this.buttonLogLocation.Click += new System.EventHandler(this.btnLogFileLocation_Click);
            this.buttonSave.Click += new System.EventHandler(this.btnSave_Click);
            this.buttonCancel.Click += new System.EventHandler(this.btnAddCall_Click);

            // Ensure the settings file exists
            if (!File.Exists(settingsFilePath))
            {
                // You can display an error message or do other error handling here
                MessageBox.Show("Settings not found, creating defaults");
                // Default settings
                Settings defaultSettings = new Settings
                {
                    Lanes = new List<string> { "Lane 1", "Lane 2", "Lane 3" },
                    CallTypes = new List<string> { "Type 1", "Type 2", "Type 3" },
                    Mechanics = new List<string> { "Mechanic 1", "Mechanic 2", "Mechanic 3" }
                };

                // Write the default settings to the settings file
                string defaultSettingsJson = JsonSerializer.Serialize(defaultSettings);
                File.WriteAllText(settingsFilePath, defaultSettingsJson);
            }

            // Load the current settings
            var settingsJson = File.ReadAllText(settingsFilePath);
            settings = JsonSerializer.Deserialize<Settings>(settingsJson);

            // Set the current values in the controls
            laneCounter.Value = settings.Lanes.Count;
            comboMechanics.DataSource = settings.Mechanics;
            comboCalls.DataSource = settings.CallTypes;
        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            string newMechanic = Prompt.ShowDialog("Enter a new mechanic", "Add Mechanic");
            if (!string.IsNullOrEmpty(newMechanic) && !settings.Mechanics.Contains(newMechanic))
            {
                settings.Mechanics.Add(newMechanic);
                comboMechanics.DataSource = null;
                comboMechanics.DataSource = settings.Mechanics;
            }
        }

        private void btnRemoveMechanic_Click(object sender, EventArgs e)
        {
            if (comboMechanics.SelectedItem != null)
            {
                settings.Mechanics.Remove((string)comboMechanics.SelectedItem);
                comboMechanics.DataSource = null;
                comboMechanics.DataSource = settings.Mechanics;
            }
        }

        private void btnAddCall_Click(object sender, EventArgs e)
        {
            string newCall = Prompt.ShowDialog("Enter a new call type", "Add Call Type");
            if (!string.IsNullOrEmpty(newCall) && !settings.CallTypes.Contains(newCall))
            {
                settings.CallTypes.Add(newCall);
                comboCalls.DataSource = null;
                comboCalls.DataSource = settings.CallTypes;
            }
        }

        private void btnRemoveCall_Click(object sender, EventArgs e)
        {
            if (comboCalls.SelectedItem != null)
            {
                settings.CallTypes.Remove((string)comboCalls.SelectedItem);
                comboCalls.DataSource = null;
                comboCalls.DataSource = settings.CallTypes;
            }
        }

        private void btnLogFileLocation_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Select log file location";
                saveFileDialog.FileName = settings.LogName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    settings.LogLocation = Path.GetDirectoryName(saveFileDialog.FileName);
                    settings.LogName = Path.GetFileName(saveFileDialog.FileName);

                    // You can display the selected path and filename in Labels or non-editable TextBoxes to let the user know what they have selected.
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all input fields are valid
            // You can add more validations here if needed
            if (string.IsNullOrWhiteSpace(laneCounter.Text))
            {
                MessageBox.Show("Please enter the number of lanes.");
                return;
            }

            // Apply the changes to the settings object
            settings.Lanes = new List<string>();
            for (int i = 1; i <= int.Parse(laneCounter.Text); i++)
            {
                settings.Lanes.Add("Lane " + i);
            }

            settings.Mechanics = comboMechanics.Items.Cast<string>().ToList();
            settings.CallTypes = comboCalls.Items.Cast<string>().ToList();

            // Save the settings object back to the settings file
            string settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            string settingsJson = JsonSerializer.Serialize(settings);
            File.WriteAllText(settingsFilePath, settingsJson);

            // Inform the user that the settings have been saved successfully
            MessageBox.Show("Settings saved successfully!");

            // Get a reference to the main form and reload it
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Reload();
            }

            // Close the settings form
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the settings form
            this.Close();
        }


    }
}
