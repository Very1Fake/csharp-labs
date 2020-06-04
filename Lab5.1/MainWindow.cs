using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    private void render()
    {
        if (rbred.Active)
        {
            drawingarea1.ModifyBg(StateType.Normal, new Gdk.Color(255, 0, 0));
            drawingarea2.ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 255));
            drawingarea3.ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 255));
        }
        if (rbyellow.Active)
        {
            drawingarea2.ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 0));
            drawingarea1.ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 255));
            drawingarea3.ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 255));
        }
        if (rbgreen.Active)
        {
            drawingarea3.ModifyBg(StateType.Normal, new Gdk.Color(0, 255, 0));
            drawingarea1.ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 255));
            drawingarea2.ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 255));
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void rbtoggle(object sender, EventArgs e) => render();
}
