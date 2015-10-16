using System;
using Xamarin.Forms;

namespace Actividad8
{
	public class Contenido: ContentPage
	{
		public Contenido ()
		{
			Label texto = new Label {
				Text = "Usuario y Pasword Validos",
				TextColor = Color.Green
			};
			StackLayout stackLayout = new StackLayout {
				Children = {
					texto
				}
			};
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

