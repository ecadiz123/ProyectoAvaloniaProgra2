using Avalonia.Controls;
using ProyectoConsultorio.Clinica.Clientes;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using Avalonia.Media;
using System.Collections.Generic;
using ProyectoConsultorio.Clinica;
using System;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio
{
    public partial class IngresoWindow : Window
    {
        public Secretario sec;
      
        
        public IngresoWindow()
        {
            InitializeComponent();
        }
        public IngresoWindow(Secretario secr)
        {
            this.sec = secr;
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
       
     
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow(sec);
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }

        private void IngresoDatos(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                
                Paciente pacienteNuevo = new Paciente();
                pacienteNuevo.Nombre = tbNombres.Text;
                
                string[] R = tbRUT.Text.Split('-');
                pacienteNuevo.Rut = int.Parse(R[0]);
                pacienteNuevo.Digitoverificador = int.Parse(R[1]);
                DateTimeOffset dpOff = dpNacimiento.SelectedDate ?? DateTimeOffset.Now;
                pacienteNuevo.Fechanacimiento = dpOff.DateTime;
                pacienteNuevo.Apellidopaterno = tbApellidoPaterno.Text;
                pacienteNuevo.Apellidomaterno = tbApellidoMaterno.Text;
                pacienteNuevo.Telefono = int.Parse(tbTelefono.Text);
                pacienteNuevo.Email = tbMail.Text;

               

                if(BoolTutor.IsChecked==true)
                {
                    Tutor tutor = new Tutor();
                    tutor.Nombre = tbTNombres.Text;
                    string[] RT = tbTRUT.Text.Split('-');
                    tutor.Rut = int.Parse(RT[0]);
                    tutor.Digitoverificador = int.Parse(R[1]);
                    DateTimeOffset dpOff2 = dpTNacimiento.SelectedDate ?? DateTimeOffset.Now;
                    tutor.Fechanacimiento = dpOff2.DateTime;
                    tutor.Apellidopaterno = tbTApellidoPaterno.Text;
                    tutor.Apellidomaterno = tbTApellidoMaterno.Text;
                    tutor.Telefono = int.Parse(tbTTelefono.Text);
                    tutor.Email = tbTMail.Text;
                    pacienteNuevo.TieneTutor = true;
                    pacienteNuevo.Tutor=tutor;
                }
                pacienteNuevo.Ficha = new FichaMedica();
                //Ficha vacia ingresada
                pacienteNuevo.Ficha.Antecedentes = " ";
                pacienteNuevo.Ficha.Observaciones = " ";
                pacienteNuevo.Ficha.Alergias = " ";
                pacienteNuevo.Ficha.GrupoSanguineo = GrupoSanguineo.A;
                var ingresoHoraWindow = new IngresoHoraWindow(sec,pacienteNuevo);
               
                ingresoHoraWindow.Show(); // Muestra la ventana secundaria
                this.Close();
            }
            catch(Exception ex)
            {
                ErrorWindow err = new ErrorWindow();
                err.ErrorMsg.Text = ex.Message;
                err.ErrorMsg.Text += ex.Source;
                err.Show();
            }
        }

    }
}