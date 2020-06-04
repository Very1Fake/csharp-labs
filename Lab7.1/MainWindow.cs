using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private int[,] X = new int[15, 15];

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Random random = new Random();

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                X[i, j] = random.Next(-100, 100);
            }
        }

        matrix.Text = "Result: \n";

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                matrix.Text += $"{X[i, j],10}";
            }
            matrix.Text += "\n\n";
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }


    protected void Calculate(object sender, EventArgs e)
    {

        int largest = int.MinValue;

        for (int i = 0; i < 15; i++)
        {
            if (X[i, 14 - i] > largest)
            {
                largest = X[i, 14 - i];
            }
        }

        result.Text = $"Result: {largest}";
    }
}
