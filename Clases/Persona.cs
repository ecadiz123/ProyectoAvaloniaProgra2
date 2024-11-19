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
        private int rut;
        private int digitoverificador;
        private int edad;
        private string nombre = string.Empty;
        private string apllidoematerno = string.Empty;
        private string apellidopaterno = string.Empty;
        private string direccion = string.Empty;
        private int telefono;
        private sexo_t sexo;
        private previcion_t previcion;
        private DateTime fechanacimiento;

        public int Rut { get => rut; set => rut = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apllidoematerno { get => apllidoematerno; set => apllidoematerno = value; }
        public string Apellidopaterno { get => apellidopaterno; set => apellidopaterno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public int Digitoverificador { get => digitoverificador; set => digitoverificador = value; }
        internal sexo_t Sexo { get => sexo; set => sexo = value; }
        internal previcion_t Previcion { get => previcion; set => previcion = value; }
    }
}
