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

    protected void calculate(object sender, EventArgs e)
    {
        int percent = 0;
        double temp = sum.Text.Length != 0 ? double.Parse(sum.Text) : 0;
        if (rbsm.Active) percent = 6;
        else if (rbnm.Active)
        {
            if (client.Active) percent = 11;
            else percent = 9;
        } else if (rbtm.Active)
        {
            if (client.Active) percent = 15;
            else percent = 12;
        }
        result.Text = (temp + (temp / 100) * percent).ToString();
    }
}
