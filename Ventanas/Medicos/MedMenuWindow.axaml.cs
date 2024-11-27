using Avalonia.Controls;

namespace ProyectoConsultorio
{
    public partial class MedMenuWindow : Window
    {
        public MedMenuWindow()
        {
            InitializeComponent();
        }
        private void VerAgendada(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var verMedHoraWindow = new VerMedHoraWindow();
            verMedHoraWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void CerrarSesion(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void ManejoFichas(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var manejoFichasWindow = new ManejoFichasWindow();
            manejoFichasWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void VerListaPacientes(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var listaPacientesWindow = new ListaPacientesWindow();
            listaPacientesWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void Error(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var errorWindow = new ErrorWindow();
            errorWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}
