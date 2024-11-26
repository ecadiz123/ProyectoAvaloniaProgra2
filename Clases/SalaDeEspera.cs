using ProyectoConsultorio.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class SalaDeEspera : IInfraestructura
    {
        private List<Seguridad> seguridadDeTurno;
        private int capacidadPersonasMax;
        private int PersonasActuales = 0;

        public int CapacidadPersonasMax { get => capacidadPersonasMax; set => capacidadPersonasMax = value; }
        internal List<Seguridad> SeguridaDeTurno { get => seguridadDeTurno; set => seguridadDeTurno = value; }
        public void CambiodeTurno(List<Seguridad> seguridad)
        {
            seguridadDeTurno = seguridad;            
        }
        public void AddPersonaActual(int c)
        {
            PersonasActuales += c;
        }
        public void EliminarPersonaActual(int c)
        {
            PersonasActuales -= c;
        }
    }
}
