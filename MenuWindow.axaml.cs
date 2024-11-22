using Avalonia.Controls;

namespace ProyectoConsultorio
{
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }
        private void HoraPaciente(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var ingresoWindow = new IngresoWindow();
            ingresoWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void DisponiblesDoctores(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var horasDocWindow = new HorasDocWindow();
            horasDocWindow.Show(); // Muestra la ventana secundaria
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
            mainWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void CerrarVentana(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close(); // Cierra la ventana
        }
    }
}
