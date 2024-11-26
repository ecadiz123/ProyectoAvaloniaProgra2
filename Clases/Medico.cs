using ProyectoConsultorio;
using ProyectoConsultorio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Usuarios
{
    internal class Medico : Persona , IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;

        
        private List<DateTime> horasagendadas = new List<DateTime>();
        private List<Paciente> pacientes = new List<Paciente>();

 
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        

        public void LogIn(string userName, string password) 
        {
            
        }
        public void AgregarPaciente(Paciente pas,DateTime fecha)
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
