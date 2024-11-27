using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Clientes
{
    internal class Paciente : Persona
    {
        private string motivoConsulta = string.Empty;
        private bool tieneTutor;
        private Tutor tutor;
        private DateTime fechaatencion;
        private Medico medicoAtiende;
        private FichaMedica ficha;

        public string MotivoConsulta { get => motivoConsulta; set => motivoConsulta = value; }
        public bool TieneTutor { get => tieneTutor; set => tieneTutor = value; }
        public DateTime Fechaatencion { get => fechaatencion; set => fechaatencion = value; }
        internal Medico MedicoAtiende { get => medicoAtiende; set => medicoAtiende = value; }
        internal FichaMedica Ficha { get => ficha; set => ficha = value; }


        public void CambiarFechaAtencion(DateTime nuevafechaatencion)
        {
            fechaatencion = nuevafechaatencion;
        }
    }
}
