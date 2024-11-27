﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.TrabajadoresExt
{
    public class Seguridad : Persona, ITrabajadoresExternos
    {
        string empresaContratista = string.Empty;
        EstadoTurno estadoTurno;
        
        public string EmpresaContratista { get => empresaContratista; set => empresaContratista = value; }
        public EstadoTurno EstadoTurno { get => estadoTurno; set => estadoTurno = value; }
    }
}