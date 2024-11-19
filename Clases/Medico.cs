using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class Medico : Persona
    {
        private int box;
        private List<DateTime> horasagendadas = new List<DateTime>();
        private List<Paciente> pacientes = new List<Paciente>();

        public int Box { get => box; set => box = value; }

        public void AgregarPaciente(Paciente pas,DateTime fecha)
        {
            horasagendadas.Add(fecha);
            pacientes.Add(pas);
        }
        public void EliminarPaciente()
        {
            //
        }
    }
}
