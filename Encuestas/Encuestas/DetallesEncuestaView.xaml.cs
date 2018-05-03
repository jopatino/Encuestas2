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
	public partial class DetallesEncuestaView : ContentPage
	{
        private readonly string[] equipos = {"Colombia", "Perú", "Brasil", "Rusia", "Argentina", "España" };

 		public DetallesEncuestaView ()
		{
			InitializeComponent ();
            BtAgregarEq.Clicked += BtAgregarEq_Clicked;
            BtAceptar.Clicked += BtAceptar_Clicked;
            
           
		}

        private async void BtAceptar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntNombre.Text) || string.IsNullOrEmpty(LbEquipoFav.Text))
            {
                await DisplayAlert("Datos incompletos", "Recuerde que debe ingresar todos los datos", "Aceptar");
                return;
            }
            var enc = new Encuesta()
            {
                Nombre = EntNombre.Text,
                EquipoFavorito = LbEquipoFav.Text,
                FechaNacimiento = DtNac.Date

            };
            MessagingCenter.Send((ContentPage)this, Mensajes.EncuestaCompleta, enc);
            await Navigation.PopAsync();
        }

        private async void BtAgregarEq_Clicked(object sender, EventArgs e)
        {
            var equipoFavorito = await DisplayActionSheet(Literales.TituloEqFav, null, null, equipos);

            if (!string.IsNullOrEmpty(equipoFavorito))
            {
                LbEquipoFav.Text = equipoFavorito;
            }
        }
    }
}