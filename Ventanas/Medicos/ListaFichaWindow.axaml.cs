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
        public ListaFichaWindow(Medico medico)
        {
            this.med = medico;
            InitializeComponent();

            foreach (Paciente pac in med.Pacientes)
            {
                lbPacientes.Items.Add(pac);
                
            }
            
        }

        private void btModPaciente(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                if (lbPacientes.SelectedItem is Paciente pacienteSel)
                {
                    var modFichasWindow = new ModFichasWindow(this.med, pacienteSel, pacienteSel.Ficha);
                    modFichasWindow.Show(); // Muestra la ventana secundaria
                    this.Close();

                }
                



              
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
            var medMenuWindow = new MedMenuWindow(med);
            
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}