using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen_DM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var latidos = double.Parse(Latidos.Text);
            var latidosTotales = latidos * 4;

            string resultado = " ";
            if (latidosTotales < 60)
            {
                resultado = "FC baja";
                crisis.IsVisible = true;
                comprobar.IsVisible = false;
                
            }
            else if (60>latidosTotales || latidosTotales<100)
            {
                resultado = "FC Normal";
                crisis.IsVisible = false;
                comprobar.IsVisible = true;
            }
            else if (latidosTotales > 100)
            {
                resultado = "FC Alta";
                crisis.IsVisible = true;
                comprobar.IsVisible = false;
            }
            DisplayAlert("Resultado",resultado,"Quita");
        }
    }
}
