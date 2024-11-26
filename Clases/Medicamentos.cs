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
        public Medicamentos(string nombre, int cantMinima) 
        {
            this.nombre = nombre;
            this.cantidad = cantMinima;
        }
        public void AddCantidad(int c)
        {
            cantidad += c;
        }
        public int VerCantidad()
        {
            return cantidad;
        }
        public void RestarCantidad(int c)
        {
            cantidad -= c;
        }
    }
}
