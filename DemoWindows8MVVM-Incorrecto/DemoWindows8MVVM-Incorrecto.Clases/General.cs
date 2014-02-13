using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace DemoWindows8MVVM_Incorrecto.Clases
{
    public class General
    {
        #region Alternativa 2
        /// Alternativa 2
        public string MostrarMensaje(string nombre, string apellido, DateTime dtFechaNac)
        {           
            var proximoCumple = new DateTime(DateTime.Now.Year, dtFechaNac.Month, dtFechaNac.Day);
            var edad = (DateTime.Now.Subtract(dtFechaNac).Days) / 365;
            var faltan = proximoCumple.Subtract(DateTime.Now);
            string mensaje = string.Format("Su Nombre es: {0} {1} con {2} Años y tu Proximo Cumpleaños es: {3} Dias, {4} Horas y {5} Minutos", nombre, apellido, edad, faltan.Days, faltan.Hours, faltan.Minutes);
            return mensaje;
        }
     
        public void CambiarValores(TextBox txtNombre, TextBox txtApellido, DatePicker dpFechaNac)
        {
            txtNombre.Text = "Messi";
            txtApellido.Text = "Ronaldo";
            dpFechaNac.Date = DateTimeOffset.Now.AddYears(-27).AddDays(5);
        }
        #endregion

        #region Alternativa 3
        /// Alternativa 3    
        public void CambiarValores()
        {
            Nombre = "Messi";
            Apellido = "Ronaldo";
            FechaNacimiento = DateTimeOffset.Now.AddYears(-27).AddDays(5);
        }
       
        public string MostrarMensaje()
        {
            var proximoCumple = new DateTime(DateTime.Now.Year, FechaNacimiento.Month, FechaNacimiento.Day);
            var edad = (DateTime.Now.Subtract(FechaNacimiento.Date).Days) / 365;
            var faltan = proximoCumple.Subtract(DateTime.Now);
            string mensaje = string.Format("Su Nombre es: {0} {1} con {2} Años y tu Proximo Cumpleaños es: {3} Dias, {4} Horas y {5} Minutos", Nombre, Apellido, edad, faltan.Days, faltan.Hours, faltan.Minutes);
            return mensaje;
        }

        #endregion

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTimeOffset FechaNacimiento { get; set; }
    }
}
