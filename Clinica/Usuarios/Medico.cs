using Newtonsoft.Json;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Infraestructura;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Usuarios
{
    public class Medico : IUsuario
    {
        string nombreAp= string.Empty;
        string userName = string.Empty;
        string password = string.Empty;
        string path = string.Empty;


        private List<Paciente> pacientes = new List<Paciente>();
        private List<DateTime> horasDisponibles = new List<DateTime>(); 


        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public List<DateTime> HorasDisponibles { get => horasDisponibles; set => horasDisponibles = value; }
        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }
        public string NombreAp { get => nombreAp; set => nombreAp = value; }

        //NO COLOQUEN CONSTRUCTORES, NEWTONSOFT NO LEE JSON CON 
        //CONSTRUCTORES QUE NO SEAN EL DEFAULT

        public void LogIn(string username, string password)
        {   
         
            StreamReader usuariocontrasena = new StreamReader("../../../JSON/Medicos/" + username+"/LogIn.json");
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Medico medRecuperado = JsonConvert.DeserializeObject<Medico>(recuperado);
            if (!(medRecuperado.UserName == username && medRecuperado.Password == password))
            {
                throw new Exception("Error en ingreso de usuario");
            }else
            {
                this.UserName = username;
                this.Password = password;
                this.nombreAp = medRecuperado.nombreAp;
                this.path = "../../../JSON/Medicos/" + username+"/";

                RecuperarhorasDispJson();
                RecuperarPacientesJson();
            }
        }
      
        public void LogOff()//Se debe Hacer log off para guardar estado de medico en json
        {
            StreamWriter sw1 = new StreamWriter(this.path + "ListPacientes.json");
            string pacientesJson = JsonConvert.SerializeObject(this.pacientes, Formatting.Indented);
            sw1.WriteLine(pacientesJson);
            sw1.Close();
            StreamWriter sw2 = new StreamWriter(this.path + "HorasDisponibles.json");
            string HDispJson = JsonConvert.SerializeObject(this.horasDisponibles, Formatting.Indented);
            sw2.WriteLine(HDispJson);
            sw2.Close();
        }
        
        public void AddHoraDisponible(DateTime nuevaHora)
        {
            HorasDisponibles.Add(nuevaHora);
        }
        public void ElimHoraDisponible(DateTime elimHora)
        {
            HorasDisponibles.Remove(elimHora);
        }
        //metodo para recuperar info en secretario
        public void RecuperarJsonLogIn(string username)
        {
            StreamReader usuariocontrasena = new StreamReader("../../../JSON/Medicos/" + username + "/LogIn.json");
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Medico medRecuperado = JsonConvert.DeserializeObject<Medico>(recuperado);
            this.UserName = username;
            this.Password = medRecuperado.Password;
            this.nombreAp = medRecuperado.nombreAp;
            this.path = "../../../JSON/Medicos/" + username + "/";
            RecuperarhorasDispJson();
            RecuperarPacientesJson();
        }
        public void RecuperarPacientesJson()
        {
            StreamReader sr = new StreamReader(this.path+"ListPacientes.json");
            string json = sr.ReadToEnd();
            sr.Close();
            List<Paciente> pacientesJson = JsonConvert.DeserializeObject < List<Paciente> >(json);
            this.pacientes = pacientesJson;
        }
        public void RecuperarhorasDispJson()
        {
            StreamReader sr = new StreamReader(this.path + "HorasDisponibles.json");
            string json = sr.ReadToEnd();
            sr.Close();
            List<DateTime> HDispJson = JsonConvert.DeserializeObject<List<DateTime>>(json);
            this.horasDisponibles = HDispJson;

        }
       

        
    }
}
