using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Usuarios;
using System.Collections.Generic;

namespace ProyectoConsultorio
{
    public partial class TurnosWindow : Window
    {
        public Secretario sec;
        public TurnosWindow(Secretario secre)
        {
            this.sec = secre;
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