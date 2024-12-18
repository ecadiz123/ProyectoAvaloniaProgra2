﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio
{
    public enum sexo_t{
        MASCULINO,
        FEMENINO,
        OTRO
    }
    public enum prevision_t
    {
        FONASA, COLMENA, CRUZBLANCA, BANMEDICA, CONSALUD,
        FUNDACION_BANCO_DEL_ESTADO, VIDA_TRES, NUEVA_MAS_VIDA
    }
    public enum afp_t
    {
        CAPITAL, HABITAT, UNO, CUPRUM, MODELO, PLANVITAL, PROVIDA
    }
    public class Persona
    {
        private int rut;
        private int digitoverificador;
        private int edad;
        private string nombre = " ";
        private string apellidomaterno = string.Empty;
        private string apellidopaterno = string.Empty;
        private string email = string.Empty;
        private int telefono;
        private sexo_t sexo;
        private prevision_t prevision;
        private DateTime fechanacimiento;
        
        public int Rut { get => rut; set => rut = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidomaterno { get => apellidomaterno; set => apellidomaterno = value; }
        public string Apellidopaterno { get => apellidopaterno; set => apellidopaterno = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        internal sexo_t Sexo { get => sexo; set => sexo = value; }
        internal prevision_t Prevision { get => prevision; set => prevision = value; }
        public int Digitoverificador { get => digitoverificador; set => digitoverificador = value; }
        public string Email { get => email; set => email = value; }
    }
}
