using System;
using Xamarin.Forms;

namespace VeronicaChicaizaExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void butnIngreso_Clicked(object sender, EventArgs e)
        {
            Login user = new Login(txtUsuario.Text, txtPass.Text);

            if (user.Informacion())
            {
                DisplayAlert("Ingreso", "Ingreso Correcto", "ok");



            }
            else
            {
                DisplayAlert("Ingreso", "Ingreso Iconrrecto", "ok");
            }

        }

        private async void butnRegistro_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            await Navigation.PushAsync(new Registro(usuario));
        }
    }
}
