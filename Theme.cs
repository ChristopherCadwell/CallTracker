using System.Drawing;
using System.Windows.Forms;

namespace CallTracker
{
    public static class Theme
    {

        public static void ApplyDarkTheme(Control control)
        {
            control.BackColor = Color.FromArgb(45, 45, 48);
            control.ForeColor = Color.White;

            foreach (Control c in control.Controls)
            {
                ApplyDarkTheme(c); // Apply theme recursively to all controls
            }

            // Handle special controls here:
            if (control is Button button)
            {
                button.BackColor = Color.FromArgb(63, 63, 70);
                button.ForeColor = Color.White;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = Color.FromArgb(37, 37, 38);
                comboBox.ForeColor = Color.White;
            }
            // Add similar blocks for other control types (RichTextBox, Label, MonthCalendar, DataGridView, etc.)
        }

        public static void ApplyLightTheme(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;

            foreach (Control c in control.Controls)
            {
                ApplyLightTheme(c); // Apply theme recursively to all controls
            }

            // Handle special controls here:
            if (control is Button button)
            {
                button.BackColor = SystemColors.ButtonFace;
                button.ForeColor = SystemColors.ControlText;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = SystemColors.Window;
                comboBox.ForeColor = SystemColors.WindowText;
            }
            // Add similar blocks for other control types (RichTextBox, Label, MonthCalendar, DataGridView, etc.)
        }
    }
}

