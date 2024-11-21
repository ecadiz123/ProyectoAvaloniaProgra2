using Avalonia.Controls;

namespace ProyectoConsultorio
{
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }
        private void AbrirVentanaSecundaria(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var thirdWindow = new ThirdWindow();
            thirdWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void CerrarVentana(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close(); // Cierra la ventana
        }
    }
}
