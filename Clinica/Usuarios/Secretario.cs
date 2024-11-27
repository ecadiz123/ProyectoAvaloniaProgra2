﻿using Newtonsoft.Json;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Inventario;
using ProyectoConsultorio.TrabajadoresExt;
using ProyectoConsultorio.Usuarios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Usuarios
{
    public class Secretario : Persona, IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public Secretario(string user, string pass) : base()
        {
            userName = user;
            password = pass;
        }
        public void LogIn(string username, string password)
        {
            StreamReader usuariocontrasena = new StreamReader("/Usuarios/Secretarios/" + Nombre + Apellidopaterno);
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Secretario medrecuperado = JsonConvert.DeserializeObject<Secretario>(recuperado);
            if (!(medrecuperado.UserName == UserName && medrecuperado.Password == Password))
            {
                throw new Exception("Error en ingreso de usuario");
            }
        }
        public void AñadirHoraPaciente(Paciente pacientenuevo)
        {

        }
        public void ElimHoraPaciente(Paciente pacienteElim)
        {

        }
        public void MarcarLlegadaTurnoMedico(Medico medicoLlegando)
        {

        }
        public void MarcarTurnoTExterno(ITrabajadoresExternos texterno)
        {

        }
        public void AnhiadirInsumo(IInsumo insumoAdd)
        {

        }
        public void AnhiadirPersonasInf(int cantidadPersonasEntrantes)
        {

        }
        public void ElimPersonasInf(int personasSalientes)
        {

        }
    }
}