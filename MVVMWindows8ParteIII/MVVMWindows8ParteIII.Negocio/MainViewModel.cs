using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVMWindows8ParteIII.Negocio
{
    public class MainViewModel : BaseViewModel
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                RaisePropertyChanged("Nombre");
                RetornarMensajeCumpleanio();
            }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                RaisePropertyChanged("Apellido");
                RetornarMensajeCumpleanio();
            }
        }
        private DateTimeOffset fechaNacimiento;

        public DateTimeOffset FechaNacimiento
        {
            get { return fechaNacimiento; }
            set
            {
                fechaNacimiento = value;
                RaisePropertyChanged("FechaNaciemiento");
                RetornarMensajeCumpleanio();
            }
        }
        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set
            {
                mensaje = value;
                RaisePropertyChanged("Mensaje");
            }
        }

        #region Metodos
        public void RetornarMensajeCumpleanio()
        {
            int diaCumple = FechaNacimiento.Day;//Dia del Cumpleanios
            int mesCumple = FechaNacimiento.Month;//Mes de Cumple 4=Abril
            int anioCumple = FechaNacimiento.Year; //Anio de Cumple

            //Se calcula la Edad Actual A partir de la fecha actual Sustrayendo la fecha de nacimiento

            //esto devuelve un TimeSpan por tanto tomaremos los Dias y lo dividimos en 365 dias
            int edad = (DateTime.Now.Subtract(FechaNacimiento.Date).Days / 365);

            DateTime proximoCumple;
            //Define el proximo Cumple, En caso de que el mes sea menor al Mes Actual se busca el Proxima 
            //fecha que seria del año que viene
            //es por ello el AddYear(1)
            //En caso de ser mayor se toma el año actual
            if (DateTime.Now.Month >= mesCumple )
                proximoCumple = new DateTime(DateTime.Now.AddYears(1).Year, mesCumple, diaCumple);
            else
                proximoCumple = new DateTime(DateTime.Now.Year, mesCumple, diaCumple);

            //Definiremos los dias faltantes para el proximo cumple
            TimeSpan faltan = proximoCumple.Subtract(DateTime.Now);

            //Ahora Elaboramos el Mensaje
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0} {1} ", Nombre, Apellido);
            sb.AppendFormat("Usted Tiene {0} Años ", edad);
            sb.AppendFormat("y tu Proximo Cumpleaños es: {0} Dias", faltan.Days);
            sb.AppendFormat(", {0} Horas ", faltan.Hours);
            sb.AppendFormat("y {0} Minutos ", faltan.Minutes);

            Mensaje = sb.ToString();
        }
        #endregion

    }
}
