using Avalonia.Controls;
using ProyectoConsultorio.Clases;

namespace ProyectoConsultorio
{
    public partial class HorasDocWindow : Window
    {
        public HorasDocWindow()
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