using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoConsultorio.Clinica.Inventario;
using ProyectoConsultorio.Clinica.TrabajadoresExt;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio.Clinica.Infraestructura
{
    public class Box : IInfraestructura
    {
        private Medico medico;
        private Limpieza Limpieza { get; set; }
        private int numeroBox;

    
        private List<Medicamentos> medicamentos;
        private List<Desechable> desechables;
        

      
        
        public int NumeroBox { get => numeroBox; set => numeroBox = value; }

        public void AddInsumoCantidad(IInsumo insumo, int c)
        {
            insumo.AddCantidad(c);
        }

        public void ElimInsumoCantidad(IInsumo insumo, int c)
        {
            insumo.RestarCantidad(c);
        }
    }
}
