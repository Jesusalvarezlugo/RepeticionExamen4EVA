using RepeticionExamen4EVA.Dtos;
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
            
        }
    }
}
