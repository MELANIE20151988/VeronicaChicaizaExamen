
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VeronicaChicaizaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string monto)
        {
            InitializeComponent();
            string usuar = lbUsuarioResumen.Text;
            lbUsuarioResumen.Text = usuar + usuario;
            txtnombre.Text = nombre;
            txtMonto.Text = monto;



        }
    }
}