using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen4EVA.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccionPrin()
        {
            int opcion;
            Console.WriteLine("#########################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Listado de consultas");
            Console.WriteLine("#########################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
        public int mostrarMenuYSeleccionEsp()
        {
            int opcion;
            Console.WriteLine("#########################");
            Console.WriteLine("0. Salir de la aplicacion");
            Console.WriteLine("1. Mostrar consultas");
            Console.WriteLine("2. Imprimir consultas");
            Console.WriteLine("#########################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionList()
        {
            int opcion;
            Console.WriteLine("#########################");
            Console.WriteLine("1. Psicologia");
            Console.WriteLine("2. Traumatologia");
            Console.WriteLine("3. Fisioterapia");
            Console.WriteLine("#########################");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        
    }
}
