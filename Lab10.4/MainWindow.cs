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

    protected void Analyze(object sender, EventArgs e)
    {
        if (text.Text.Length == 0)
        {
            result.Text = "Enter sentence";
        }
        else
        {
            string longest = "";
            string shortest = "";
            int longest_l = 0;
            int shortest_l = int.MaxValue;

            foreach (string word in text.Text.Split(' '))
            {
                if (word.Length > longest_l)
                {
                    longest = word;
                    longest_l = word.Length;
                } if (word.Length < shortest_l) {
                    shortest = word;
                    shortest_l = word.Length;
                }
            }

            result.Text = $"Longest word: {longest}\nShortest word: {shortest}";
        }
    }
}
