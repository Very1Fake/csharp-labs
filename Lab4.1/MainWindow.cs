using System;
using System.Timers;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Timer _timer;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        _timer = new Timer(1000);
        _timer.Elapsed += (object sender, ElapsedEventArgs e) 
        => timeLabel.Text = $"Current time: {DateTime.Now.ToString("HH:mm:ss")}";
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void start_event(object sender, EventArgs e)
    {
        _timer.Start();
    }

    protected void stop_event(object sender, EventArgs e)
    {
        _timer.Stop();
        timeLabel.Text += "   (Stopped)";
    }
}
