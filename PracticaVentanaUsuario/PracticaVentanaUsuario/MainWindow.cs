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

	protected void OnSalirClicked (object sender, System.EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnAceptaClicked (object sender, System.EventArgs e)
	{
		if (password.Text=="123456"&& usuario.Text=="ricardo")
		{
			MessageDialog hola = new MessageDialog(
				null,
				DialogFlags.Modal,
				MessageType.Info,
				ButtonsType.None,
				"Hola Bienvenido"
			);
			hola.Show();
		}
		
		else
		{
			MessageDialog error = new MessageDialog(
			
				null,
				DialogFlags.Modal,
				MessageType.Info,
				ButtonsType.None,
				"Error verifique password y/o Usuario"
			);
			error.Show();
		}
	}
}
