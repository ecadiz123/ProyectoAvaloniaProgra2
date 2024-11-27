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
        private void ModificarFichas(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var modFichasWindow = new ModFichasWindow();
            modFichasWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}