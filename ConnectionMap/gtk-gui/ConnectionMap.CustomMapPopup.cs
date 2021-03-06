
// This file has been generated by the GUI designer. Do not modify.
namespace ConnectionMap
{
	public partial class CustomMapPopup
	{
		private global::Gtk.HBox hbox11;
		
		private global::Gtk.VBox vbox21;
		
		private global::Gtk.Label label23;
		
		private global::Gtk.ColorSelection colorselection24;
		
		private global::Gtk.Label label25;
		
		private global::Gtk.ColorSelection colorselection26;
		
		private global::Gtk.VBox vbox20;
		
		private global::Gtk.Label label24;
		
		private global::Gtk.ColorSelection colorselection25;
		
		private global::Gtk.Label label26;
		
		private global::Gtk.ColorSelection colorselection27;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.CheckButton save_box;
		
		private global::Gtk.Button button4;
		
		private global::Gtk.Button button3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ConnectionMap.CustomMapPopup
			this.Name = "ConnectionMap.CustomMapPopup";
			this.Title = global::Mono.Unix.Catalog.GetString ("CustomMapPopup");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ConnectionMap.CustomMapPopup.Gtk.Container+ContainerChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vbox21 = new global::Gtk.VBox ();
			this.vbox21.Name = "vbox21";
			this.vbox21.Spacing = 6;
			// Container child vbox21.Gtk.Box+BoxChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("Countries");
			this.vbox21.Add (this.label23);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox21 [this.label23]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox21.Gtk.Box+BoxChild
			this.colorselection24 = new global::Gtk.ColorSelection ();
			this.colorselection24.Name = "colorselection24";
			this.colorselection24.HasOpacityControl = true;
			this.vbox21.Add (this.colorselection24);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox21 [this.colorselection24]));
			w2.Position = 1;
			// Container child vbox21.Gtk.Box+BoxChild
			this.label25 = new global::Gtk.Label ();
			this.label25.Name = "label25";
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString ("Country Label");
			this.vbox21.Add (this.label25);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox21 [this.label25]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox21.Gtk.Box+BoxChild
			this.colorselection26 = new global::Gtk.ColorSelection ();
			this.colorselection26.Name = "colorselection26";
			this.colorselection26.HasOpacityControl = true;
			this.vbox21.Add (this.colorselection26);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox21 [this.colorselection26]));
			w4.Position = 3;
			this.hbox11.Add (this.vbox21);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.vbox21]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vbox20 = new global::Gtk.VBox ();
			this.vbox20.Name = "vbox20";
			this.vbox20.Spacing = 6;
			// Container child vbox20.Gtk.Box+BoxChild
			this.label24 = new global::Gtk.Label ();
			this.label24.Name = "label24";
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString ("Water");
			this.vbox20.Add (this.label24);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox20 [this.label24]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox20.Gtk.Box+BoxChild
			this.colorselection25 = new global::Gtk.ColorSelection ();
			this.colorselection25.Name = "colorselection25";
			this.colorselection25.HasOpacityControl = true;
			this.vbox20.Add (this.colorselection25);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox20 [this.colorselection25]));
			w7.Position = 1;
			// Container child vbox20.Gtk.Box+BoxChild
			this.label26 = new global::Gtk.Label ();
			this.label26.Name = "label26";
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString ("Water Label");
			this.vbox20.Add (this.label26);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox20 [this.label26]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox20.Gtk.Box+BoxChild
			this.colorselection27 = new global::Gtk.ColorSelection ();
			this.colorselection27.Name = "colorselection27";
			this.colorselection27.HasOpacityControl = true;
			this.vbox20.Add (this.colorselection27);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox20 [this.colorselection27]));
			w9.Position = 3;
			// Container child vbox20.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.save_box = new global::Gtk.CheckButton ();
			this.save_box.WidthRequest = 15;
			this.save_box.CanFocus = true;
			this.save_box.Name = "save_box";
			this.save_box.Label = global::Mono.Unix.Catalog.GetString ("Save Map");
			this.save_box.DrawIndicator = true;
			this.save_box.UseUnderline = true;
			this.hbox1.Add (this.save_box);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.save_box]));
			w10.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button ();
			this.button4.WidthRequest = 50;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString ("Done");
			this.hbox1.Add (this.button4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button4]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
			this.hbox1.Add (this.button3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button3]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox20.Add (this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox20 [this.hbox1]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			this.hbox11.Add (this.vbox20);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.vbox20]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.Add (this.hbox11);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1022;
			this.DefaultHeight = 566;
			this.Show ();
			this.save_box.Toggled += new global::System.EventHandler (this.save_toggled);
			this.button4.Clicked += new global::System.EventHandler (this.done_click);
			this.button3.Clicked += new global::System.EventHandler (this.cancel_click);
		}
	}
}
