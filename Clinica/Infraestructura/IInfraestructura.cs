using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Infraestructura
{
    internal interface IInfraestructura
    {
        int CapacidadPersonasMax { get; set; }
        int ContadorPersonasActuales { get; set; }
        void AddPersonaActual(int c);
        void EliminarPersonaActual(int c);
    }
}
