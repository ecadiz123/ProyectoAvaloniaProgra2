using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace ProyectoConsultorio
{
    public partial class InvWindow : Window
    {
        public InvWindow()
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