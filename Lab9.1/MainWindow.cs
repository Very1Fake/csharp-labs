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

    protected static double Calc(double x, double y, double z) => (Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), x + y)) / (Math.Atan(x) + Math.Atan(z))
                         + Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log10(y), 2), 1 / 3);

    protected void Proceed(object sender, EventArgs e)
    {
        double x = entry_x.Text.Length != 0 ? double.Parse(entry_x.Text) : 0;
        double y = entry_y.Text.Length != 0 ? double.Parse(entry_y.Text) : 0;
        double z = entry_z.Text.Length != 0 ? double.Parse(entry_z.Text) : 0;

        result.Text = $"Result: {Calc(x, y, z)}";
    }
}
