public class Theme
{
    public string Name { get; set; }
    public Color BackColor { get; set; }
    public Color ForeColor { get; set; }
    public Color MenuBackColor { get; set; }
    public Color MenuForeColor { get; set; }
    public Color ButtonBackColor { get; set; }
    public Color ButtonForeColor { get; set; }
    public Color GridBackColor { get; set; }
    public Color GridForeColor { get; set; }
    public Color TextBoxBackColor { get; set; }
    public Color TextBoxForeColor { get; set; }
    public Color DropDownBackColor { get; set; }
    public Color DropDownForeColor { get; set; }
    public Color CalendarBackColor { get; set; }
    public Color CalendarForeColor { get; set; }

    public static Theme Light => new Theme
    {
        Name = "Light",
        BackColor = Color.FromKnownColor(KnownColor.Control),
        ForeColor = Color.FromKnownColor(KnownColor.ControlText),
        MenuBackColor = Color.FromKnownColor(KnownColor.Menu),
        MenuForeColor = Color.FromKnownColor(KnownColor.MenuText),
        ButtonBackColor = Color.FromKnownColor(KnownColor.ButtonFace),
        ButtonForeColor = Color.FromKnownColor(KnownColor.ButtonHighlight),
        GridBackColor = Color.FromKnownColor(KnownColor.Window),
        GridForeColor = Color.FromKnownColor(KnownColor.WindowText),
        TextBoxBackColor = Color.FromKnownColor(KnownColor.Window),
        TextBoxForeColor = Color.FromKnownColor(KnownColor.WindowText),
        DropDownBackColor = Color.FromKnownColor(KnownColor.Window),
        DropDownForeColor = Color.FromKnownColor(KnownColor.WindowText),
        CalendarBackColor = Color.FromKnownColor(KnownColor.Window),
        CalendarForeColor = Color.FromKnownColor(KnownColor.WindowText)
    };

    public static Theme Dark => new Theme
    {
        Name = "Dark",
        BackColor = Color.FromArgb(50, 50, 50),
        ForeColor = Color.White,
        MenuBackColor = Color.FromArgb(70, 70, 70),
        MenuForeColor = Color.White,
        ButtonBackColor = Color.FromArgb(70, 70, 70),
        ButtonForeColor = Color.White,
        GridBackColor = Color.FromArgb(50, 50, 50),
        GridForeColor = Color.White,
        TextBoxBackColor = Color.FromArgb(50, 50, 50),
        TextBoxForeColor = Color.White,
        DropDownBackColor = Color.FromArgb(50, 50, 50),
        DropDownForeColor = Color.White,
        CalendarBackColor = Color.FromArgb(50, 50, 50),
        CalendarForeColor = Color.White
    };

    public static Theme Blue => new Theme
    {
        Name = "Blue",
        BackColor = Color.LightBlue,
        ForeColor = Color.DarkBlue,
        MenuBackColor = Color.DarkBlue,
        MenuForeColor = Color.White,
        ButtonBackColor = Color.DarkBlue,
        ButtonForeColor = Color.White,
        GridBackColor = Color.LightBlue,
        GridForeColor = Color.DarkBlue,
        TextBoxBackColor = Color.LightBlue,
        TextBoxForeColor = Color.DarkBlue,
        DropDownBackColor = Color.LightBlue,
        DropDownForeColor = Color.DarkBlue,
        CalendarBackColor = Color.LightBlue,
        CalendarForeColor = Color.DarkBlue
    };

    public static Theme Green => new Theme
    {
        Name = "Green",
        BackColor = Color.LightGreen,
        ForeColor = Color.DarkGreen,
        MenuBackColor = Color.DarkGreen,
        MenuForeColor = Color.White,
        ButtonBackColor = Color.DarkGreen,
        ButtonForeColor = Color.White,
        GridBackColor = Color.LightGreen,
        GridForeColor = Color.DarkGreen,
        TextBoxBackColor = Color.LightGreen,
        TextBoxForeColor = Color.DarkGreen,
        DropDownBackColor = Color.LightGreen,
        DropDownForeColor = Color.DarkGreen,
        CalendarBackColor = Color.LightGreen,
        CalendarForeColor = Color.DarkGreen
    };

    public static Theme Red => new Theme
    {
        Name = "Red",
        BackColor = Color.LightCoral,
        ForeColor = Color.DarkRed,
        MenuBackColor = Color.DarkRed,
        MenuForeColor = Color.White,
        ButtonBackColor = Color.DarkRed,
        ButtonForeColor = Color.White,
        GridBackColor = Color.LightCoral,
        GridForeColor = Color.DarkRed,
        TextBoxBackColor = Color.LightCoral,
        TextBoxForeColor = Color.DarkRed,
        DropDownBackColor = Color.LightCoral,
        DropDownForeColor = Color.DarkRed,
        CalendarBackColor = Color.LightCoral,
        CalendarForeColor = Color.DarkRed
    };

    public static Theme Purple => new Theme
    {
        Name = "Purple",
        BackColor = Color.Thistle,
        ForeColor = Color.Indigo,
        MenuBackColor = Color.Indigo,
        MenuForeColor = Color.White,
        ButtonBackColor = Color.Indigo,
        ButtonForeColor = Color.White,
        GridBackColor = Color.Thistle,
        GridForeColor = Color.Indigo,
        TextBoxBackColor = Color.Thistle,
        TextBoxForeColor = Color.Indigo,
        DropDownBackColor = Color.Thistle,
        DropDownForeColor = Color.Indigo,
        CalendarBackColor = Color.Thistle,
        CalendarForeColor = Color.Indigo
    };

    public static Theme Orange => new Theme
    {
        Name = "Orange",
        BackColor = Color.Moccasin,
        ForeColor = Color.DarkOrange,
        MenuBackColor = Color.DarkOrange,
        MenuForeColor = Color.White,
        ButtonBackColor = Color.DarkOrange,
        ButtonForeColor = Color.White,
        GridBackColor = Color.Moccasin,
        GridForeColor = Color.DarkOrange,
        TextBoxBackColor = Color.Moccasin,
        TextBoxForeColor = Color.DarkOrange,
        DropDownBackColor = Color.Moccasin,
        DropDownForeColor = Color.DarkOrange,
        CalendarBackColor = Color.Moccasin,
        CalendarForeColor = Color.DarkOrange
    };
}
