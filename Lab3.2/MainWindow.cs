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

    protected void calc_clicked(object sender, EventArgs e)
    {
        double left = left_border.Text.Length != 0 ? double.Parse(left_border.Text) : 0;
        double right = right_border.Text.Length != 0 ? double.Parse(right_border.Text) : 0;
        double step = step_entry.Text.Length != 0 ? double.Parse(step_entry.Text) : 0;

        double temp;

        for (double i = left; i <= right; i += step)
        {
            if (i <= 0)
            {
                temp = Math.Sqrt(1 + 2 * Math.Pow(i, 2));
            }
            else
            {
                temp = (1 + i)/(1 + Math.Pow(1 + Math.Exp(i), 1/3));
            }
            result.Buffer.Text += $"x = {i};   y = {temp}\n";
        }
    }
}
