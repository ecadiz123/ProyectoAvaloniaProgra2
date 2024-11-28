using Avalonia.Controls;
using ProyectoConsultorio.Clases;
using ProyectoConsultorio.Clinica.Clientes;
using ProyectoConsultorio.Clinica.Usuarios;

namespace ProyectoConsultorio
{
    public partial class ModFichasWindow : Window
    {
        public Medico med;
        public Paciente pacienteActual;
        public FichaMedica fichaActual;
        public ModFichasWindow(Medico medico, Paciente pactual, FichaMedica ficha)
        {
            this.med = medico;
            this.pacienteActual=pactual;
            this.fichaActual = ficha;
            InitializeComponent();
            GrupoSanguineo gsFicha = fichaActual.GrupoSanguineo;

            if (gsFicha == GrupoSanguineo.A)
                rbA.IsChecked = true;
            if (gsFicha == GrupoSanguineo.B)
                rbB.IsChecked = true;
            if (gsFicha == GrupoSanguineo.AB) 
                rbAB.IsChecked = true;
            if (gsFicha == GrupoSanguineo.O)
                rbO.IsChecked = true;
            tbAlergias.Text = fichaActual.Alergias;
            tbAntecedentes.Text = fichaActual.Antecedentes;
            tbObs.Text = fichaActual.Observaciones;
        }
        private void VolverMenu(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var medMenuWindow = new MedMenuWindow();
            medMenuWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
        private void FichaMedica(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            GrupoSanguineo GS = GrupoSanguineo.A;

            if (rbA.IsChecked == true)
                GS = GrupoSanguineo.A;
            if (rbB.IsChecked == true)
                GS = GrupoSanguineo.B;
            if (rbAB.IsChecked == true)
                GS = GrupoSanguineo.AB;
            if (rbO.IsChecked == true)
                GS = GrupoSanguineo.O;

            fichaActual.GrupoSanguineo = GS;
            fichaActual.Alergias = tbAlergias.Text;
            fichaActual.Antecedentes = tbAntecedentes.Text;
            fichaActual.Observaciones = tbObs.Text;
            var listaFichaWindow = new ListaFichaWindow(this.med);
            listaFichaWindow.Show(); // Muestra la ventana secundaria
            this.Close();
        }
    }
}