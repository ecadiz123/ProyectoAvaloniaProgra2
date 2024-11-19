using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class Desechable
    {
        private string nombre = string.Empty;
        private int cantidad = 0;

        public Desechable(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }
        public void AgregarDesechable(int x)
        {
            cantidad= cantidad+x;
        }
        public void  UsarDesechable(int x)
        {
            cantidad = cantidad - x;
        }
    }
}
