using Avalonia.Controls;
using ProyectoConsultorio.Clases;

namespace ProyectoConsultorio
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void AbrirLogInSecretario(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var logInSecWindow = new LogInSecWindow();
            logInSecWindow.Show(); // Muestra la ventana LogInSec
            this.Close();
        }

        private void AbrirLogInMedico(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var logInMedWindow = new LogInMedWindow();
            logInMedWindow.Show(); // Muestra la ventana LogInMed
            this.Close();
        }
    }
}