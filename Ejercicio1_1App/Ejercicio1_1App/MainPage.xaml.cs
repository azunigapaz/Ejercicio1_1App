using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnSuma_Clicked(object sender, EventArgs e) {
            /*
            var Operacion = new Models.Operaciones
            {
                OperacionNumeroUno = Convert.ToInt32(txtNumeroUno.Text),
                OperacionNumeroDos = Convert.ToInt32(txtNumeroDos.Text),
                OperacionResultado = Convert.ToInt32(txtNumeroUno.Text) + Convert.ToInt32(txtNumeroDos.Text)

            };

            var openPaginaResultado = new PageResultado();
            openPaginaResultado.BindingContext = Operacion;
            await Navigation.PushAsync(openPaginaResultado);
            */

            try
            {
                var numeroUno = Convert.ToInt32(txtNumeroUno.Text);
                var numeroDos = Convert.ToInt32(txtNumeroDos.Text);
                var resultado = numeroUno + numeroDos;

                if (resultado != 0)
                {
                    var openPaginaResultado = new PageResultado(numeroUno, numeroDos, resultado, "El resultado de la suma es: ");
                    await Navigation.PushAsync(openPaginaResultado);
                }
                else
                {
                    await DisplayAlert("Mensaje", "Debe ingresar un numero", "Cancelar");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje", ex.Message, "Aceptar");
            }
        }

        async void btnResta_Clicked(object sender, EventArgs e)
        {
            try
            {
                var numeroUno = Convert.ToInt32(txtNumeroUno.Text);
                var numeroDos = Convert.ToInt32(txtNumeroDos.Text);
                var resultado = numeroUno - numeroDos;

                if (resultado != 0)
                {
                    var openPaginaResultado = new PageResultado(numeroUno, numeroDos, resultado, "El resultado de la resta es: ");
                    await Navigation.PushAsync(openPaginaResultado);
                }
                else
                {
                    await DisplayAlert("Mensaje", "Debe ingresar un numero", "Cancelar");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje", ex.Message, "Aceptar");
            }
        }

        async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var numeroUno = Convert.ToInt32(txtNumeroUno.Text);
                var numeroDos = Convert.ToInt32(txtNumeroDos.Text);
                var resultado = numeroUno * numeroDos;

                if (resultado != 0)
                {
                    var openPaginaResultado = new PageResultado(numeroUno, numeroDos, resultado, "El resultado de la multiplicacion es: ");
                    await Navigation.PushAsync(openPaginaResultado);
                }
                else
                {
                    await DisplayAlert("Mensaje", "Debe ingresar un numero", "Cancelar");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje", ex.Message, "Aceptar");
            }
        }

        async void btnDividir_Clicked(object sender, EventArgs e)
        {
            try
            {
                var numeroUno = Convert.ToInt32(txtNumeroUno.Text);
                var numeroDos = Convert.ToInt32(txtNumeroDos.Text);
                var resultado = numeroUno / numeroDos;

                if (resultado != 0)
                {
                    var openPaginaResultado = new PageResultado(numeroUno, numeroDos, resultado, "El resultado de la division es: ");
                    await Navigation.PushAsync(openPaginaResultado);
                }
                else
                {
                    await DisplayAlert("Mensaje", "No es posible dividir", "Aceptar");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Mensaje", ex.Message, "Aceptar");
            }
        }
    }
}
