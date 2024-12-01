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
        public Paciente pac;//Paciente
        
        public List<Medico> medicos;//Medicos de los cuales se va a elegir
        public bool PacienteEsNuevo;//Booleano para saber si estamos tratando con paciente nuevo o modificado
       public IngresoHoraWindow()
        {
            InitializeComponent();
        }
        public IngresoHoraWindow(Secretario sec, Paciente PNuevo, bool PEsNuevo)
        {
            this.PacienteEsNuevo = PEsNuevo;
            this.sec = sec;
            pac = PNuevo;
            this.medicos = this.sec.MedicosClinica;
            

            InitializeComponent();


            LbDoctores.ItemsSource = sec.MedicosClinica;
            LbDoctores.SelectedItem= null;
            
        }


        private void ConfirmarH(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (PacienteEsNuevo)

            {   
                //CASO PACIENTE NUEVO
                try
                {
                    Medico medicoElegido = (Medico)LbDoctores.SelectedItem;
                    DateTime horaElegida = ((HoraFechaDTime)LbHdisp.SelectedItem).DatetimeS;
                    pac.Fechaatencion = horaElegida;
                    foreach (Medico med in medicos)
                    {
                        if (med.NombreAp == medicoElegido.NombreAp)
                        {
                            med.ElimHoraDisponible(horaElegida);
                            med.Pacientes.Add(pac);
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
            } else
            {   
                //CASO PARA MODIFICAR HORA DE UN PACIENTE EXISTENTE
                Medico medicoElegido = (Medico)LbDoctores.SelectedItem;
                DateTime horaElegida = ((HoraFechaDTime)LbHdisp.SelectedItem).DatetimeS;
                DateTime horaLiberada = pac.Fechaatencion;

                //Ciclo for busca medico que tiene al paciente para liberarle la hora y remover paciente
               foreach(Medico Med in medicos)
                {
                    if(Med.Pacientes.Contains(this.pac))
                    {
                        Med.Pacientes.Remove(this.pac);
                        Med.AddHoraDisponible(horaLiberada);
                    }

                }    

                
                //Ciclo que añade paciente a medico ocupando su hora disponible
                foreach (Medico med in medicos)
                {
                    if (med.NombreAp == medicoElegido.NombreAp)
                    {
                        med.ElimHoraDisponible(horaElegida);
                        med.Pacientes.Add(pac);
                    }
                }
                this.sec.MedicosClinica = medicos;//Se guardan los medicos en sec
                var menuWindow = new MenuWindow(sec);
                menuWindow.Show(); // Se abre menu de nuevo
                this.Close();
            }
        }
        private void VolverAtras(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (PacienteEsNuevo)
            {
                var IngresoAtras = new IngresoWindow(sec);
                //La pantalla de ingreso paciente va a estar vacia
                IngresoAtras.Show();
                this.Close();
            }
            else
            {
                var ModAtras =new ModHoraWindow(sec);
                ModAtras.Show();
                this.Close();
            }
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