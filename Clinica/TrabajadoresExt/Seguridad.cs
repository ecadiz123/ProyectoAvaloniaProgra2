using ProyectoConsultorio.TrabajadoresExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.TrabajadoresExt
{
    public class Seguridad : Persona, ITrabajadoresExternos
    {
        string empresaContratista = string.Empty;
        public Seguridad(string empresaContratista) : base()
        {

        }
        public string EmpresaContratista { get => empresaContratista; set => empresaContratista = value; }
    }
}