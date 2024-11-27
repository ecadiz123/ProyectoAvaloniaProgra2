using Avalonia.Controls;
using Newtonsoft.Json;
using System.Collections.Generic;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clientes;
using System.IO;

namespace ProyectoConsultorio
{
    public partial class ListaPacientesWindow : Window
    {
        public ListaPacientesWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("../../../Pacientes/ListaPacientes.json");
            string json = sr.ReadToEnd();
            sr.Close();
            var ljson = JsonConvert.DeserializeObject<List<Paciente>>(json);
            foreach(Paciente paciente in ljson)
            {
                LboxPacientes.Items.Add(paciente.Nombre+" "+paciente.Apellidopaterno+"              "+paciente.Rut+"-"+paciente.Digitoverificador);
            }
        }
        
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show();
            this.Close();
        }
    }
}