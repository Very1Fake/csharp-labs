using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        for(int i = 32; i < 256; i++)
        {
            if ((i - 32) % 15 == 0) {
                result.Text += "\n";
            }
            result.Text += $"{String.Format("{0, 2}", Convert.ToChar(i))} - {String.Format("{0, 3}", i)}  ";
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
