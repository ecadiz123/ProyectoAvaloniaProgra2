using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Clientes
{
    public interface ICliente
    {
        string MotivoDeConsulta { get; set; }
        DateTime FechaDeAtencion { get; set; }
    }
}
