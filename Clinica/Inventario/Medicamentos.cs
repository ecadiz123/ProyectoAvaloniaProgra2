using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Inventario
{
    public class Medicamentos : IInsumo
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public void AddCantidad(int c)
        {
            Cantidad += c;
        }

        public void RestarCantidad(int c)
        {
            Cantidad -= c;
        }

        public int VerCantidad()
        {
            return Cantidad;
        }
    }
}

