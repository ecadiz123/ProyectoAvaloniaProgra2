using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio
{
    public partial class IngresoHoraWindow : Window
    {
        public Secretario sec;
        public IngresoHoraWindow()
        {
            InitializeComponent();

        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow(sec);
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}