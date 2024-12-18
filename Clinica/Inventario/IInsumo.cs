﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Inventario
{
    public interface IInsumo
    {
        string Nombre { get; set; }
        int Cantidad { get; set; }
        void AddCantidad(int c);
        int VerCantidad();
        void RestarCantidad(int c);
    }
}

