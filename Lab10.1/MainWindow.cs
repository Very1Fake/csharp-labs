using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private Gtk.ListStore array1 = new Gtk.ListStore(typeof(string));
    private CellRendererText cellView1 = new CellRendererText();
    private TreeViewColumn column1;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        column1 = new TreeViewColumn("Sentences", cellView1);

        Build();

        column1.AddAttribute(cellView1, "text", 0);
        treeview1.Model = array1;
        treeview1.AppendColumn(column1);

        array1.InsertWithValues(0, "Hello World!!1");
        array1.InsertWithValues(1, "How are you ?");
        array1.InsertWithValues(2, "English");
        array1.InsertWithValues(3, "Rust is fast");
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Proceed(object sender, EventArgs e)
    {
        TreeIter iter;
        TreeModel model;

        if (!treeview1.Selection.GetSelected(out model, out iter))
        {
            result.Text = "Select sentence";
        }
        else
        {
            string sentence = array1.GetValue(iter, 0).ToString();
            result.Text = $"Words count: {sentence.Split(' ').Length}";
        }
    }
}
