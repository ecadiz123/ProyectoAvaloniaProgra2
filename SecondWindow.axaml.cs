using Avalonia.Controls;

namespace ProyectoConsultorio
{
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void CerrarVentana(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close(); // Cierra la ventana
        }
    }
}
