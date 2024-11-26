using ProyectoConsultorio.Usuarios;
using ProyectoConsultorio.Inventario;
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
        private int contadorPersonasActuales;
        private List<Medicamentos> medicamentos;
        private List<Desechable> desechables;

        public int CapacidadPersonasMax { get => capacidadPersonasMax; set => capacidadPersonasMax = value; }
        public Medico MedicoDeTurno { get => medicoDeTurno; set => medicoDeTurno = value; }
        public int NumeroBox { get => numeroBox; set => numeroBox = value; }
        public int ContadorPersonasActuales { get => contadorPersonasActuales; set => contadorPersonasActuales = value; }
        public Box(List<Medicamentos> medicamentosMinimos, List<Desechable> desechablesMinimos, Medico medicoAtiende)
        {
            this.desechables=desechablesMinimos;
            this.medicamentos=medicamentosMinimos;
            this.medicoDeTurno=medicoAtiende;
            medicoDeTurno = new Medico();
            numeroBox = 0;
            capacidadPersonasMax = 0;
            contadorPersonasActuales = 0;
        }
        public void CambiodeTurno(Medico medico)
        {
            medicoDeTurno = medico;
        }
        public void AddPersonaActual(int c)
        {
            contadorPersonasActuales += c;
        }
        public void EliminarPersonaActual(int c)
        {
            contadorPersonasActuales -= c;
        }
    }
}
