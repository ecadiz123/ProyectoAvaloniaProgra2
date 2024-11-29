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
        private relacion_t relacion;

        public relacion_t Relacion { get => relacion; set => relacion = value; }

       
    }
}
