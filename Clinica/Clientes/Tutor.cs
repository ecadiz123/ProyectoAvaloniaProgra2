using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Clientes
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
        private relacion_t relacion;
        private Paciente paciente;
        public Tutor(relacion_t relacion, Paciente paciente) : base()
        {
            this.relacion = relacion;
            this.paciente = paciente;
        }
        public relacion_t Getrelacion() { return relacion; }
        public Paciente GetPaciente() { return paciente; }
    }
}
