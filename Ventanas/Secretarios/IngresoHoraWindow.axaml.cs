using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Usuarios;
using System.Collections.Generic;

namespace ProyectoConsultorio
{
    public partial class IngresoHoraWindow : Window
    {
        public Secretario sec;
        public Paciente nP;
       
        public IngresoHoraWindow(Secretario sec, Paciente PNuevo)
        {
            this.sec = sec;
            nP = PNuevo;
            
            
            InitializeComponent();


        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow(sec);
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}