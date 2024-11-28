using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class InvWindow : Window
    {
        public InvWindow()
        {
            InitializeComponent();

            lbLimpiezaSalaEspera.ItemsSource = new string[]
                {"Escoba   10", "Trapo   10", "Pala   50", "CIF   25",
                  "Cera   25", "QUIX   54", "Rastrillo   1" }
            .OrderBy(x => x);
            lbMedsB1.ItemsSource = new string[]
                {"Escoba   10", "Trapo   10", "Pala   50", "CIF   25",
                  "Cera   25", "QUIX   54", "Rastrillo   1" }
            .OrderBy(x => x);
            lbLimpiezaB1.ItemsSource = new string[]
                {"Escoba   10", "Trapo   10", "Pala   50", "CIF   25",
                  "Cera   25", "QUIX   54", "Rastrillo   1" }
               .OrderBy(x => x);
            lbMedsB2.ItemsSource = new string[]
                {"Escoba   10", "Trapo   10", "Pala   50", "CIF   25",
                  "Cera   25", "QUIX   54", "Rastrillo   1" }
                .OrderBy(x => x);
            lbLimpiezaB2.ItemsSource = new string[]
                {"Escoba   10", "Trapo   10", "Pala   50", "CIF   25",
                  "Cera   25", "QUIX   54", "Rastrillo   1" }
               .OrderBy(x => x);

        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow();
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}