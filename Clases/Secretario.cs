using ProyectoConsultorio.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases
{
    internal class Secretario : Persona , IUsuario
    {
        string userName = string.Empty;
        string password = string.Empty;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public void LogIn(string username, string password)
        {

        }

    }
}
