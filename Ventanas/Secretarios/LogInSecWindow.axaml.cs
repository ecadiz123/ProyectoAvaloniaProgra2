using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.IO;
namespace ProyectoConsultorio
{
    public partial class LogInSecWindow : Window
    {
        public Secretario secretario = new Secretario();
        public LogInSecWindow()
        {
            InitializeComponent();

        }
        private void AbrirVentanaSecundaria(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                string user = tbUsuario.Text;
                string pass = tbContrasenia.Text;
                secretario.LogIn(user, pass);
                var menuWindow = new MenuWindow(secretario);
                menuWindow.Show(); // Muestra la ventana secundaria
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
                }else 
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