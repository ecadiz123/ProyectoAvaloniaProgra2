using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class Box
    {
        Medico medicoDeTurno;

        internal Medico MedicoDeTurno { get => medicoDeTurno; set => medicoDeTurno = value; }
    }
}
