using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeticionExamen4EVA.Dtos
{
    internal class CitaDto
    {
        string dniPaciente = "aaaaa";
        string nombrePaciente = "aaaaa";
        string apellidosPaciente = "aaaaa";
        string especialidad = "aaaaa";
        DateTime fechaCita = DateTime.Now;
        bool asistencia = false;

        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string ApellidosPaciente { get => apellidosPaciente; set => apellidosPaciente = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public bool Asistencia { get => asistencia; set => asistencia = value; }
    }
}
