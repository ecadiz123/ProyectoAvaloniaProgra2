using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Clientes
{
    internal interface ICliente
    {
        string MotivoDeConsulta { get; set; }
        DateTime FechaDeAtencion { get; set; }
    }
}
