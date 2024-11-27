using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    public enum relacion_t
    {
        PADRE,
        MADRE,
        HIJO,
        HIJA,
        OTRO
    }
    public class Tutor : Persona
    {
        public relacion_t relacion;
        public Paciente paciente;
        Tutor(relacion_t relacion, Paciente paciente)
        {
            this.relacion = relacion;
            this.paciente = paciente;
        }
        public relacion_t Getrelacion() { return relacion; }
        public Paciente GetPaciente() { return paciente; }
    }
}
