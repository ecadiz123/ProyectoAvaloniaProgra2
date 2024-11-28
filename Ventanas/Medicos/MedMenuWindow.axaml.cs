using Avalonia.Controls;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio
{
    
    public partial class MedMenuWindow : Window
    {
        public Medico medico;
        public MedMenuWindow()
        {
            InitializeComponent();
        }
        private void VerAgendada(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var verMedHoraWindow = new VerMedHoraWindow();
            verMedHoraWindow.med=this.medico;
            verMedHoraWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void CerrarSesion(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void ManejoFichas(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var listaFichaWindow = new ListaFichaWindow();
            listaFichaWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void VerListaPacientes(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var listaPacientesWindow = new ListaPacientesWindow();

            listaPacientesWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}
