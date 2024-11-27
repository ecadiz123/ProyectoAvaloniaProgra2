using Newtonsoft.Json;
using ProyectoConsultorio.Clinica.Clientes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Usuarios
{
    public class Medico : Persona, IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;



        private List<Paciente> pacientes = new List<Paciente>();
        private List<DateTime> horasDisponibles = new List<DateTime>(); 


        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public List<DateTime> HorasDisponibles { get => horasDisponibles; set => horasDisponibles = value; }
        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }

        // Constructor vacio
        public Medico()
        {

            userName = string.Empty;
            password = string.Empty;
            
            Pacientes = new List<Paciente>();

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
            Medico medRecuperado = JsonConvert.DeserializeObject<Medico>(recuperado);
            if (!(medRecuperado.UserName == UserName && medRecuperado.Password == Password))
            {
                throw new Exception("Error en ingreso de usuario");
            }
        }
      
        public void LogOff()//Se debe Hacer log off para guardar estado de medico en json
        {

        }
        
        public void AtenderHoraPaciente(Paciente pas)
        {
            
        }
        public void IngresarFicha(Paciente paciente)
        {

        }
        public void ModificarFicha(Paciente paciente)
        {

        }

        void RecuperarPacientesJson()
        {

        }
        void RecuperarhorasDispJson()
        {

        }

        public void JsonMedicoInit()
        { 
            RecuperarhorasDispJson();
            RecuperarPacientesJson();
        }
    }
}
