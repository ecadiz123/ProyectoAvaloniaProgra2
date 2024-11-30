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
        public VerMedHoraWindow(Medico medico)
        {
            this.med = medico;
            InitializeComponent();
            foreach (DateTime Hdisp in med.HorasDisponibles)
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
            DateTime nuevaFechaD = calendar.SelectedDate ?? DateTime.Now;
            TimeSpan hora = Tpicker.SelectedTime ?? TimeSpan.Zero;

            DateTime fechaConHora = new DateTime(
                nuevaFechaD.Year,
                nuevaFechaD.Month,
                nuevaFechaD.Day,
                hora.Hours,
                hora.Minutes,
                hora.Seconds
            );

            med.HorasDisponibles.Add(fechaConHora);
            HorasDisponibles.Items.Add(fechaConHora.ToString("g"));
        }

        private void EliminarHoraMed(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

            if (HorasDisponibles.SelectedItem is string horaSeleccionada)
            {

                if (DateTime.TryParse(horaSeleccionada, out DateTime horaAEliminar))
                {
                    med.HorasDisponibles.Remove(horaAEliminar);
                    HorasDisponibles.Items.Remove(horaSeleccionada);
                }
            }
            else
            {
                Console.WriteLine("Por favor selecciona una hora para eliminar");
            }
        }

    }
}



