using ProyectoConsultorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.TrabajadoresExt
{
    internal class Limpieza : Persona, ITrabajadoresExternos
    {
        string empresaContratista = string.Empty;
        
        Limpieza(string empresaContratista):base()
        {
            this.empresaContratista=empresaContratista;
        }
        public string EmpresaContratista { get => empresaContratista; set => empresaContratista = value; }
    }
}
