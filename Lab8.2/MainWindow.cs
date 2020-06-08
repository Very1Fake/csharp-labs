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

    protected void Calculate(object sender, EventArgs e)
    {
        int size = (int)spinbutton1.Value;
        int[,] Z = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j == i) Z[i, j] = 1;
                else if (j == i) Z[i, j] = 0;
            }
        }

        result.Text = "Result:\n";

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result.Text += $"{Z[i, j],10}";
                if (j == size - 1)
                {
                    result.Text += "\t\t";
                }
            }
            result.Text += "\n\n";
        }
    }
}
