
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button button1;

	private global::Gtk.Label result;

	private global::Gtk.Label matrix;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Calculate");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w1.X = 5;
		w1.Y = 3;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.result = new global::Gtk.Label();
		this.result.Name = "result";
		this.result.LabelProp = global::Mono.Unix.Catalog.GetString("Result: ");
		this.fixed1.Add(this.result);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.result]));
		w2.X = 94;
		w2.Y = 13;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.matrix = new global::Gtk.Label();
		this.matrix.Name = "matrix";
		this.fixed1.Add(this.matrix);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.matrix]));
		w3.X = 10;
		w3.Y = 50;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 638;
		this.DefaultHeight = 484;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Released += new global::System.EventHandler(this.Calculate);
	}
}
