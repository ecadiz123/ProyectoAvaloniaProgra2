using Newtonsoft.Json;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Infraestructura;
using ProyectoConsultorio.Clinica.Inventario;
using ProyectoConsultorio.Clinica.TrabajadoresExt;
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

        List<Medico> medicosClinica;

        List<IInsumo> inventario;
        
        List<IInfraestructura> infraestructuras;

        List<ITrabajadoresExternos> trabajadores;
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public List<ITrabajadoresExternos> Trabajadores { get => trabajadores; set => trabajadores = value; }
        public List<IInfraestructura> Infraestructuras { get => infraestructuras; set => infraestructuras = value; }
        public List<IInsumo> Inventario { get => inventario; set => inventario = value; }
        public List<Medico> MedicosClinica { get => medicosClinica; set => medicosClinica = value; }

        public void LogIn(string username, string password)
        {
            StreamReader usuariocontrasena = new StreamReader("/Usuarios/Secretarios/" + Nombre + Apellidopaterno);
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Secretario secRecuperado = JsonConvert.DeserializeObject<Secretario>(recuperado);
            if (!(secRecuperado.UserName == UserName && secRecuperado.Password == Password))
            {
                throw new Exception("Error en ingreso de usuario");
            }
        }
        public void LogOff()//GUarda estado de secretario en Json
        {

        }
        public void AñadirPaciente(Paciente nuevoPaciente)
        {

        }
        public void ElimHoraPaciente(Paciente pacienteElim)
        {

        }
        
        public void MarcarTurnoTExterno(ITrabajadoresExternos texterno)
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
