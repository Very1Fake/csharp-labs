using System;
using System.Timers;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private const string correctLogin = "Login";
    private const string correctPassword = "Password";
    private int counter = 6;
    private bool Lock = false;
    private Timer _timer;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        _timer = new Timer(1000);
        _timer.Elapsed += tick;
        Build();
        _timer.Start();
    }

    private void tick(object sender, ElapsedEventArgs e)
    {
        if (counter > 0)
        {
            counter--;
            time.Text = $"Remaining time: {counter} sec.";
        }
        else
        {
            _timer.Stop();
            Lock = true;
            onLock();
            status.Text = "Time is up!";
        }
    }

    private void onLock()
    {
        login.IsEditable = false;
        login.Sensitive = false;
        password.IsEditable = false;
        password.Sensitive = false;
        auth.Sensitive = false;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void click(object sender, EventArgs e)
    {
        if (!Lock)
        {
            if (correctLogin == login.Text && correctPassword == password.Text)
            {
                status.Text = "Access granted";
                Lock = true;
                onLock();
                _timer.Stop();
            }
            else
            {
                status.Text = "Incorrect login or password";
            }
        }
    }
}
