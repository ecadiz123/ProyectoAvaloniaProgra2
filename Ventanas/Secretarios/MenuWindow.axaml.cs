using Avalonia.Controls;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio
{
    public partial class MenuWindow : Window
    {
        public Secretario sec;
        public MenuWindow(Secretario secr)
        {
            this.sec = secr;
            InitializeComponent();
        }
        private void HoraPaciente(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var ingresoWindow = new IngresoWindow(sec);
            ingresoWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void ModificarHora(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var modHoraWindow = new ModHoraWindow();
            modHoraWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void VerHoraAgendada(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var verHoraWindow = new VerHoraWindow();
            verHoraWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void CerrarSesion(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            sec.LogOff();
            mainWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void ManejoTurnos(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var turnosWindow = new TurnosWindow();
            turnosWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void ManejoInventarios(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var invWindow = new InvWindow();
            invWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void CerrarVentana(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close(); // Cierra la ventana
        }


    }
}
