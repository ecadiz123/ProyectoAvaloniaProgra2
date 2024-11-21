using Avalonia.Controls;
using ProyectoConsultorio.Clases;

namespace ProyectoConsultorio
{
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();

        }

        private void CerrarVentana(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Close(); // Cierra la ventana
        }
    }
}