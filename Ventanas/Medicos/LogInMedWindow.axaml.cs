using Avalonia.Controls;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio
{
    public partial class LogInMedWindow : Window
    {
        public Medico medicoUsuario;
        public LogInMedWindow()
        {
            InitializeComponent();

        }
        private void AbrirMenuMed(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                string userName = tbUsuario.Text;
                string password = tbContrasenia.Text;

                medicoUsuario.LogIn(userName, password);
            }
            catch
            {
                var errorWindow = new ErrorWindow();
                errorWindow.
            }

                
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void Volver(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}