using ProyectoConsultorio.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Infraestructura
{
    internal class Box : IInfraestructura
    {
        private Medico medicoDeTurno;
        private int numeroBox;
        private int capacidadPersonasMax;
        private int PersonasActuales = 0;

        public int CapacidadPersonasMax { get => capacidadPersonasMax; set => capacidadPersonasMax = value; }
        public Medico MedicoDeTurno { get => medicoDeTurno; set => medicoDeTurno = value; }
        public int NumeroBox { get => numeroBox; set => numeroBox = value; }

        public void CambiodeTurno(Medico medico)
        {
            medicoDeTurno = medico;
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
