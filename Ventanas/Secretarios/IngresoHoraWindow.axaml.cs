using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Collections.Generic;

namespace ProyectoConsultorio
{
    public partial class IngresoHoraWindow : Window
    {
        public Secretario sec;
        public Paciente nP;
        public List<Medico> medicos;
       public IngresoHoraWindow()
        {
            InitializeComponent();
        }
        public IngresoHoraWindow(Secretario sec, Paciente PNuevo)
        {
            this.sec = sec;
            nP = PNuevo;
            medicos = sec.MedicosClinica;
            
            InitializeComponent();


        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            List<DateTime> horasDiaElegido= new List<DateTime>();
            LbHdisp.ItemsSource = horasDiaElegido;

        }
        private void ConfirmarH(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                //Ver hora elegida en calendario 







                var menuWindow = new MenuWindow(sec);
                menuWindow.Show(); // Muestra la ventana secundaria
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorWindow err = new ErrorWindow();
                err.ErrorMsg.Text = ex.Message;
            }
        }
    }
}