using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class Paciente
    {
        string motivoconsulta = string.Empty;
        bool tutor;
        DateTime fechaatencion;

        public string Motivoconsulta { get => motivoconsulta; set => motivoconsulta = value; }
        public bool Tutor { get => tutor; set => tutor = value; }
        public DateTime Fechaatencion { get => fechaatencion; set => fechaatencion = value; }
    }
}
