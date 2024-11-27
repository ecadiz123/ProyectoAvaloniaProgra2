using ProyectoConsultorio.Clinica.TrabajadoresExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Infraestructura
{
    public class SalaDeEspera : IInfraestructura
    {
        private List<Seguridad> seguridadDeTurno;
        private int capacidadPersonasMax;
        private int contadorPersonasActuales;

        public int CapacidadPersonasMax { get => capacidadPersonasMax; set => capacidadPersonasMax = value; }
        internal List<Seguridad> SeguridaDeTurno { get => seguridadDeTurno; set => seguridadDeTurno = value; }
        public int ContadorPersonasActuales { get => contadorPersonasActuales; set => contadorPersonasActuales = value; }
        

        public void CambiodeTurno(List<Seguridad> seguridad)
        {
            seguridadDeTurno = seguridad;
        }
        public void AddPersonaActual(int c)
        {
            ContadorPersonasActuales += c;
        }
        public void EliminarPersonaActual(int c)
        {
            contadorPersonasActuales -= c;
        }
    }
}
