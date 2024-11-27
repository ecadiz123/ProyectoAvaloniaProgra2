using Avalonia.Controls;
using ProyectoConsultorio.Clases;

namespace ProyectoConsultorio
{
    public partial class TurnosWindow : Window
    {
        public TurnosWindow()
        {
            InitializeComponent();

        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow();
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}