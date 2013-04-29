using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int puntos=0;
		if(this.radiobutton3.Active)
			puntos ++;
		
		if(this.spinbutton1.Text=="4")
			puntos++;
		
		if(this.checkbutton1.Active)
			puntos++;
		
		if(this.checkbutton2.Active)
			puntos++;
		
		DateTime Fecha =this.calendar1.GetDate();
		string fechaSeleccionada = Fecha.ToShortDateString();
		if ( fechaSeleccionada=="16/04/2013")
			puntos++;
		this.entry3.Text= puntos.ToString();
	}
}

	

