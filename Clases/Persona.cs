using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    enum sexo_t{
        MASCULINO,
        FEMENINO
    }
    enum previcion_t
    {
        FONASA,
        ISAPRE
    }
    internal class Persona
    {
        int rut;
        int edad;
        string nombre = string.Empty;
        string apllidoematerno = string.Empty;
        string apellidopaterno = string.Empty;
        string direccion = string.Empty;
        int telefono;
        sexo_t sexo;
        previcion_t previcion;
        DateTime fechanacimiento;

        public int Rut { get => rut; set => rut = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apllidoematerno { get => apllidoematerno; set => apllidoematerno = value; }
        public string Apellidopaterno { get => apellidopaterno; set => apellidopaterno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        internal sexo_t Sexo { get => sexo; set => sexo = value; }
        internal previcion_t Previcion { get => previcion; set => previcion = value; }
    }
}
