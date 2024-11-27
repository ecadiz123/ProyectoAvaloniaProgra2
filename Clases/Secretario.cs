using Newtonsoft.Json;
using ProyectoConsultorio;
using ProyectoConsultorio.Clientes;
using ProyectoConsultorio.Inventario;
using ProyectoConsultorio.TrabajadoresExt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Usuarios
{
    internal class Secretario : Persona, IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public Secretario(string user,string pass) :base()
        {
            userName = user;
            password = pass;
        }
        public void LogIn(string username, string password)
        {
            StreamReader usuariocontrasena = new StreamReader("/Usuarios/Secretarios/" + this.Nombre + this.Apellidopaterno);
            string recuperado = usuariocontrasena.ReadToEnd();
            usuariocontrasena.Close();
            Secretario medrecuperado = JsonConvert.DeserializeObject<Secretario>(recuperado);
            if (!(medrecuperado.UserName == this.UserName && medrecuperado.Password == this.Password))
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
