using Avalonia.Controls;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.IO;
namespace ProyectoConsultorio
{
    public partial class LogInMedWindow : Window
    {
        public Medico medicoUsuario =new Medico();
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

                //Si login no tira error

                var medMenuWindow = new MedMenuWindow();
                medMenuWindow.medico = medicoUsuario;
                medMenuWindow.Show();// Muestra la ventana secundaria

                this.Close();
            }
            catch (Exception ex)
            {
                if (ex is DirectoryNotFoundException)
                {
                    var errorWindow1 = new ErrorWindow();
                    errorWindow1.ErrorMsg.Text = "No Existe Usuario";
                    errorWindow1.Show();
                }
                else if (ex is FileNotFoundException)
                {
                    var errorWindow2 = new ErrorWindow();
                    errorWindow2.ErrorMsg.Text = "Ingrese Texto Valido";
                    errorWindow2.Show();
                }
                else
                {
                    var errorWindow = new ErrorWindow();
                    errorWindow.ErrorMsg.Text = ex.Message;
                    errorWindow.Show();
                }


            }
           

                
        
        }
        private void Volver(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}