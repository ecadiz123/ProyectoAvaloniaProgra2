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

        //NO COLOQUEN CONSTRUCTORES, NEWTONSOFT NO LEE JSON CON 
        //CONSTRUCTORES QUE NO SEAN EL DEFAULT
        public void LogIn(string username, string password)
        {
            StreamReader usuariocontrasena = new StreamReader("../../../JSON/Secretarios/" + username + "/LogIn.json");
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
                this.path = "../../../JSON/Secretarios/" + username + "/";
                JsonSalaEspera();
                JsonListaBox();
                JsonSeguridad();
                JsonLimpieza();
                JsonMedicos();
                
            }
        }
        public void LogOff()//GUarda estado de secretario en Json
        {
            //guarda estado Box
            StreamWriter sr1 = new StreamWriter(this.path+"ListaBox.json");
            string jsonBox = JsonConvert.SerializeObject(this.box,Formatting.Indented);
            sr1.WriteLine(jsonBox);
            sr1.Close();
          
            //Guarda Estados sala de espera
            StreamWriter sr3 = new StreamWriter(this.path + "SalaDeEspera.json");
            string Sesp = JsonConvert.SerializeObject(this.sala, Formatting.Indented);
            sr3.WriteLine(Sesp);
            sr3.Close();
            //Guarda estados Limpieza
            StreamWriter sr4 = new StreamWriter(this.path + "ListaLimp.json");
            string jsonlimp = JsonConvert.SerializeObject(this.Limpieza, Formatting.Indented);
            sr4.WriteLine(jsonlimp);
            sr4.Close();
            //Estados Seguridad
            StreamWriter sr5 = new StreamWriter(this.path + "ListaSeg.json");
            string jsonSeg = JsonConvert.SerializeObject(this.Seguridad, Formatting.Indented);
            sr5.WriteLine(jsonSeg);
            sr5.Close();
            //Se guardan los estados de los medicos con sus metodos
            foreach(Medico med in  this.MedicosClinica)
            {
                med.LogOff();
            }
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
            
            //Ahora se le colocan los valores de los json a cada medico
            
            foreach (Medico medico in medJson)
            {
                medico.RecuperarJsonLogIn(medico.UserName);
                
            }
            this.MedicosClinica = medJson;
        }


        public void JsonSalaEspera()
        {
            StreamReader sr = new StreamReader(this.path + "SalaDeEspera.json");
            string json = sr.ReadToEnd();
            sr.Close();
            SalaDeEspera SEsperaJson = JsonConvert.DeserializeObject<SalaDeEspera>(json);
            this.sala = SEsperaJson;

            
            
            

            

        }
        public void JsonLimpieza()
        {
            StreamReader sr = new StreamReader(this.path + "ListaLimp.json");
            string json = sr.ReadToEnd();
            sr.Close();
            var Limpiezajson = JsonConvert.DeserializeObject<List<Limpieza>>(json);
            this.Limpieza = Limpiezajson;







        }
        public void JsonSeguridad()
        {
            StreamReader sr = new StreamReader(this.path + "ListaSeg.json");
            string json = sr.ReadToEnd();
            sr.Close();
            var LSeg = JsonConvert.DeserializeObject<List<Seguridad>>(json);
            this.Seguridad= LSeg;







        }
    }
}
