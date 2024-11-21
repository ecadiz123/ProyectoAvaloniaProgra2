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
        private void AbrirVentanaSecundaria(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var secondWindow = new SecondWindow();
            secondWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}