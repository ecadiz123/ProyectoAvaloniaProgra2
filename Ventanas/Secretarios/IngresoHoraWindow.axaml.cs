using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Collections.Generic;

namespace ProyectoConsultorio
{
    public struct HoraFechaDTime
    {
        private DateTime datetimeS;
        private string horaFecha;

        public DateTime DatetimeS { get => datetimeS; set => datetimeS = value; }
        public string HoraFecha { get => horaFecha; set => horaFecha = value; }
    }
    public partial class IngresoHoraWindow : Window
    {
        public Secretario sec;
        public Paciente nP;//Nuevo paciente
        public List<Medico> medicos;//Medicos de los cuales se va a elegir
       public IngresoHoraWindow()
        {
            InitializeComponent();
        }
        public IngresoHoraWindow(Secretario sec, Paciente PNuevo)
        {
            this.sec = sec;
            nP = PNuevo;
            this.medicos = this.sec.MedicosClinica;
            

            InitializeComponent();


            LbDoctores.ItemsSource = sec.MedicosClinica;
            LbDoctores.SelectedItem= null;
            
        }
     

        private void ConfirmarH(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                Medico medicoElegido= (Medico)LbDoctores.SelectedItem;
                DateTime horaElegida= ((HoraFechaDTime)LbHdisp.SelectedItem).DatetimeS;
                nP.Fechaatencion = horaElegida;
                foreach (Medico med in medicos)
                {
                    if(med.NombreAp==medicoElegido.NombreAp)
                    {
                        med.ElimHoraDisponible(horaElegida);
                        med.Pacientes.Add(nP);
                    }
                }
                sec.MedicosClinica = medicos;//Se guardan los cambios hechos a la lista de medicos en secretario que maneja todo eso
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
        private void VolverAtras(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var IngresoAtras = new IngresoWindow(sec);
            //La pantalla de ingreso paciente va a estar vacia
            IngresoAtras.Show();
            this.Close();
        }

        //Responde al seleccionar un medico en la lista
        private void ListBox_SelectionChanged(object? sender, Avalonia.Controls.SelectionChangedEventArgs e)
        {
            Medico elegido= (Medico)LbDoctores.SelectedItem;
            List<HoraFechaDTime> hfecha= new List<HoraFechaDTime>();
            foreach (DateTime datetime in elegido.HorasDisponibles)
            {
                HoraFechaDTime h=new HoraFechaDTime() {DatetimeS=datetime, HoraFecha= datetime.ToString()};
                hfecha.Add(h);
            }
            LbHdisp.ItemsSource = hfecha;
        }
    }
}