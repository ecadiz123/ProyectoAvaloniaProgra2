using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Collections.Generic;

namespace ProyectoConsultorio
{
    public struct PacienteYFecha
    {
        private DateTime fDeAtencion;
        private Paciente pacienteS;
        private string fechaYPaciente;

        public DateTime FDeAtencion { get => fDeAtencion; set => fDeAtencion = value; }
        public Paciente PacienteS { get => pacienteS; set => pacienteS = value; }
        public string FechaYPaciente { get => fechaYPaciente; set => fechaYPaciente = value; }
    }
   
    public partial class VerHoraWindow : Window
    {

        public Secretario sec;
        public List<PacienteYFecha> fechaList;
        
        public VerHoraWindow()
        {
            InitializeComponent();

           



        }
        public VerHoraWindow(Secretario secre)
        {
            this.sec = secre;
            fechaList= new List<PacienteYFecha>();
            InitializeComponent();
            //For para inicializar lista
            foreach(Medico med in sec.MedicosClinica)
            {
                foreach(Paciente pac in med.Pacientes)
                {
                    PacienteYFecha pacFech = new PacienteYFecha();
                    pacFech.PacienteS = pac;
                    pacFech.FDeAtencion = pac.Fechaatencion;
                    pacFech.FechaYPaciente= pac.Nombre+" "+pac.Apellidopaterno+" "+pacFech.FDeAtencion.ToString();
                    fechaList.Add(pacFech);

                }    

            }
            LbHAgendadas.ItemsSource = fechaList;

        }
       
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow(sec);
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}
        
    
