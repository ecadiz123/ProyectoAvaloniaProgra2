using Newtonsoft.Json;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Usuarios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Usuarios
{
    internal class Medico : Persona, IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;


        private List<DateTime> horasagendadas = new List<DateTime>();
        private List<Paciente> pacientes = new List<Paciente>();


        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        // Constructor vacio
        public Medico()
        {

            userName = string.Empty;
            password = string.Empty;
            horasagendadas = new List<DateTime>();
            pacientes = new List<Paciente>();
        }



        public Medico(string userName, string pass)
        {
            this.userName = userName;
            password = pass;
        }

        public void LogIn(string userName, string password)
        {
            StreamReader usuariocontrasena = new StreamReader("/Usuarios/Medicos/" + Nombre + Apellidopaterno);
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Medico medrecuperado = JsonConvert.DeserializeObject<Medico>(recuperado);
            if (!(medrecuperado.UserName == UserName && medrecuperado.Password == Password))
            {
                throw new Exception("Error en ingreso de usuario");
            }
        }
        public void AgregarPaciente(Paciente pas, DateTime fecha)
        {
            horasagendadas.Add(fecha);
            pacientes.Add(pas);
        }
        public void AtenderHoraPaciente(Paciente pas)
        {
            //
        }
        public void IngresarFicha(FichaMedica ficha)
        {

        }
        public void ModificarFicha(FichaMedica ficha)
        {

        }
        public void EliminarFicha(FichaMedica ficha)
        {

        }
    }
}
