using System;
using System.Collections.Generic;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Gtk.ListStore array1 = new Gtk.ListStore(typeof(string));
    private CellRendererText cellView1 = new CellRendererText();
    private TreeViewColumn column1;
    private Gtk.ListStore array2 = new Gtk.ListStore(typeof(string));
    private CellRendererText cellView2 = new CellRendererText();
    private TreeViewColumn column2;

    private Random rand = new Random();
    private List<int> F = new List<int>();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        column1 = new TreeViewColumn("Source Array", cellView1);
        column2 = new TreeViewColumn("Final Array", cellView2);

        Build();

        column1.AddAttribute(cellView1, "text", 0);
        treeview1.Model = array1;
        treeview1.AppendColumn(column1);
        column2.AddAttribute(cellView2, "text", 0);
        treeview2.Model = array2;
        treeview2.AppendColumn(column2);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected List<double> Sort(ref List<int> f)
    {
        List<double> p = new List<double>();

        foreach (int item in f)
        {
            if ((0.13 * Math.Pow(item, 3) - 2.5 * item + 8) < 0)
                p.Add((0.13 * Math.Pow(item, 3) - 2.5 * item + 8));
        }

        return p;
    }

    protected void Refresh(object sender, EventArgs e)
    {
        array1.Clear();
        F.Clear();

        for (var i = 0; i < 18; i++)
        {
            F.Add(rand.Next(-50, 50));
            array1.InsertWithValues(i, $"F[{i}] = {F[i]}");
        }
    }

    protected void Replace(object sender, EventArgs e)
    {
        array2.Clear();
        var sorted = Sort(ref F);

        for (int i = 0; i < sorted.Count; i++)
        {
            array2.InsertWithValues(i, $"P[{i}] = {F[i]}");
        }
    }
}
