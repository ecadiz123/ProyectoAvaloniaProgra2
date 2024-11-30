using Avalonia.Controls;
using Avalonia.Interactivity;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class InvWindow : Window
    {
        // Diccionarios para gestionar las cantidades de los insumos y medicamentos
        private Dictionary<string, int> limpiezaSalaEspera = new Dictionary<string, int>();
        private Dictionary<string, int> insumosBox1 = new Dictionary<string, int>();
        private Dictionary<string, int> medicamentosBox1 = new Dictionary<string, int>();
        private Dictionary<string, int> insumosBox2 = new Dictionary<string, int>();
        private Dictionary<string, int> medicamentosBox2 = new Dictionary<string, int>();
        public Secretario sec;
        public InvWindow(Secretario secre)
        { 
            this.sec = secre;
            InitializeComponent();
        }

        // Volver al menú
        private void VolverMenu(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Agregar un nuevo insumo en la Sala de Espera (solo insumos de limpieza)
        private void btAddNewInsumoSalaEspera_Click(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoSalaEspera.Text.Trim();
            if (string.IsNullOrEmpty(insumo))
            {
                return;
            }

            if (!limpiezaSalaEspera.ContainsKey(insumo))
            {
                limpiezaSalaEspera.Add(insumo, 0);
            }

            tbInsumoSalaEspera.Clear();
            ActualizarListaSalaEspera();
        }

        private void SumarInsumoSalaEspera(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoSalaEspera.Text.Trim();
            if (!string.IsNullOrEmpty(insumo) && limpiezaSalaEspera.ContainsKey(insumo))
            {
                if (int.TryParse(tbCantidadSalaEspera.Text, out int cantidad))
                {
                    limpiezaSalaEspera[insumo] += cantidad;
                    tbCantidadSalaEspera.Clear();
                    ActualizarListaSalaEspera();
                }
            }
        }

        private void RestarInsumoSalaEspera(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoSalaEspera.Text.Trim();
            if (!string.IsNullOrEmpty(insumo) && limpiezaSalaEspera.ContainsKey(insumo))
            {
                if (int.TryParse(tbCantidadSalaEspera.Text, out int cantidad))
                {
                    limpiezaSalaEspera[insumo] -= cantidad;
                    if (limpiezaSalaEspera[insumo] < 0)
                    {
                        limpiezaSalaEspera[insumo] = 0;
                    }
                    tbCantidadSalaEspera.Clear();
                    ActualizarListaSalaEspera();
                }
            }
        }

        private void ActualizarListaSalaEspera()
        {
            lbLimpiezaSalaEspera.ItemsSource = limpiezaSalaEspera.Select(i => $"{i.Key} - {i.Value}").ToList();
        }

        // Agregar un nuevo insumo o medicamento en Box 1
        private void btAddNewInsumoBox1_Click(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox1.Text.Trim();
            if (string.IsNullOrEmpty(insumo)) return;

            if (!insumosBox1.ContainsKey(insumo))
            {
                insumosBox1.Add(insumo, 0);
            }

            tbInsumoBox1.Clear();
            ActualizarListaBox1();
        }

        private void btAddNewMedicamentoBox1_Click(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox1.Text.Trim();
            if (string.IsNullOrEmpty(medicamento)) return;

            if (!medicamentosBox1.ContainsKey(medicamento))
            {
                medicamentosBox1.Add(medicamento, 0);
            }

            tbMedicamentoBox1.Clear();
            ActualizarListaBox1();
        }

        private void SumarInsumoBox1(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(insumo) && insumosBox1.ContainsKey(insumo))
            {
                if (int.TryParse(tbCantidadBox1.Text, out int cantidad))
                {
                    insumosBox1[insumo] += cantidad;
                    tbCantidadBox1.Clear();
                    ActualizarListaBox1();
                }
            }
        }

        private void RestarInsumoBox1(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(insumo) && insumosBox1.ContainsKey(insumo))
            {
                if (int.TryParse(tbCantidadBox1.Text, out int cantidad))
                {
                    insumosBox1[insumo] -= cantidad;
                    if (insumosBox1[insumo] < 0)
                    {
                        insumosBox1[insumo] = 0;
                    }
                    tbCantidadBox1.Clear();
                    ActualizarListaBox1();
                }
            }
        }

        private void SumarMedicamentoBox1(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento) && medicamentosBox1.ContainsKey(medicamento))
            {
                if (int.TryParse(tbCantidadBox1Medicamentos.Text, out int cantidad))
                {
                    medicamentosBox1[medicamento] += cantidad;
                    tbCantidadBox1Medicamentos.Clear();
                    ActualizarListaBox1();
                }
            }
        }

        private void RestarMedicamentoBox1(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento) && medicamentosBox1.ContainsKey(medicamento))
            {
                if (int.TryParse(tbCantidadBox1Medicamentos.Text, out int cantidad))
                {
                    medicamentosBox1[medicamento] -= cantidad;
                    if (medicamentosBox1[medicamento] < 0)
                    {
                        medicamentosBox1[medicamento] = 0;
                    }
                    tbCantidadBox1Medicamentos.Clear();
                    ActualizarListaBox1();
                }
            }
        }

        private void ActualizarListaBox1()
        {
            var items = new List<string>();

            // Agregar insumos de Box 1
            foreach (var insumo in insumosBox1)
                items.Add($"{insumo.Key} - {insumo.Value} (Insumo)");

            lbLimpiezaBox1.ItemsSource = items;

            // Agregar medicamentos de Box 1
            var medicamentoItems = new List<string>();
            foreach (var medicamento in medicamentosBox1)
                medicamentoItems.Add($"{medicamento.Key} - {medicamento.Value} (Medicamento)");

            lbMedicamentosBox1.ItemsSource = medicamentoItems;
        }

        // Agregar un nuevo insumo o medicamento en Box 2
        private void btAddNewInsumoBox2_Click(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox2.Text.Trim();
            if (string.IsNullOrEmpty(insumo)) return;

            if (!insumosBox2.ContainsKey(insumo))
            {
                insumosBox2.Add(insumo, 0);
            }

            tbInsumoBox2.Clear();
            ActualizarListaBox2();
        }

        private void btAddNewMedicamentoBox2_Click(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox2.Text.Trim();
            if (string.IsNullOrEmpty(medicamento)) return;

            if (!medicamentosBox2.ContainsKey(medicamento))
            {
                medicamentosBox2.Add(medicamento, 0);
            }

            tbMedicamentoBox2.Clear();
            ActualizarListaBox2();
        }

        private void SumarInsumoBox2(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(insumo) && insumosBox2.ContainsKey(insumo))
            {
                if (int.TryParse(tbCantidadBox2.Text, out int cantidad))
                {
                    insumosBox2[insumo] += cantidad;
                    tbCantidadBox2.Clear();
                    ActualizarListaBox2();
                }
            }
        }

        private void RestarInsumoBox2(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(insumo) && insumosBox2.ContainsKey(insumo))
            {
                if (int.TryParse(tbCantidadBox2.Text, out int cantidad))
                {
                    insumosBox2[insumo] -= cantidad;
                    if (insumosBox2[insumo] < 0)
                    {
                        insumosBox2[insumo] = 0;
                    }
                    tbCantidadBox2.Clear();
                    ActualizarListaBox2();
                }
            }
        }

        private void SumarMedicamentoBox2(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento) && medicamentosBox2.ContainsKey(medicamento))
            {
                if (int.TryParse(tbCantidadBox2Medicamentos.Text, out int cantidad))
                {
                    medicamentosBox2[medicamento] += cantidad;
                    tbCantidadBox2Medicamentos.Clear();
                    ActualizarListaBox2();
                }
            }
        }

        private void RestarMedicamentoBox2(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento) && medicamentosBox2.ContainsKey(medicamento))
            {
                if (int.TryParse(tbCantidadBox2Medicamentos.Text, out int cantidad))
                {
                    medicamentosBox2[medicamento] -= cantidad;
                    if (medicamentosBox2[medicamento] < 0)
                    {
                        medicamentosBox2[medicamento] = 0;
                    }
                    tbCantidadBox2Medicamentos.Clear();
                    ActualizarListaBox2();
                }
            }
        }

        private void ActualizarListaBox2()
        {
            var items = new List<string>();

            // Agregar insumos de Box 2
            foreach (var insumo in insumosBox2)
                items.Add($"{insumo.Key} - {insumo.Value} (Insumo)");

            lbLimpiezaBox2.ItemsSource = items;

            // Agregar medicamentos de Box 2
            var medicamentoItems = new List<string>();
            foreach (var medicamento in medicamentosBox2)
                medicamentoItems.Add($"{medicamento.Key} - {medicamento.Value} (Medicamento)");

            lbMedicamentosBox2.ItemsSource = medicamentoItems;
        }


    }
}

