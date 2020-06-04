using System;
using System.Timers;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Timer _timer;
    private int counter = 11;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        _timer = new Timer(1000);
        _timer.Elapsed += tick;
        Build();
    }

    private void tick(object sender, ElapsedEventArgs e)
    {
        if (counter > 0)
        {
            counter--;
            label.Text = $"remaining time: {counter} sec.";
        }
        else
        {
            _timer.Stop();
            using (var dialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Time is up!"))
            {
                dialog.Run();
            }
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void click(object sender, EventArgs e)
    {
        _timer.Start();
    }
}
