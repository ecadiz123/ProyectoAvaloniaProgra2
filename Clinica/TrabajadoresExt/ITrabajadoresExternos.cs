using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.TrabajadoresExt
{
    public enum EstadoTurno
    {
        SALA,BOX,FUERA
    } 
    public interface ITrabajadoresExternos
    {
        string EmpresaContratista { get; set; }
        EstadoTurno EstadoTurno { get; set; }

    }
}
