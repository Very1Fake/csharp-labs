
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed3;

	private global::Gtk.Label time;

	private global::Gtk.Entry login;

	private global::Gtk.Entry password;

	private global::Gtk.Label label6;

	private global::Gtk.Label label5;

	private global::Gtk.Label status;

	private global::Gtk.Button auth;

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
		this.time = new global::Gtk.Label();
		this.time.Name = "time";
		this.time.LabelProp = global::Mono.Unix.Catalog.GetString("Remaining time: ");
		this.fixed3.Add(this.time);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.time]));
		w1.X = 22;
		w1.Y = 15;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.login = new global::Gtk.Entry();
		this.login.CanFocus = true;
		this.login.Name = "login";
		this.login.IsEditable = true;
		this.login.ActivatesDefault = true;
		this.login.InvisibleChar = '•';
		this.fixed3.Add(this.login);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.login]));
		w2.X = 96;
		w2.Y = 71;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.password = new global::Gtk.Entry();
		this.password.CanFocus = true;
		this.password.Name = "password";
		this.password.IsEditable = true;
		this.password.Visibility = false;
		this.password.InvisibleChar = '•';
		this.fixed3.Add(this.password);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.password]));
		w3.X = 96;
		w3.Y = 105;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Password");
		this.fixed3.Add(this.label6);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label6]));
		w4.X = 23;
		w4.Y = 110;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Login");
		this.fixed3.Add(this.label5);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.label5]));
		w5.X = 52;
		w5.Y = 77;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.status = new global::Gtk.Label();
		this.status.Name = "status";
		this.status.LabelProp = "";
		this.fixed3.Add(this.status);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.status]));
		w6.X = 33;
		w6.Y = 172;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.auth = new global::Gtk.Button();
		this.auth.CanFocus = true;
		this.auth.Name = "auth";
		this.auth.UseUnderline = true;
		this.auth.Label = global::Mono.Unix.Catalog.GetString("Sign In");
		this.fixed3.Add(this.auth);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed3[this.auth]));
		w7.X = 290;
		w7.Y = 159;
		this.Add(this.fixed3);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 359;
		this.DefaultHeight = 207;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.auth.Clicked += new global::System.EventHandler(this.click);
	}
}