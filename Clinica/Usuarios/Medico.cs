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

   



   

        public void LogIn(string userName, string password)
        {
            StreamReader usuariocontrasena = new StreamReader("/JSON/Medicos/" + userName+"/LogIn.json");
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Medico medRecuperado = JsonConvert.DeserializeObject<Medico>(recuperado);
            if (!(medRecuperado.UserName == userName && medRecuperado.Password == password))
            {
                throw new Exception("Error en ingreso de usuario");
            }else
            {
                StreamReader sr = new StreamReader("/JSON/Medicos/" + userName + "/DatosPersona.json");
                Persona datosP = JsonConvert.DeserializeObject<Persona>(sr.ReadToEnd());
                sr.Close();
               // this.Nombre             =
               // this.Apellidopaterno    =
               // this.Apellidomaterno    =
               // this.Rut                =
               // this.Digitoverificador  =
               // this.Edad               =
               // this.Direccion          =
               // this.Telefono           =
               // this.Fechanacimiento
               // this.Sexo=
               // this.
            }
        }
      
        public void LogOff()//Se debe Hacer log off para guardar estado de medico en json
        {


        }
        
        public void AddHoraDisponible(DateTime nuevaHora)
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
