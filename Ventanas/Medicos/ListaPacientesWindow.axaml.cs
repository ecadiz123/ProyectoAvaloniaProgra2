using Avalonia.Controls;
using Newtonsoft.Json;
using System.Collections.Generic;
using ProyectoConsultorio.Clases;
using System.Linq;
using ProyectoConsultorio.Clinica.Usuarios;
using ProyectoConsultorio.Clinica.Clientes;

namespace ProyectoConsultorio
{
    
    public partial class ListaPacientesWindow : Window
    {
        public Medico med;
        public ListaPacientesWindow(Medico medico)
        {
            this.med = medico;
            InitializeComponent();

            foreach(Paciente pac in med.Pacientes)
            {
                lbPacientes.Items.Add(pac.Nombre+" "+pac.Apellidopaterno+"\t\t\t"+pac.Rut+"-"+pac.Digitoverificador);
            }
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow(med);
           
            medMenuWindow.Show();

            this.Close();
        }
    }
}