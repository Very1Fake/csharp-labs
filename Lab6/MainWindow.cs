using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Gtk.ListStore array1 = new Gtk.ListStore(typeof(string));
    private CellRendererText cellView1 = new CellRendererText();
    private TreeViewColumn column1;
    private Gtk.ListStore array2 = new Gtk.ListStore(typeof(string));
    private CellRendererText cellView2 = new CellRendererText();
    private TreeViewColumn column2;

    private int[] F = new int[18];

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

    protected void refresh(object sender, EventArgs e)
    {
        array1.Clear();
        var rand = new Random();
        for (var i = 0; i < 18; i++)
        {
            F[i] = rand.Next(-50, 50);
            array1.InsertWithValues(i, $"F[{i}] = {F[i]}");
        }
    }

    protected void replace(object sender, EventArgs e)
    {
        array2.Clear();
        for (var i = 0; i < 18; i++)
        {
            if ((0.13 * Math.Pow(F[i], 3) - 2.5 * F[i] + 8) < 0)
            {
                array2.InsertWithValues(i, $"P[{i}] = {0.13 * Math.Pow(F[i], 3) - 2.5 * F[i] + 8}");
            }
        }
    }
}
