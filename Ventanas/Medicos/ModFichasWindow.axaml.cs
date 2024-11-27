using Avalonia.Controls;
using ProyectoConsultorio.Clases;

namespace ProyectoConsultorio
{
    public partial class ModFichasWindow : Window
    {
        public ModFichasWindow()
        {
            InitializeComponent();

        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var manejoFichasWindow = new ManejoFichasWindow();
            manejoFichasWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}