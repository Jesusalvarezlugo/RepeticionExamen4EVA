using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen4EVA.Servicios
{
    internal interface FicheroInterfaz
    {
        public void escribirFicheroLog(string texto);

        public void leerFicheros();

        

        public void escribirEnFichero(string ruta);
    }
}
