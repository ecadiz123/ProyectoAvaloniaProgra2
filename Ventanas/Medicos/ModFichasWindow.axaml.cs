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
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void FichaMedica(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var listaFichaWindow = new ListaFichaWindow();
            listaFichaWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}