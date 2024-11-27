using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class ModHoraWindow : Window
    {
        public ModHoraWindow()
        {
            InitializeComponent();
            lbPacientes.ItemsSource = new string[]
                {"Ibuprofeno   10", "Paracetamol   10", "Tapsin   50", "Anfetamina   25",
                    "Prednisona   25", "Clonazepam   54", "Oxolamina   1" }
                .OrderBy(x => x);
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow();
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}