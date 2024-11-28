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
     
        private List<InsumoLimpieza> insumoLimpieza;
        

       
        public List<Seguridad> SeguridaDeTurno { get => seguridadDeTurno; set => seguridadDeTurno = value; }


        public void CambiodeTurno(Seguridad seguridadEntra,Seguridad seguridadSale)
        {
            SeguridaDeTurno.Add(seguridadEntra);
            //Se usa metodo find para que el metodo remove
            //De la lista pueda encontrar sin problema 
            //a la persona a eliminar
            var segSale= SeguridaDeTurno.Find(x => x.Nombre == seguridadSale.Nombre);
            seguridadDeTurno.Remove(segSale);
        }

        public void AddInsumoCantidad(IInsumo insumo, int c)
        {
            
        }
        public void ElimInsumoCantidad(IInsumo insumo, int c)
        {
            
        }
    }
}
