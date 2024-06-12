using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen4EVA.Util
{
    internal class Utilidades
    {
        public static string nombreFichero()
        {
            DateTime fechaActual=DateTime.Now;

            string nombreFichero = String.Concat("log-",fechaActual.ToString("ddMMyyyy"),".txt");

            return nombreFichero;
        }
    }
}
