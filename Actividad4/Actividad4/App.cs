using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			//Se crea un objeto etiqueta usando Inicializador de Objetos
			Label label = new Label {
			//Se le asigna su valor, en este caso el texto Cámbiame
				Text = "Cámbiame",			
			//Se le cambia el Color al texto seleccionamos color verde
			TextColor = Color.Green,
			//Se alinea el texto verticalmente (YAlign)
				YAlign = TextAlignment.Center,
			//Se alinea el texto horizontalmente (XAlign)
			XAlign = TextAlignment.Center };
			

			//Se crea una página y se le asigna como contenido la eqtiqueta que se creó
			ContentPage contentPage = new ContentPage();
			contentPage.Content = label;

			return contentPage;
		}
	}
}

