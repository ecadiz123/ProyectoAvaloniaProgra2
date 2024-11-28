using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoConsultorio.Clinica.Inventario;
namespace ProyectoConsultorio.Clinica.Infraestructura
{
    public interface IInfraestructura
    {

        void AddInsumoCantidad(IInsumo insumo, int c);
        void ElimInsumoCantidad(IInsumo insumo, int c);

    }
}
