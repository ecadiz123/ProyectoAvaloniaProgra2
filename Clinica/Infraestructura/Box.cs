using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoConsultorio.Clinica.Inventario;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio.Clinica.Infraestructura
{
    public class Box : IInfraestructura
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
        public Box(List<Medicamentos> medicamentosMinimos, List<Desechable> desechablesMinimos)
        {
            desechables = desechablesMinimos;
            medicamentos = medicamentosMinimos;
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
