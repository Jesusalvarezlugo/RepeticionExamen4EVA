using RepeticionExamen4EVA.Dtos;
using RepeticionExamen4EVA.Servicios;
using RepeticionExamen4EVA.Util;

namespace RepeticionExamen4EVA.Controladores
{
    class Program
    {
        public static string rutaCarpetaLog = "C:\\Users\\Jesús\\source\\repos\\RepeticionExamen4EVA\\Logs\\";
        public static string rutaFcihero = String.Concat(rutaCarpetaLog,Utilidades.nombreFichero());
        public static List<CitaDto> listaCitas = new List<CitaDto>();
        public static void Main(string[] args)
        {
            FicheroInterfaz fi = new FicheroImplementacion();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcion;
            bool cerrarMenu = false;
            fi.leerFicheros();

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccionPrin();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Salir de la aplicacion");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Registro de llegada.");
                        oi.registroDeLlegada();
                        break;

                    case 2:
                        Console.WriteLine("Listado de consultas");
                        oi.menuListados();
                        break;
                }
            }
        }
    }
}
