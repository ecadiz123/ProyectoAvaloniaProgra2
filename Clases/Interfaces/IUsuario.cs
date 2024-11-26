using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clases.Interfaces
{
    internal interface IUsuario
    {
        string UserName { get; set; }
        string Password { get; set; }
        void LogIn(string userName,string password );
    }
}
