using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Usuarios;
using System.Linq;
using System.Collections.Generic;

namespace ProyectoConsultorio
{
    public struct MedyPac
    {
        private Paciente pac;
        private Medico med;
        private string medYPac;//String que va a mostrar al medico con su paciente en la list box
        public Paciente Pac { get => pac; set => pac = value; }
        public Medico Med { get => med; set => med = value; }
        public string MedYPac { get => medYPac; set => medYPac = value; }
    }
    public partial class ModHoraWindow : Window
    {
        public Secretario sec;
        public List<MedyPac> medicosYPacientesDeLaClinica;
        public ModHoraWindow()
        {
            InitializeComponent();
        }
        public ModHoraWindow(Secretario secre)
        {
            medicosYPacientesDeLaClinica = new List<MedyPac>();
            this.sec = secre;
            InitializeComponent();
            foreach(Medico med in sec.MedicosClinica)
            {
                foreach(Paciente pac in med.Pacientes)
                {
                    MedyPac medicoypaciente= new MedyPac();
                    medicoypaciente.Med = med;
                    medicoypaciente.Pac = pac;
                    medicoypaciente.MedYPac = med.NombreAp + "\t\t\t\t" + pac.Nombre + " " + pac.Apellidopaterno;//String del medico + paciente
                    medicosYPacientesDeLaClinica.Add(medicoypaciente);
                }
            }


            lbPacientes.ItemsSource = medicosYPacientesDeLaClinica;
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var menuWindow = new MenuWindow(sec);
            menuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void Modificar(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MedyPac elegido = (MedyPac)lbPacientes.SelectedItem;

            Paciente Pelegido = new Paciente();
            Medico Melegido= new Medico();
            Pelegido = elegido.Pac;
            
            var modHora = new IngresoHoraWindow(sec, Pelegido, false);
            modHora.Show();
            this.Close();

        }
    }
}