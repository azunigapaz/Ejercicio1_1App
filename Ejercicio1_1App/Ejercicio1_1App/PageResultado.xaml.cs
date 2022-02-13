using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_1App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]    
    public partial class PageResultado : ContentPage
    {
        int numeroUno, numeroDos, resultado;
        string textoResultado;
        public PageResultado(int numeroUnoCt, int numeroDosCt, int resultadoCt, string textoResultadoCt)
        {
            InitializeComponent();
            numeroUno = numeroUnoCt;
            numeroDos = numeroDosCt;
            resultado = resultadoCt;
            textoResultado = textoResultadoCt;

            rsNumeroUno.Text = "Primer numero: " + Convert.ToString(numeroUnoCt);
            rsNumeroDos.Text = "Segundo numero: " + Convert.ToString(numeroDosCt);
            rsResultado.Text = textoResultado + Convert.ToString(resultadoCt);
        }        
    }
}