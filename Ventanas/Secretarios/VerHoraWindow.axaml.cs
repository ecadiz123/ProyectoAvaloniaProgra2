using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Usuarios;
using System;

namespace ProyectoConsultorio
{
    public partial class VerHoraWindow : Window
    {
        public Secretario sec;
        public VerHoraWindow()
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
        
    
