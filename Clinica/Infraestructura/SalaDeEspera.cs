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
        private Seguridad seguridadDeTurno;
     
        private List<InsumoLimpieza> insumoLimpieza;
        

       
       
        public List<InsumoLimpieza> InsumoLimpieza { get => insumoLimpieza; set => insumoLimpieza = value; }
        public Seguridad SeguridadDeTurno { get => seguridadDeTurno; set => seguridadDeTurno = value; }

        public void CambiodeTurno(Seguridad Entra)
        {
            SeguridadDeTurno= Entra;
        }

        public void AddInsumoCantidad(IInsumo insumo, int c)
        {
            insumo.AddCantidad(c);
        }
        public void ElimInsumoCantidad(IInsumo insumo, int c)
        {
            insumo.AddCantidad(c);
        }
    }
}
