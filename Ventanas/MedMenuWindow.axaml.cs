using Avalonia.Controls;

namespace ProyectoConsultorio
{
    public partial class MedMenuWindow : Window
    {
        public MedMenuWindow()
        {
            InitializeComponent();
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
        private void InventarioMedicamento(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var invWindow = new InvWindow();
            invWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void ManejoFichas(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var turnosWindow = new TurnosWindow();
            turnosWindow.Show(); // Muestra la ventana secundaria
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
