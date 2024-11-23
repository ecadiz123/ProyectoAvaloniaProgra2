using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class Paciente : Persona
    {
        private string motivoConsulta = string.Empty;
        private bool tieneTutor;
        private DateTime fechaatencion;

        public string MotivoConsulta { get => motivoConsulta; set => motivoConsulta = value; }
        public bool TieneTutor { get => tieneTutor; set => tieneTutor = value; }
        public DateTime Fechaatencion { get => fechaatencion; set => fechaatencion = value; }
    }
}
