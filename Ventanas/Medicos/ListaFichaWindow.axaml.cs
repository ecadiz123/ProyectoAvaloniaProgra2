using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class ListaFichaWindow : Window
    {
        public Medico med;
        public ListaFichaWindow()
        {
            InitializeComponent();

            foreach (Paciente pac in med.Pacientes)
            {
                lbPacientes.Items.Add(pac.Rut);
            }
            
        }

        private void btModPaciente(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                var modFichasWindow = new ModFichasWindow();
                string pacienteRut = Convert.ToString(lbPacientes.SelectedItem);
                Paciente pacienteSelec = med.Pacientes.Find(x => x.Rut == int.Parse(pacienteRut));
                modFichasWindow.med = med;
                modFichasWindow.fichaActual = pacienteSelec.Ficha;
                modFichasWindow.Show(); // Muestra la ventana secundaria
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorWindow err = new ErrorWindow();
                err.ErrorMsg.Text = ex.Message;
                err.Show();
            }
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.medico = med;
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}