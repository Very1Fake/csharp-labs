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

    private int[,] Gen2DMatrix(int height, int width)
    {
        Random random = new Random();
        int[,] mat = new int[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                mat[i, j] = random.Next(-10, 10);
            }
        }

        return mat;
    }

    protected void Calculate(ref int[,] x, ref int[,] y, ref double[,] z)
    {
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                z[i, j] = Math.Round(12 * x[i, j] - 0.85 * Math.Pow(y[i, j], 2), 3);
            }
        }
    }

    protected void Proceed(object sender, EventArgs e)
    {
        int[,] X = Gen2DMatrix(15, 15), Y = Gen2DMatrix(15, 15);

        result.Text = "Result: \n";

        double[,] Z = new double[15, 15];
        Calculate(ref X, ref Y, ref Z);

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                result.Text += $"{Z[i, j],10}";
            }
            result.Text += "\n\n";
        }

    }
}
