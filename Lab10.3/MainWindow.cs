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

    protected void Proceed(object sender, EventArgs e)
    {
        if (to_replace.Text.Length == 0) {
            status.Text = "Status: Enter word";
        } else if (to_replace.Text.Contains(" ")) {
            status.Text = "Status: Word can't contains ' '";
        }
        else
        {
            if (text.Text.Contains(to_replace.Text))
            {
                text.Text = text.Text.Replace(to_replace.Text, new string(' ', to_replace.Text.Length));
                status.Text = "Status: Success";
            }
            else
            {
                status.Text = "Status: Word not found";
            }
        }
    }
}
