using RepeticionExamen4EVA.Controladores;
using RepeticionExamen4EVA.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen4EVA.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        

        public void registroDeLlegada()
        {
            string dniAPedir;
            Console.WriteLine("Introduzca su dni");
            dniAPedir = Console.ReadLine();
            DateTime fechaActual= DateTime.Now;
            bool aux = false;
            while (validarDni(dniAPedir))
            {
                Console.WriteLine("[ERROR] dni no valido, introduzca un dni valido");
                dniAPedir=Console.ReadLine();
            }

            foreach(CitaDto cita in Program.listaCitas)
            {
                if (cita.FechaCita.ToString("dd-MM-yyyy")==fechaActual.ToString("dd-MM-yyyy")&&dniAPedir==cita.DniPaciente)
                {
                    Console.WriteLine(String.Concat("Espere su turno para la consulta de",cita.Especialidad)," en la sala de espera. su especialista le avisara.");
                    aux= true;
                    break;
                }
            }

            if (aux == false)
            {
                Console.WriteLine("No dispone de cita previa para hoy");
            }
           
               
            

        }

        private bool validarDni(string dni)
        {
            string letraDni=dni.Substring(dni.Length-1);
            int numDni =Int32.Parse(dni.Substring(0,dni.Length-1));
            string[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            return letraDni != letras[numDni % 23];
            
        }

        public void menuListados()
        {
            int opcion;
            MenuInterfaz mi = new MenuImplementacion();
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccionList();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Volver al menu principal");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Mostrar consultas.");
                        mostrarConsultas();
                        
                        break;

                    case 2:
                       Console.WriteLine("Imprimir consultas.");
                        imprimirConsultas();
                        break;
                }
            }
        }

        private string menuEspecialidad()
        {
            int opcion;
            MenuInterfaz mi =new  MenuImplementacion();
            CitaDto cita = new CitaDto();
            opcion = mi.mostrarMenuYSeleccionEsp();
            string especialidad="";

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Psicologia");
                    especialidad = "Psicologia";
                    break;

                case 2:
                    Console.WriteLine("Traumatologia");
                    especialidad = "Traumatologia";
                    break;

                case 3:
                    Console.WriteLine("Fisioterapia");
                    especialidad = "Fisioterapia";
                    break;
            }

            return especialidad;
        }

        private void mostrarConsultas()
        {
            string especialidadAPedir=menuEspecialidad();
            DateTime fechaAPedir;
            Console.WriteLine("Introduzca la fecha  que desea mostrar las citas:(dd-MM-yyyy) ");
            fechaAPedir = Convert.ToDateTime(Console.ReadLine());
            bool aux=false;

            foreach (CitaDto cita in Program.listaCitas)
            {
                if (fechaAPedir.ToString("dd-MM-yyyy") == cita.FechaCita.ToString("dd-MM-yyyy")&&especialidadAPedir==cita.Especialidad)
                {
                    Console.WriteLine(String.Concat("Nombre completo: ",cita.NombrePaciente," ",cita.ApellidosPaciente," Hora: ",cita.FechaCita.Hour));
                    aux= true;
                    break;
                }
            }

            if (aux == false)
            {
                Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
            }
        }

        private void imprimirConsultas()
        {
            FicheroInterfaz fi = new FicheroImplementacion();
            string especialidad = menuEspecialidad();
            DateTime fechaAPedir;
            
            Console.WriteLine("Introduzca la fecha que desea mostrar las citas: (dd-MM-yyyy)");
            
            fechaAPedir = Convert.ToDateTime(Console.ReadLine());

            String nombreFichero = String.Concat("CitasCONAsistencia-",fechaAPedir.ToString("dd-MM-yyyy"),".txt"); 
            bool aux = false;

            foreach(CitaDto cita in Program.listaCitas)
            {
                if (fechaAPedir.ToString("dd-MM-yyyy") == cita.FechaCita.ToString("dd-MM-yyyy") && especialidad == cita.Especialidad && cita.Asistencia == true)
                {
                    fi.escribirEnFichero(nombreFichero);
                }
            }
        }


    }
}
