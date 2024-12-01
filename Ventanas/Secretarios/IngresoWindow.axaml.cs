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

    public struct ComboBoxIngreso//Struct para manejar mas facil el comboBox
    {
        private string previsionString;
        private prevision_t prev;

        public string PrevisionString { get => previsionString; set => previsionString = value; }
        public prevision_t Prev { get => prev; set => prev = value; }
    }
    public partial class IngresoWindow : Window
    {
        public Secretario sec;

        public List<ComboBoxIngreso> comboBoxIngreso = new List<ComboBoxIngreso>
        {
            new ComboBoxIngreso{ PrevisionString="Fonasa", Prev=prevision_t.FONASA},
            new ComboBoxIngreso{ PrevisionString="Banmédica" , Prev=prevision_t.BANMEDICA},
            new ComboBoxIngreso{ PrevisionString="Colmena" , Prev=prevision_t.COLMENA },
            new ComboBoxIngreso{ PrevisionString="Consalud" , Prev=prevision_t.CONSALUD },
            new ComboBoxIngreso{ PrevisionString="Cruz Blanca" , Prev=prevision_t.CRUZBLANCA },
            new ComboBoxIngreso{ PrevisionString= "Nueva Mas Vida", Prev=prevision_t.NUEVA_MAS_VIDA },
            new ComboBoxIngreso{ PrevisionString="Vida Tres" , Prev=prevision_t.VIDA_TRES },
            new ComboBoxIngreso{ PrevisionString= "Fundacion Banco Estado", Prev=prevision_t.FUNDACION_BANCO_DEL_ESTADO }

        };

        public IngresoWindow()
        {
            InitializeComponent();
        }
        public IngresoWindow(Secretario secr)
        {
            this.sec = secr;
            InitializeComponent();
            CboxPrevision.ItemsSource = comboBoxIngreso;
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
                pacienteNuevo.Prevision = ((ComboBoxIngreso)CboxPrevision.SelectedItem).Prev;//Se castea manual el tipo pq ComboBox devuelve un tipo object generico



                if (BoolTutor.IsChecked == true)
                {
                    Tutor tutor = new Tutor();
                    tutor.Nombre = tbTNombres.Text;
                    string[] RT = tbTRUT.Text.Split('-');
                    tutor.Rut = int.Parse(RT[0]);
                    tutor.Digitoverificador = int.Parse(R[1]);
                    DateTimeOffset dpOff2 = dpTNacimiento.SelectedDate ?? DateTimeOffset.Now;//?? es un operador para cambiar de algo que recibe null a algo normal
                    tutor.Fechanacimiento = dpOff2.DateTime;
                    tutor.Apellidopaterno = tbTApellidoPaterno.Text;
                    tutor.Apellidomaterno = tbTApellidoMaterno.Text;
                    tutor.Telefono = int.Parse(tbTTelefono.Text);
                    tutor.Email = tbTMail.Text;
                    pacienteNuevo.TieneTutor = true;
                    pacienteNuevo.Tutor = tutor;
                }
                pacienteNuevo.Ficha = new FichaMedica();
                //Ficha vacia ingresada
                pacienteNuevo.Ficha.Antecedentes = " ";
                pacienteNuevo.Ficha.Observaciones = " ";
                pacienteNuevo.Ficha.Alergias = " ";
                pacienteNuevo.Ficha.GrupoSanguineo = GrupoSanguineo.A;
                var ingresoHoraWindow = new IngresoHoraWindow(sec, pacienteNuevo, true);

                ingresoHoraWindow.Show(); // Muestra la ventana secundaria
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorWindow err = new ErrorWindow();
                if (ex is NullReferenceException)
                {
                    err.ErrorMsg.Text = "Ingrese Datos Validos";
                }
                else
                {
                    err.ErrorMsg.Text = ex.Message;

                }


                err.Show();
            }
        }
    }
}

    
