using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio
{
    enum sexo_t{
        MASCULINO,
        FEMENINO,
        OTRO
    }
    enum prevision_t
    {
        FONASA, COLMENA, CRUZBLANCA, BANMEDICA, CONSALUD,
        FUNDACION_BANCO_DEL_ESTADO, VIDA_TRES, NUEVA_MAS_VIDA
    }
    enum afp_t
    {
        CAPITAL, HABITAT, UNO, CUPRUM, MODELO, PLANVITAL, PROVIDA
    }
    public class Persona
    {
        private string rut = string.Empty;
        private int edad;
        private string nombre = string.Empty;
        private string apellidomaterno = string.Empty;
        private string apellidopaterno = string.Empty;
        private string direccion = string.Empty;
        private int telefono;
        private sexo_t sexo;
        private prevision_t prevision;
        private DateTime fechanacimiento;
        public Persona(int rut,int digitoverificador,int edad,string nombre,string apellidomaterno,string apellidopaterno,string direccion,int telefono,sexo_t sexo,prevision_t prevision,DateTime fechanacimiento)
        {
            this.rut = rut;
            this.digitoverificador = digitoverificador;
            this.edad = edad;
            this.nombre = nombre;
            this.apellidomaterno = apellidomaterno;
            this.apellidopaterno = apellidopaterno;
            this.direccion = direccion;
            this.telefono = telefono;
            this.sexo = sexo;
            this.prevision = prevision;
            this.fechanacimiento = fechanacimiento;
        }
        public Persona()
        {
            rut = 0;
            digitoverificador = 0;
            edad = 0;
            nombre = string.Empty;
            apellidomaterno = string.Empty;
            apellidopaterno = string.Empty;
            direccion = string.Empty;
            telefono = 0;
            sexo =sexo_t.MASCULINO;
            prevision = prevision_t.FONASA; 
            fechanacimiento = DateTime.MinValue; 
        }
        public int Rut { get => rut; set => rut = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidoematerno { get => apellidomaterno; set => apellidomaterno = value; }
        public string Apellidopaterno { get => apellidopaterno; set => apellidopaterno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        internal sexo_t Sexo { get => sexo; set => sexo = value; }
        internal prevision_t Prevision { get => prevision; set => prevision = value; }
    }
}
