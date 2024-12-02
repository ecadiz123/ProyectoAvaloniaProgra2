using Avalonia.Controls;
using Newtonsoft.Json;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Usuarios;
using System.Collections.Generic;
using System.IO;

namespace ProyectoConsultorio
{
    public partial class TurnosWindow : Window
    {
        public Secretario sec;
        public TurnosWindow(Secretario secre)
        {
            this.sec = secre;
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            // Limpieza
            var limpiezaJson = File.ReadAllText("../../../JSON/Secretarios/ERomero/ListaLimp.json");
            var limpiezaData = JsonConvert.DeserializeObject<List<dynamic>>(limpiezaJson);
            foreach (var empleado in limpiezaData)
            {
                lbLimpieza.Items.Add($"{empleado.Nombre} {empleado.Apellidopaterno} - Estado: {empleado.EstadoTurno}");
            }

            // Seguridad
            var seguridadJson = File.ReadAllText("../../../JSON/Secretarios/ERomero/ListaSeg.json");
            var seguridadData = JsonConvert.DeserializeObject<List<dynamic>>(seguridadJson);
            foreach (var empleado in seguridadData)
            {
                lbSeguridad.Items.Add($"{empleado.Nombre} {empleado.Apellidopaterno} - Estado: {empleado.EstadoTurno}");
            }
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow(sec);
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}