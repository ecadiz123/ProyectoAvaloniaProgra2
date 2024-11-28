using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class VerMedHoraWindow : Window
    {
        public VerMedHoraWindow()
        {
            InitializeComponent();
            HorasDisponibles.ItemsSource = new string[]
                {"Médico1", "Médico2"}
            .OrderBy(x => x);
        }

        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void AddHoraMed(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}
        
    
