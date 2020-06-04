
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label label2;

	private global::Gtk.Label label4;

	private global::Gtk.Label label3;

	private global::Gtk.Entry left_border;

	private global::Gtk.Entry right_border;

	private global::Gtk.Entry step_entry;

	private global::Gtk.Button button1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView result;

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
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Enter right border");
		this.fixed1.Add(this.label2);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
		w1.X = 10;
		w1.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Enter step");
		this.fixed1.Add(this.label4);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label4]));
		w2.X = 10;
		w2.Y = 90;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Enter left border");
		this.fixed1.Add(this.label3);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
		w3.X = 10;
		w3.Y = 10;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.left_border = new global::Gtk.Entry();
		this.left_border.CanFocus = true;
		this.left_border.Name = "left_border";
		this.left_border.IsEditable = true;
		this.left_border.InvisibleChar = '•';
		this.fixed1.Add(this.left_border);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.left_border]));
		w4.X = 150;
		w4.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.right_border = new global::Gtk.Entry();
		this.right_border.CanFocus = true;
		this.right_border.Name = "right_border";
		this.right_border.IsEditable = true;
		this.right_border.InvisibleChar = '•';
		this.fixed1.Add(this.right_border);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.right_border]));
		w5.X = 150;
		w5.Y = 45;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.step_entry = new global::Gtk.Entry();
		this.step_entry.CanFocus = true;
		this.step_entry.Name = "step_entry";
		this.step_entry.IsEditable = true;
		this.step_entry.InvisibleChar = '•';
		this.fixed1.Add(this.step_entry);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.step_entry]));
		w6.X = 150;
		w6.Y = 85;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Calculate");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w7.X = 164;
		w7.Y = 260;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.result = new global::Gtk.TextView();
		this.result.WidthRequest = 370;
		this.result.HeightRequest = 125;
		this.result.CanFocus = true;
		this.result.Name = "result";
		this.result.Editable = false;
		this.GtkScrolledWindow.Add(this.result);
		this.fixed1.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
		w9.X = 9;
		w9.Y = 120;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 409;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.calc_clicked);
	}
}
