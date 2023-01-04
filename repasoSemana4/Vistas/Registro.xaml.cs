using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repasoSemana4.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                double valor = precio * cantidad;
                DisplayAlert("VALOR TOTAL DEL PRODUCTO", valor.ToString(), "Cancelar");
            } catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");

            }

        }
    }
}