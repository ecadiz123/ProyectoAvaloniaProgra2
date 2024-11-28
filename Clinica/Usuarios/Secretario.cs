using Newtonsoft.Json;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Infraestructura;
using ProyectoConsultorio.Clinica.Inventario;
using ProyectoConsultorio.Clinica.TrabajadoresExt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Usuarios
{
    public class Secretario : IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;
        string path = string.Empty;
        List<Medico> medicosClinica;



        SalaDeEspera sala;

        List<Box> box;

        List<Seguridad> seguridad;
        List<Limpieza> limpieza;
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }


        public List<Medico> MedicosClinica { get => medicosClinica; set => medicosClinica = value; }
        public List<Seguridad> Seguridad { get => seguridad; set => seguridad = value; }
        public List<Limpieza> Limpieza { get => limpieza; set => limpieza = value; }
        public SalaDeEspera Sala { get => sala; set => sala = value; }
        public List<Box> Box { get => box; set => box = value; }

        public void LogIn(string username, string password)
        {
            StreamReader usuariocontrasena = new StreamReader("JSON/Secretarios/" + username + "/LogIn.json");
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Secretario secRecuperado = JsonConvert.DeserializeObject<Secretario>(recuperado);
            if (!(secRecuperado.UserName == username && secRecuperado.Password == password))
            {
                throw new Exception("Error en ingreso de usuario");
            } else
            {
                this.UserName = username;
                this.Password = password;
                this.path = "JSON/Secretarios/" + username + "/";
                JsonSalaEspera();
                JsonListaBox();
                JsonMedicos();
                
            }
        }
        public void LogOff()//GUarda estado de secretario en Json
        {
            StreamWriter sr1 = new StreamWriter(this.path+"ListaBox.json");
            string jsonBox = JsonConvert.SerializeObject(this.box);
            sr1.WriteLine(jsonBox);
            sr1.Close();
            StreamWriter sr2 = new StreamWriter(this.path + "ListaMedicos.json");
            string jsonLMed = JsonConvert.SerializeObject(this.medicosClinica);
            sr2.WriteLine(jsonLMed);
            sr2.Close();
            StreamWriter sr3 = new StreamWriter(this.path + "SalaDeEspera.json");
            string Sesp = JsonConvert.SerializeObject(this.sala);
            sr3.WriteLine(jsonLMed);
            sr3.Close();
        }
        public void AñadirPaciente(Medico medicoAtiende, Paciente nuevoPaciente)
        {
            //Se busca mediante predicado en lista a medico por nombre
            //Luego a su lista de pacientes existentes se le añade el
            //nuevo paciente
            MedicosClinica.Find(x => x.UserName == medicoAtiende.UserName).Pacientes.Add(nuevoPaciente);
        }
        public void ElimPaciente(Medico medicoAtiende, Paciente pacienteElim)
        {
            //Se elimina paciente de medico especifico que se encuentra
            //En lista de medicos
            MedicosClinica.Find(x => x.UserName == medicoAtiende.UserName).Pacientes.Remove(pacienteElim);
        }

         public void MarcarTurnoTExternoSeguridad(Seguridad texterno, EstadoTurno nuevoTurno)
           {
           seguridad.Find(x => x.Nombre == texterno.Nombre).EstadoTurno = nuevoTurno;
          }
          public void MarcarTurnoTExternoLimpieza(Limpieza texterno, EstadoTurno nuevoTurno)
          {
           limpieza.Find(x => x.Nombre == texterno.Nombre).EstadoTurno = nuevoTurno;
         }
        
        //Metodos Json

        public void JsonListaBox()
        {
            StreamReader sr = new StreamReader(this.path + "ListaBox.json");
            string json = sr.ReadToEnd();
            sr.Close();
            var boxJson = JsonConvert.DeserializeObject<List<Box>>(json);
            this.box = boxJson;

        }
     
        public void JsonMedicos()
        {
            StreamReader sr = new StreamReader(this.path + "ListaMedicos.json");
            string json = sr.ReadToEnd();
            sr.Close();
            List<Medico> medJson = JsonConvert.DeserializeObject<List<Medico>>(json);
            this.medicosClinica = medJson;
        }


        public void JsonSalaEspera()
        {
            StreamReader sr = new StreamReader(this.path + "SalaDeEspera.json");
            string json = sr.ReadToEnd();
            sr.Close();
            var SEsperaJson = JsonConvert.DeserializeObject<SalaDeEspera>(json);
            this.sala = SEsperaJson;

            
            
            

            

        }

    }
}
