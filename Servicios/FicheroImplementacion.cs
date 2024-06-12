using RepeticionExamen4EVA.Controladores;
using RepeticionExamen4EVA.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen4EVA.Servicios
{
    internal class FicheroImplementacion:FicheroInterfaz
    {
        public void escribirFicheroLog(string texto)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Program.rutaFcihero);

                sw.WriteLine(texto);

                sw.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error al escribir en el fichero");
            }
            
        }

        public void leerFicheros()
        {
            try
            {
                string[] lineas = File.ReadAllLines("cita.txt");

                foreach (string linea in lineas)
                {
                    string[] cita = linea.Split(";");
                    CitaDto cita1=new CitaDto();
                    cita1.DniPaciente = cita[0];
                    cita1.NombrePaciente= cita[1];
                    cita1.ApellidosPaciente = cita[2];
                    cita1.Especialidad = cita[3];
                    cita1.FechaCita = Convert.ToDateTime(cita[4]);
                    cita1.Asistencia = Convert.ToBoolean(cita[5]);
                    Program.listaCitas.Add(cita1);
                }


                    
                
            }
            catch(IOException)
            {

            }
            
        }
    }
}
