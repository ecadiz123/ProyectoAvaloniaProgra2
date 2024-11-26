using ProyectoConsultorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Inventario
{
    internal class Medicamentos : IInsumo
    {
        private string nombre = string.Empty;
        private int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public void AddCantidad(int c)
        {
            Cantidad += c;
        }
        public int VerCantidad()
        {
            return Cantidad;
        }
        public void RestarCantidad(int c)
        {
            Cantidad -= c;
        }
    }
}
