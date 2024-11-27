﻿using ProyectoConsultorio.TrabajadoresExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.TrabajadoresExt
{
   public class Limpieza : Persona, ITrabajadoresExternos
    {
        string empresaContratista = string.Empty;

        Limpieza(string empresaContratista) : base()
        {
            this.empresaContratista = empresaContratista;
        }
        public string EmpresaContratista { get => empresaContratista; set => empresaContratista = value; }
    }
}
