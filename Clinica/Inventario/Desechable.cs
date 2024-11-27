using Avalonia.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Inventario
{
    internal class Desechable : IInsumo
    {
        private string nombre;
        private int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Desechable(string nombre, int cantidadInicial)
        {
            this.nombre = nombre;
            cantidad = cantidadInicial;
        }
        public void AddCantidad(int c)
        {
            cantidad += c;
        }
        public void RestarCantidad(int c)
        {
            cantidad -= c;
        }
        public int VerCantidad()
        {
            return cantidad;
        }
    }
}
