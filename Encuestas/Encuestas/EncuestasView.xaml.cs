using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Encuestas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EncuestasView : ContentPage
	{
		public EncuestasView ()
		{
			InitializeComponent ();
            BotonMas.Clicked += BotonMas_Clicked;
            MessagingCenter.Subscribe<ContentPage, Encuesta>(this, Mensajes.EncuestaCompleta, (sender, args) => {
                Panel.Children.Add(new Label()
                {
                    Text = args.ToString()
                });
            });
        }

        private async void BotonMas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetallesEncuestaView());
        }
    }
}