using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class VerMedHoraWindow : Window
    {
        public Medico med; 
        public VerMedHoraWindow()
        {
            InitializeComponent();
            foreach(DateTime Hdisp in med.HorasDisponibles)
            {
                HorasDisponibles.Items.Add(Hdisp.ToString());
            }
            
        }

        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.medico = med;
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void AddHoraMed(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            DateTime nuevaFechaD = calendar.SelectedDate ?? DateTime.Now;// Operador ?? porque SelectedDate es tipo nulo

            TimeSpan hora= Tpicker.SelectedTime ??  TimeSpan.Zero;//TimeSpan es representacion de lahora

            nuevaFechaD.Add(hora);
            med.HorasDisponibles.Add(nuevaFechaD);
            HorasDisponibles.Items.Add(nuevaFechaD.ToString());
            
        }
    }
}
        
    
