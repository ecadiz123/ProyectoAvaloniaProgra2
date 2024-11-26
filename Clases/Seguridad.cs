using ProyectoConsultorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.TrabajadoresExt
{
    internal class Seguridad : Persona , ITrabajadoresExternos
    {
        string empresaContratista = string.Empty;

        public string EmpresaContratista { get => empresaContratista; set => empresaContratista = value; }
    }
}