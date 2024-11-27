using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace ProyectoConsultorio
{
    public partial class IngresoWindow : Window
    {
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

    }
}