using Avalonia.Controls.Templates;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Clientes
{
    public class Paciente : Persona
    {
        private string motivoConsulta = string.Empty;
        private bool tieneTutor;
        private Tutor tutor = new Tutor();
        private DateTime fechaatencion;
        
        private FichaMedica ficha;

        private string nCompleto;

       

        public string MotivoConsulta { get => motivoConsulta; set => motivoConsulta = value; }
        public bool TieneTutor { get => tieneTutor; set => tieneTutor = value; }
        public DateTime Fechaatencion { get => fechaatencion; set => fechaatencion = value; }
       
        public FichaMedica Ficha { get => ficha; set => ficha = value; }
        public Tutor Tutor { get => tutor; set => tutor = value; }
        public string NCompleto { get => nCompleto; set => nCompleto = value; }
    }
}
