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

    private int[] Array = new int[15];

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        column1 = new TreeViewColumn("Source Arrat", cellView1);
        column2 = new TreeViewColumn("Sort Array", cellView2);

        Build();

        column1.AddAttribute(cellView1, "text", 0);
        treeview1.Model = array1;
        treeview1.AppendColumn(column1);
        column2.AddAttribute(cellView2, "text", 0);
        treeview2.Model = array2;
        treeview2.AppendColumn(column2);

        Random random = new Random();

        for (var i = 0; i < 15; i++)
        {
            Array[i] = random.Next(-50, 50);
            array1.InsertWithValues(i, $"F[{i}] = {Array[i]}");
        }
    }

    protected void BubbleSort(ref int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = 0; j < list.Length - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int temp = list[j + 1];
                    list[j + 1] = list[j];
                    list[j] = temp;
                }
            }
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Sort(object sender, EventArgs e)
    {
        array2.Clear();
        BubbleSort(ref Array);

        for (int i = 0; i < 15; i++) array2.InsertWithValues(i, $"Array[{i}] = {Array[i]}");
    }
}
