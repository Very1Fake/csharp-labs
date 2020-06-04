using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Calculate()
    {
        float x = entry_x.Text.Length != 0 ? float.Parse(entry_x.Text) : 0;
        float y = entry_y.Text.Length != 0 ? float.Parse(entry_y.Text) : 0;
        float z = entry_z.Text.Length != 0 ? float.Parse(entry_z.Text) : 0;

        double phi = (Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), x + y)) / (Math.Atan(x) + Math.Atan(z))
                         + Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log10(y), 2), 1 / 3);

        result.Text = $"Result: {phi}";
    }

    protected void entry_X_changed(object sender, EventArgs e) => Calculate();

    protected void entry_y_changed(object sender, EventArgs e) => Calculate();

    protected void entry_z_changed(object sender, EventArgs e) => Calculate();
}
