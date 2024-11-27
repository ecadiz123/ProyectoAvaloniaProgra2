using Avalonia.Controls;
using ProyectoConsultorio.Clinica.Clientes;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Collections.Generic;
using System;

namespace ProyectoConsultorio
{
    public partial class IngresoWindow : Window
    {

        public List<Paciente> ListaPacientes { get; set; } = new List<Paciente>();
        public List<Tutor> ListaTutores { get; set; } = new List<Tutor>();
        public IngresoWindow()
        {
            InitializeComponent();
            DataContext = this;

            var BoolTutor = this.FindControl<CheckBox>("BoolTutor");
            var PanelTitulo = this.FindControl<StackPanel>("PanelTitulo");
            var PanelDatos = this.FindControl<StackPanel>("PanelDatos");
            var PanelDatos2 = this.FindControl<StackPanel>("PanelDatos2");
            var PanelDatos3 = this.FindControl<StackPanel>("PanelDatos3");
            var PanelDatos4 = this.FindControl<StackPanel>("PanelDatos4");

            BoolTutor.Checked += (sender, e) =>
            {
                PanelTitulo.IsVisible = true;
                PanelDatos.IsVisible = true;
                PanelDatos2.IsVisible = true;
                PanelDatos3.IsVisible = true;
                PanelDatos4.IsVisible = true;
            };
            BoolTutor.Unchecked += (sender, e) =>
            {
                PanelTitulo.IsVisible = false;
                PanelDatos.IsVisible = false;
                PanelDatos2.IsVisible = false;
                PanelDatos3.IsVisible = false;
                PanelDatos4.IsVisible = false;
            };
        }
       
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow();
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void IngresoDatos(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow();
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

    }
}