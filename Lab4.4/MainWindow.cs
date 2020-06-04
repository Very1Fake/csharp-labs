using System;
using System.Timers;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Timer _timer;

    private DateTime maraphone = new DateTime(2020, 10, 4, 9, 0, 0);

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        _timer = new Timer(1000);
        _timer.Elapsed += tick;
        Build();
        _timer.Start();
    }

    private void tick(object sender, ElapsedEventArgs e)
    {
        TimeSpan span = maraphone - DateTime.Now;
        string temp = "";
        if (span.Days > 0) {
            temp += $"{span.Days} days ";
        }
        if (span.Hours > 0)
        {
            temp += $"{span.Hours} hours ";
        }
        if (span.Minutes > 0)
        {
            temp += $"{span.Minutes} minutes ";
        }
        remains.Text = $"{temp}remains to maraphone start";
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
