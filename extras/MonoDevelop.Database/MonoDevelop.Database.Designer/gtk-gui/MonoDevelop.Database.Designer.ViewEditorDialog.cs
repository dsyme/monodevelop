
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Database.Designer
{
	public partial class ViewEditorDialog
	{
		private global::Gtk.VBox vboxContent;

		private global::Gtk.HBox hboxName;

		private global::Gtk.Label label7;

		private global::Gtk.Entry entryName;

		private global::Gtk.HBox hboxWarning;

		private global::Gtk.Image imageWarning;

		private global::Gtk.Label labelWarning;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Database.Designer.ViewEditorDialog
			this.Name = "MonoDevelop.Database.Designer.ViewEditorDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Database.Designer.ViewEditorDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vboxContent = new global::Gtk.VBox ();
			this.vboxContent.Name = "vboxContent";
			this.vboxContent.Spacing = 6;
			this.vboxContent.BorderWidth = ((uint)(6));
			// Container child vboxContent.Gtk.Box+BoxChild
			this.hboxName = new global::Gtk.HBox ();
			this.hboxName.Name = "hboxName";
			this.hboxName.Spacing = 6;
			// Container child hboxName.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("Name");
			this.hboxName.Add (this.label7);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxName[this.label7]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hboxName.Gtk.Box+BoxChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.hboxName.Add (this.entryName);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxName[this.entryName]));
			w3.Position = 1;
			this.vboxContent.Add (this.hboxName);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxContent[this.hboxName]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vboxContent.Gtk.Box+BoxChild
			this.hboxWarning = new global::Gtk.HBox ();
			this.hboxWarning.Name = "hboxWarning";
			this.hboxWarning.Spacing = 6;
			// Container child hboxWarning.Gtk.Box+BoxChild
			this.imageWarning = new global::Gtk.Image ();
			this.imageWarning.Name = "imageWarning";
			this.imageWarning.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-warning", global::Gtk.IconSize.Menu);
			this.hboxWarning.Add (this.imageWarning);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hboxWarning[this.imageWarning]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hboxWarning.Gtk.Box+BoxChild
			this.labelWarning = new global::Gtk.Label ();
			this.labelWarning.Name = "labelWarning";
			this.labelWarning.Xalign = 0f;
			this.hboxWarning.Add (this.labelWarning);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxWarning[this.labelWarning]));
			w6.Position = 1;
			this.vboxContent.Add (this.hboxWarning);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxContent[this.hboxWarning]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			w1.Add (this.vboxContent);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(w1[this.vboxContent]));
			w8.Position = 0;
			// Internal child MonoDevelop.Database.Designer.ViewEditorDialog.ActionArea
			global::Gtk.HButtonBox w9 = this.ActionArea;
			w9.Name = "dialog1_ActionArea";
			w9.Spacing = 6;
			w9.BorderWidth = ((uint)(5));
			w9.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonCancel]));
			w10.Expand = false;
			w10.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.Sensitive = false;
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w11 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w9[this.buttonOk]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 640;
			this.DefaultHeight = 480;
			this.Show ();
			this.entryName.Changed += new global::System.EventHandler (this.NameChanged);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.CancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OkClicked);
		}
	}
}
