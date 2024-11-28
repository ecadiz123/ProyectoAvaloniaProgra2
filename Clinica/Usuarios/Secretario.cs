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
    public class Secretario : Persona, IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;

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
            StreamReader usuariocontrasena = new StreamReader("/JSON/Secretarios/" + username+"/LogIn.json");
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Secretario secRecuperado = JsonConvert.DeserializeObject<Secretario>(recuperado);
            if (!(secRecuperado.UserName == username && secRecuperado.Password == password))
            {
                throw new Exception("Error en ingreso de usuario");
            }
        }
        public void LogOff()//GUarda estado de secretario en Json
        {

        }
        public void AñadirPaciente(Medico medicoAtiende,Paciente nuevoPaciente)
        {
            //Se busca mediante predicado en lista a medico por nombre
            //Luego a su lista de pacientes existentes se le añade el
            //nuevo paciente
            MedicosClinica.Find(x=> x.Nombre==medicoAtiende.Nombre).Pacientes.Add(nuevoPaciente);
        }
        public void ElimPaciente(Medico medicoAtiende,Paciente pacienteElim)
        {
            //Se elimina paciente de medico especifico que se encuentra
            //En lista de medicos
            MedicosClinica.Find(x => x.Nombre == medicoAtiende.Nombre).Pacientes.Remove(pacienteElim);
        }
        
        public void MarcarTurnoTExternoSeguridad(Seguridad texterno, EstadoTurno nuevoTurno)
        {
            seguridad.Find(x => x.Nombre == texterno.Nombre).EstadoTurno = nuevoTurno;
        }
        public void MarcarTurnoTExternoLimpieza(Limpieza texterno, EstadoTurno nuevoTurno)
        {
            limpieza.Find(x => x.Nombre == texterno.Nombre).EstadoTurno = nuevoTurno;
        }
        public void AnhiadirPersonasInf(int cantidadPersonasEntrantes)
        {
            sala.AddPersonaActual(cantidadPersonasEntrantes);
        }
        public void ElimPersonasInf(int Box,int personasSalientes)
        {
            box.Find(x=> x.NumeroBox== Box).EliminarPersonaActual(personasSalientes);
        }
        //Metodos Json

        public void JsonMedicos()
        {

        }
        public void JsonListInfraestructura()
        {

        }

        public void JsonListInsumos()
        {

        }
        public void JsonListTExternos()
        {

        }
    }
}
