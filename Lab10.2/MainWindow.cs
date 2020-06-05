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
        column1.AddAttribute(cellView1, "text", 0);

        Build();
        treeview1.Model = array1;
        treeview1.AppendColumn(column1);

        array1.InsertWithValues(0, "Hello World!!1");
        array1.InsertWithValues(1, "How are you ?");
        array1.InsertWithValues(2, "Wrong  sentence");
        array1.InsertWithValues(3, "English");
        array1.InsertWithValues(4, "Rust is fast");
        array1.InsertWithValues(5, "Another   wrong  sentence  ");
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
            int count = 0;

            foreach (string word in sentence.Split(' '))
            {
                if (word != "")
                {
                    count++;
                }
            }

            result.Text = $"Words count: {count}";
        }
    }
}
