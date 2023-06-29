using System.Text.Json;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace BowlingMachineApp
{
    public partial class MainForm : Form
    {
        private List<Call> calls;
        private int? currentlyEditingRowIndex = null;
        private string excelFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "calls.xlsx");


        public MainForm()
        {
            {
                InitializeComponent();
                calls = new List<Call>();

                PopulateDropdownsFromSettingsFile();

                // Event handlers
                this.buttonSubmit.Click += new System.EventHandler(this.submitButton_Click);
                this.buttonClear.Click += new System.EventHandler(this.clearButton_Click);
                this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
                this.callsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.callsDataGridView_CellContentClick);

                this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
                this.configureMenuItem.Click += new System.EventHandler(this.configureMenuItem_Click);
                this.generateMenuItem.Click += new System.EventHandler(this.generateMenuItem_Click);
                this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
                this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
                this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);

                // Add edit button to DataGridView
                if (!callsDataGridView.Columns.Contains("EditButton"))
                {
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                    {
                        Name = "EditButton",
                        Text = "Edit",
                        HeaderText = "",
                        UseColumnTextForButtonValue = true
                    };
                    callsDataGridView.Columns.Add(buttonColumn);
                }

                // Load calls for today's date
                LoadCalls(DateTime.Now);
            }
        }
        private string GetExcelFilePath()
        {
            var settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

            if (!File.Exists(settingsFilePath))
            {
                // Handle error (settings file not found)
                MessageBox.Show("Settings file not found");
                return null;
            }

            var settingsFileContent = File.ReadAllText(settingsFilePath);
            var settings = JsonSerializer.Deserialize<Settings>(settingsFileContent);

            // Combine the log location and name to form the full path
            var excelFilePath = Path.Combine(settings.LogLocation, settings.LogName);

            return excelFilePath;
        }
        private void LoadCalls(DateTime date)
        {
            // Clear the existing calls
            calls.Clear();

            if (File.Exists(GetExcelFilePath()))
            {
                using (XLWorkbook workbook = new XLWorkbook(GetExcelFilePath()))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Skip the header row

                    foreach (var row in rows)
                    {
                        Call call = new Call
                        {
                            Date = (DateTime)row.Cell(1).Value,
                            Lane = row.Cell(2).Value.ToString(),
                            CallType = row.Cell(3).Value.ToString(),
                            Mechanic = row.Cell(4).Value.ToString(),
                            Description = row.Cell(5).Value.ToString(),
                            AdditionalInformation = row.Cell(6).Value.ToString()
                        };

                        if (call.Date.Date == date.Date)
                        {
                            // Add the loaded call to the existing list
                            calls.Add(call);
                        }
                    }
                }
            }

            // Bind the list of calls to the DataGridView
            callsDataGridView.DataSource = null;
            callsDataGridView.DataSource = calls;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dropLane.SelectedItem?.ToString()))
            {
                InfoBox customMessageBox = new InfoBox("Error", "The lane field must be filled in before submitting a call.");
                customMessageBox.StartPosition = FormStartPosition.CenterParent;
                customMessageBox.ShowDialog(this);
                return;
            }

            if (string.IsNullOrEmpty(dropCall.SelectedItem?.ToString()))
            {
                InfoBox customMessageBox = new InfoBox("Error", "The Call field must be filled in before submitting a call.");
                customMessageBox.StartPosition = FormStartPosition.CenterParent;
                customMessageBox.ShowDialog(this);
                return;
            }
            if (string.IsNullOrEmpty(dropMechanic.SelectedItem?.ToString()))
            {
                InfoBox customMessageBox = new InfoBox("Error", "The Mechanic field must be filled in before submitting a call.");
                customMessageBox.StartPosition = FormStartPosition.CenterParent;
                customMessageBox.ShowDialog(this);
                return;
            }

            // Create a new call
            Call newCall = new Call
            {
                Lane = dropLane.SelectedItem.ToString(),
                CallType = dropCall.SelectedItem.ToString(),
                Mechanic = dropMechanic.SelectedItem.ToString(),
                Description = textDesc.Text,
                AdditionalInformation = textAdditional.Text,
                Date = calendar.SelectionStart
            };

            // Add the call to the list (or save it in a database)
            calls.Add(newCall);

            if (currentlyEditingRowIndex.HasValue)
            {
                // Update the existing call in the Excel file
                using (XLWorkbook workbook = new XLWorkbook(GetExcelFilePath()))
                {
                    var worksheet = workbook.Worksheet(1);
                    var row = worksheet.Row(currentlyEditingRowIndex.Value + 2); // +2 because Excel is 1-indexed and the header row is not included in the row index

                    row.Cell(1).Value = newCall.Date;
                    row.Cell(2).Value = newCall.Lane;
                    row.Cell(3).Value = newCall.CallType;
                    row.Cell(4).Value = newCall.Mechanic;
                    row.Cell(5).Value = newCall.Description;
                    row.Cell(6).Value = newCall.AdditionalInformation;

                    workbook.Save();
                }

                // Reset currentlyEditingRowIndex
                currentlyEditingRowIndex = null;
            }
            else
            {
                // Append the call to the Excel file

                XLWorkbook workbook;

                if (File.Exists(GetExcelFilePath()))
                {
                    workbook = new XLWorkbook(GetExcelFilePath());
                }
                else
                {
                    workbook = new XLWorkbook();
                    var worksheet1 = workbook.AddWorksheet("Sheet1");
                    worksheet1.Cell(1, 1).Value = "Date";
                    worksheet1.Cell(1, 2).Value = "Lane";
                    worksheet1.Cell(1, 3).Value = "Call Type";
                    worksheet1.Cell(1, 4).Value = "Mechanic";
                    worksheet1.Cell(1, 5).Value = "Description";
                    worksheet1.Cell(1, 6).Value = "Additional Information";
                }

                var worksheet = workbook.Worksheet(1);
                var lastRow = worksheet.LastRowUsed().RowNumber();

                worksheet.Cell(lastRow + 1, 1).Value = newCall.Date;
                worksheet.Cell(lastRow + 1, 2).Value = newCall.Lane;
                worksheet.Cell(lastRow + 1, 3).Value = newCall.CallType;
                worksheet.Cell(lastRow + 1, 4).Value = newCall.Mechanic;
                worksheet.Cell(lastRow + 1, 5).Value = newCall.Description;
                worksheet.Cell(lastRow + 1, 6).Value = newCall.AdditionalInformation;

                workbook.SaveAs(GetExcelFilePath());

            }

            // Refresh the DataGridView
            callsDataGridView.DataSource = null;
            callsDataGridView.DataSource = calls;

            // Create edit button
            if (!callsDataGridView.Columns.Contains("EditButton"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    Text = "Edit",
                    HeaderText = "",
                    UseColumnTextForButtonValue = true
                };
                callsDataGridView.Columns.Add(buttonColumn);
            }

            // Clear the fields for the next entry
            dropLane.SelectedItem = null;
            dropCall.SelectedItem = null;
            textDesc.Clear();
            textAdditional.Clear();
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            dropLane.SelectedIndex = -1;
            dropCall.SelectedIndex = -1;
            dropMechanic.SelectedIndex = -1;
            textDesc.Clear();
            textAdditional.Clear();
            calendar.SetDate(DateTime.Now);
        }
        private void calendar_DateChanged(object sender, EventArgs e)
        {
            // Reload the calls when the selected date changes
            LoadCalls(calendar.SelectionStart);
        }
        private void PopulateDropdownsFromSettingsFile()
        {
            // Combine the base directory of the application with the name of the settings file
            var settingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

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
                    Mechanics = new List<string> { "Mechanic 1", "Mechanic 2", "Mechanic 3" },
                    LogLocation = AppDomain.CurrentDomain.BaseDirectory,
                    LogName = "calls.xlsx"
                };

                // Write the default settings to the settings file
                string defaultSettingsJson = JsonSerializer.Serialize(defaultSettings);
                File.WriteAllText(settingsFilePath, defaultSettingsJson);
            }


            // Read and deserialize the settings file
            var settingsFileContent = File.ReadAllText(settingsFilePath);
            var settings = JsonSerializer.Deserialize<Settings>(settingsFileContent);

            // Clear dropdowns before populating
            dropLane.Items.Clear();
            dropCall.Items.Clear();
            dropMechanic.Items.Clear();


            foreach (var lane in settings.Lanes)
                dropLane.Items.Add(lane);

            foreach (var callType in settings.CallTypes)
                dropCall.Items.Add(callType);

            foreach (var mechanic in settings.Mechanics)
                dropMechanic.Items.Add(mechanic);
        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Theme.ApplyLightTheme(this);
            this.Refresh();
        }
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Theme.ApplyDarkTheme(this);
            this.Refresh();
        }
        private void callsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the button column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && callsDataGridView.Columns[e.ColumnIndex].Name == "EditButton")
            {
                // Get the call from the clicked row
                Call call = (Call)callsDataGridView.Rows[e.RowIndex].DataBoundItem;

                // Fill the input fields with the data of the call
                dropLane.SelectedItem = dropLane.Items.Cast<string>().FirstOrDefault(i => i == call.Lane);
                dropCall.SelectedItem = dropCall.Items.Cast<string>().FirstOrDefault(i => i == call.CallType);
                dropMechanic.SelectedItem = dropMechanic.Items.Cast<string>().FirstOrDefault(i => i == call.Mechanic);
                textDesc.Text = call.Description;
                textAdditional.Text = call.AdditionalInformation;
                calendar.SelectionStart = call.Date;

                // Remember which row is being edited
                currentlyEditingRowIndex = e.RowIndex;
            }
        }
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            // The action to perform when 'Exit' is clicked
            this.Close();
        }
        private void configureMenuItem_Click(object sender, EventArgs e)
        {
            // Open the settings form
            var settingsForm = new SettingsWindow();
            settingsForm.ShowDialog();
        }
        private void generateMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(GetExcelFilePath()))
            {
                using (XLWorkbook workbook = new XLWorkbook(GetExcelFilePath()))
                {
                    var worksheet = workbook.Worksheet(1);

                    // Check if a table already exists
                    if (worksheet.Tables.Any())
                    {
                        var table = worksheet.Tables.First();

                        // Change the theme of the table
                        table.Theme = XLTableTheme.TableStyleMedium8;

                        // Clear the data from the table
                        var range = table.DataRange; // Gets the data range of the table
                        range.Clear(XLClearOptions.Contents); // Clears the content of the cells in the range
                    }
                    else
                    {
                        // Create a new table if none exists
                        var range = worksheet.RangeUsed();
                        var table = range.CreateTable();
                        table.Theme = XLTableTheme.TableStyleMedium8;
                    }

                    workbook.Save();
                }
            }
            else
            {
                // Handle the case where the file doesn't exist
                MessageBox.Show("Excel file not found. Please create a call first.");
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            // Show About dialogue box
            var aboutMessage = new string[]
            {
                "For the latest version of this application",
                "https://github.com/ChristopherCadwell/CallTracker/tree/main/Release"
            };

            InfoBox customMessageBox = new InfoBox("Mechanic's Call Tracker", string.Join(Environment.NewLine, aboutMessage));
            customMessageBox.StartPosition = FormStartPosition.CenterParent;
            customMessageBox.ShowDialog(this);
        }
        public void Reload()
        {
            // Reload the settings and dropdowns
            PopulateDropdownsFromSettingsFile();

            // Reload the calls for the currently selected date
            LoadCalls(calendar.SelectionStart);
        }
    }

}


