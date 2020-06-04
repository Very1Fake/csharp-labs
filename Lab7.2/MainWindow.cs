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

    protected void Calculate(object sender, EventArgs e)
    {
        int[,] X = Gen2DMatrix(15, 15), Y = Gen2DMatrix(15, 15); 
        double[,] Z = new double[15, 15];

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                Z[i, j] = Math.Round(12 * X[i, j] - 0.85 * Math.Pow(Y[i, j], 2), 3);
            }
        }

        result.Text = "Result: \n";

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                result.Text += $"{Z[i, j], 10}";
            }
            result.Text += "\n\n";
        }

    }
}
