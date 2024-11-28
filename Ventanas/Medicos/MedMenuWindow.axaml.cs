using Avalonia.Controls;
using Avalonia.VisualTree;
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
            var verMedHoraWindow = new VerMedHoraWindow(this.medico);
            verMedHoraWindow.med=this.medico;
            verMedHoraWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void CerrarSesion(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            this.medico.LogOff();
            mainWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void ManejoFichas(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var listaFichaWindow = new ListaFichaWindow(this.medico);
            listaFichaWindow.med = this.medico;
            listaFichaWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void VerListaPacientes(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var listaPacientesWindow = new ListaPacientesWindow(this.medico);
            
            listaPacientesWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}
