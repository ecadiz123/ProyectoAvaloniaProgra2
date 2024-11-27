using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using System;

namespace ProyectoConsultorio
{
    public partial class VerHoraWindow : Window
    {
        public VerHoraWindow()
        {
            InitializeComponent();

        }

        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow();
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}
        
    
