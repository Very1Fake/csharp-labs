
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed3;

	private global::Gtk.Entry text;

	private global::Gtk.Button button1;

	private global::Gtk.Label result;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed3 = new global::Gtk.Fixed();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.text = new global::Gtk.Entry();
		this.text.WidthRequest = 256;
		this.text.CanFocus = true;
		this.text.Name = "text";
		this.text.IsEditable = true;
		this.text.InvisibleChar = '•';
		this.fixed3.Add(this.text);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.text]));
		w1.X = 68;
		w1.Y = 29;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Analyze");
		this.fixed3.Add(this.button1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.button1]));
		w2.X = 164;
		w2.Y = 133;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.result = new global::Gtk.Label();
		this.result.Name = "result";
		this.fixed3.Add(this.result);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.result]));
		w3.X = 81;
		w3.Y = 76;
		this.Add(this.fixed3);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 393;
		this.DefaultHeight = 206;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Released += new global::System.EventHandler(this.Analyze);
	}
}
