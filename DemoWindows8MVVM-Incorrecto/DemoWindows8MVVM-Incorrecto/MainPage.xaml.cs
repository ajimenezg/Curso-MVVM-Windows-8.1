using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using DemoWindows8MVVM_Incorrecto.Clases;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoWindows8MVVM_Incorrecto
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            ////Alternativa Por defecto
            //var dtFechaNac = dpFechaNac.Date.Date;
            //var proximoCumple = new DateTime(DateTime.Now.Year, dtFechaNac.Month, dtFechaNac.Day);
            //var edad = (DateTime.Now.Subtract(dtFechaNac).Days) / 365;
            //var faltan = proximoCumple.Subtract(DateTime.Now);
            //txtMensaje.Text = string.Format("Su Nombre es: {0} {1} con {2} Años y tu Proximo Cumpleaños es: {3} Dias, {4} Horas y {5} Minutos"
            //    , txtNombre.Text, txtApellido.Text, edad, faltan.Days, faltan.Hours, faltan.Minutes);

            

            ////Alternativa 2
            //General obj = new General();
            //txtMensaje.Text = obj.MostrarMensaje(txtNombre.Text, txtApellido.Text, dpFechaNac.Date.Date);

            //Alternativa 3
            General obj = new General();
            obj.Nombre = txtNombre.Text;
            obj.Apellido = txtApellido.Text;
            obj.FechaNacimiento = dpFechaNac.Date;
            txtMensaje.Text = obj.MostrarMensaje();
        }

        private void txtApellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Alternativa Por defecto
            var dtFechaNac = dpFechaNac.Date.Date;
            var proximoCumple = new DateTime(DateTime.Now.Year, dtFechaNac.Month, dtFechaNac.Day);
            var edad = (DateTime.Now.Subtract(dtFechaNac).Days) / 365;
            var faltan = proximoCumple.Subtract(DateTime.Now);
            txtMensaje.Text = string.Format("Su Nombre es: {0} {1} con {2} Años y tu Proximo Cumpleaños es: {3} Dias, {4} Horas y {5} Minutos"
                , txtNombre.Text, txtApellido.Text, edad, faltan.Days, faltan.Hours, faltan.Minutes);


            ////Alternativa 2
            //General obj = new General();
            //txtMensaje.Text = obj.MostrarMensaje(txtNombre.Text, txtApellido.Text, dpFechaNac.Date.Date);

            ////Alternativa 3
            // General obj = new General();
            // obj.Nombre = txtNombre.Text ;
            // obj.Apellido = txtApellido.Text;
            // obj.FechaNacimiento = dpFechaNac.Date;
            //  txtMensaje.Text = obj.MostrarMensaje();
        }

        private void dpFechaNac_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            //Alternativa Por defecto
            var dtFechaNac = dpFechaNac.Date.Date;
            var proximoCumple = new DateTime(DateTime.Now.Year, dtFechaNac.Month, dtFechaNac.Day);
            var edad = (DateTime.Now.Subtract(dtFechaNac).Days) / 365;
            var faltan = proximoCumple.Subtract(DateTime.Now);
            txtMensaje.Text = string.Format("Su Nombre es: {0} {1} con {2} Años y tu Proximo Cumpleaños es: {3} Dias, {4} Horas y {5} Minutos"
                , txtNombre.Text, txtApellido.Text, edad, faltan.Days, faltan.Hours, faltan.Minutes);


            ////Alternativa 2
            //General obj = new General();
            //txtMensaje.Text = obj.MostrarMensaje(txtNombre.Text, txtApellido.Text, dpFechaNac.Date.Date);

            ////Alternativa 3
            // General obj = new General();
            // obj.Nombre = txtNombre.Text ;
            // obj.Apellido = txtApellido.Text;
            // obj.FechaNacimiento = dpFechaNac.Date;
            //  txtMensaje.Text = obj.MostrarMensaje();

        }

        private void btnCambiarValores_Click(object sender, RoutedEventArgs e)
        {
            ////Alternativa Por defecto
            //txtNombre.Text = "Messi";
            //txtApellido.Text = "Ronaldo";

            //Alternativa 2
           // General obj = new General();
           // obj.CambiarValores(txtNombre, txtApellido, dpFechaNac);

            //Alternativa 3
            General obj = new General();
            obj.CambiarValores();
            txtNombre.Text = obj.Nombre;
            txtApellido.Text = obj.Apellido;
            dpFechaNac.Date = obj.FechaNacimiento;
        }
    }
}
