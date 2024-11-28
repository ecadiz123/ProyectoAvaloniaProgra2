using ProyectoConsultorio.Clinica.Inventario;
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
        private List<Limpieza> insumoLimpieza;
        

        public int CapacidadPersonasMax { get => capacidadPersonasMax; set => capacidadPersonasMax = value; }
        public List<Seguridad> SeguridaDeTurno { get => seguridadDeTurno; set => seguridadDeTurno = value; }
        public int ContadorPersonasActuales { get => contadorPersonasActuales; set => contadorPersonasActuales = value; }
        

        public void CambiodeTurno(Seguridad seguridadEntra,Seguridad seguridadSale)
        {
            SeguridaDeTurno.Add(seguridadEntra);
            //Se usa metodo find para que el metodo remove
            //De la lista pueda encontrar sin problema 
            //a la persona a eliminar
            var segSale= SeguridaDeTurno.Find(x => x.Nombre == seguridadSale.Nombre);
            seguridadDeTurno.Remove(segSale);
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
