using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo_JADM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        double area;
        private void Button_Clicked(object sender, EventArgs e)
        {
            var lado1 = double.Parse(Lado1.Text);
            var lado2 = double.Parse(Lado2.Text);
            var altura = double.Parse(Altura.Text);
            var baseT = double.Parse(BaseT.Text);
            var area = (baseT * altura) / 2;

            Area.Text = area.ToString();

            string resultado = "";

            if (lado1 <= 0 || lado2 <= 0 || baseT <= 0)
            {
                resultado = "El triángulo no existe";
            }
            else if (lado1 + lado2 < baseT || lado1 + baseT < lado2 || lado2 + baseT < lado1)
            {
                resultado = "El triángulo no existe ";
            }
            else if (lado1 == lado2 && lado2 == baseT)
            {
                resultado = "El triángulo es Equilátero";
                equilatero.IsVisible = true;
                escaleno.IsVisible = false;
                isoceles.IsVisible = false; 
            }
            else if (lado1 == lado2 || lado2 == baseT || lado1 == baseT)
            {
                resultado = "El triángulo es Isósceles";
                isoceles.IsVisible = true;
                equilatero.IsVisible = false;
                escaleno.IsVisible = false;


            }
            else
            {
                resultado = "El triángulo es Escaleno";
                escaleno.IsVisible = true;
                isoceles.IsVisible = false;
                equilatero.IsVisible = false;
            }

            DisplayAlert("Resultado", resultado, "Ok");
        }
        private void Areas(double baseT, double altura)
        {
            area = (baseT * altura) / 2;
        }

    }
}
