using Avalonia.Controls;
using ProyectoConsultorio.Clases;

namespace ProyectoConsultorio
{
    public partial class ManejoFichasWindow : Window
    {
        public ManejoFichasWindow()
        {
            InitializeComponent();

        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}