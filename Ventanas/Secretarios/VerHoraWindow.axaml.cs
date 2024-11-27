using Avalonia.Controls;
using ProyectoConsultorio.Clases;

namespace ProyectoConsultorio
{
    public partial class VerHoraWindow : Window
    {
        public VerHoraWindow()
        {
            InitializeComponent();

        }

        Button botonPresionado = Button;

        if(botonPresionado.Name == "btnVolverMedico")
            {
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow();
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
        else if(botonPresionado.Name == "btnVolverSecretario")
        {
        private void VolverMenuMed(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var medMenuWindow = new MedMenuWindow();
        medMenuWindow.Show(); // Muestra la ventana secundaria
        this.Close();
    }
        }
    }
}