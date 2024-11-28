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
        public List<Paciente> ListaPacientes { get; set; } = new List<Paciente>();
        public List<Tutor> ListaTutores { get; set; } = new List<Tutor>();
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
       
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
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
                var ingresoHoraWindow = new IngresoHoraWindow();
                Paciente pacienteNuevo = new Paciente();
                pacienteNuevo.Nombre = tbNombres.Text;
                string d = tbRUT.Text.Split('-')[1];
                pacienteNuevo.Rut = int.Parse(tbRUT.Text);
                pacienteNuevo.Digitoverificador = int.Parse(d);
                DateTimeOffset dpOff = dpNacimiento.SelectedDate ?? DateTimeOffset.Now;
                pacienteNuevo.Fechanacimiento = dpOff.DateTime;
                pacienteNuevo.Apellidopaterno = tbApellidoPaterno.Text;
                pacienteNuevo.Apellidomaterno = tbApellidoMaterno.Text;
                pacienteNuevo.Telefono = int.Parse(tbTelefono.Text);
                pacienteNuevo.Email = tbMail.Text;

                prevision_t prev = prevision_t.FONASA;
                if(CboxPrevision.SelectedItem.ToString()=="Fonasa")
                    prev = prevision_t.FONASA;
                if (CboxPrevision.SelectedItem.ToString() == "Banmédica")
                    prev = prevision_t.BANMEDICA;
                if ((CboxPrevision.SelectedItem.ToString() == "Colmena"))
                    prev = prevision_t.COLMENA;
                if ((CboxPrevision.SelectedItem.ToString() == "Consalud"))
                    prev = prevision_t.CONSALUD;
                if ((CboxPrevision.SelectedItem.ToString() == "Cruz Blanca"))
                    prev= prevision_t.CRUZBLANCA;
                if ((CboxPrevision.SelectedItem.ToString()=="Más Vida"))
                    prev=prevision_t.NUEVA_MAS_VIDA;
                if (((CboxPrevision.SelectedItem.ToString() == "Vida Tres")))
                    prev = prevision_t.VIDA_TRES;
                if (((CboxPrevision.SelectedItem.ToString() == "Fundacion Banco Estado")))
                    prev = prevision_t.FUNDACION_BANCO_DEL_ESTADO;
                pacienteNuevo.Prevision = prev;




                        ingresoHoraWindow.Show(); // Muestra la ventana secundaria
                this.Close();
            }
            catch(Exception ex)
            {
                ErrorWindow err = new ErrorWindow();
                err.ErrorMsg.Text = ex.Message;
                err.Show();
            }
        }

    }
}