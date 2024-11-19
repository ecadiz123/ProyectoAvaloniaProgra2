using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class Medico : Persona
    {
        int box;
        List<DateTime> horasagendadas = new List<DateTime>();
        List<Paciente> pacientes = new List<Paciente>();

        public int Box { get => box; set => box = value; }

        void AgregarPaciente(Paciente pas,DateTime fecha)
        {
            horasagendadas.Add(fecha);
            pacientes.Add(pas);
        }
        void EliminarPaciente()
        {
            //
        }
    }
}
