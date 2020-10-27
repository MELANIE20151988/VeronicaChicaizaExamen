using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VeronicaChicaizaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private object lbnombre;

        public Registro(string usuario)
        {
            InitializeComponent();
            string usuar = lbUsuario.Text;
            lbUsuario.Text = usuar + usuario;
        }

        private async void btnguardar_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text))
            {

                DisplayAlert("Ingreso", "Ingreso Iconrrecto", "ok");
            }

            else
            {
                DisplayAlert("Guardar", "Elemento Guardado con exito", "ok");
                string usuario = lbUsuario.Text;
                string nombre = txtNombre.Text;
                string monto = txtPagoR.Text;
                await Navigation.PushAsync(new Resumen(usuario, nombre, monto));

            }



        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {



            int montos = int.Parse(txtMontoInicial.Text);

            if (montos != 1800)
            {
                var pagomensual = 1800 - montos;
                var restocu = pagomensual / 3;
                var porcentaje = restocu * 0.05;
                var total = restocu + porcentaje;
                txtMensual.Text = (total).ToString();
                txtPagoR.Text = (total * 3).ToString();

            }
            else
                txtPagoR.Text = "0";
        }
    }
}