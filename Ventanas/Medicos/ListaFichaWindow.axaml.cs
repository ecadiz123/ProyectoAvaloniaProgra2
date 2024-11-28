using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class ListaFichaWindow : Window
    {
        public ListaFichaWindow()
        {
            InitializeComponent();

            lbPacientes.ItemsSource = new string[]
                {"Ibuprofeno   10", "Paracetamol   10", "Tapsin   50", "Anfetamina   25",
                    "Prednisona   25", "Clonazepam   54", "Oxolamina   1" }
                .OrderBy(x => x);
        }

        private void btModPaciente(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
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