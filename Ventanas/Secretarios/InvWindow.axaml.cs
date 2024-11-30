using Avalonia.Controls;
using Avalonia.Interactivity;
using ProyectoConsultorio.Clinica.Inventario;
using ProyectoConsultorio.Clinica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoConsultorio
{
    public partial class InvWindow : Window
    {
        private Secretario secretario;
        // Listas para gestionar las cantidades de los insumos y medicamentos
        private List<Insumo> limpiezaSalaEspera = new List<Insumo>();
        private List<Insumo> insumosBox1 = new List<Insumo>();
        private List<Insumo> medicamentosBox1 = new List<Insumo>();
        private List<Insumo> insumosBox2 = new List<Insumo>();
        private List<Insumo> medicamentosBox2 = new List<Insumo>();

        public InvWindow()
        {
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

            if (!limpiezaSalaEspera.Any(i => i.Nombre == insumo))
            {
                limpiezaSalaEspera.Add(new Insumo { Nombre = insumo, Cantidad = 0 });
            }

            tbInsumoSalaEspera.Clear();
            ActualizarListaSalaEspera();
        }

        private void SumarInsumoSalaEspera(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoSalaEspera.Text.Trim();
            if (!string.IsNullOrEmpty(insumo))
            {
                var item = limpiezaSalaEspera.FirstOrDefault(i => i.Nombre == insumo);
                if (item != null && int.TryParse(tbCantidadSalaEspera.Text, out int cantidad))
                {
                    item.Cantidad += cantidad;
                    tbCantidadSalaEspera.Clear();
                    ActualizarListaSalaEspera();
                }
            }
        }

        private void RestarInsumoSalaEspera(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoSalaEspera.Text.Trim();
            if (!string.IsNullOrEmpty(insumo))
            {
                var item = limpiezaSalaEspera.FirstOrDefault(i => i.Nombre == insumo);
                if (item != null && int.TryParse(tbCantidadSalaEspera.Text, out int cantidad))
                {
                    item.Cantidad -= cantidad;
                    if (item.Cantidad < 0)
                    {
                        item.Cantidad = 0;
                    }
                    tbCantidadSalaEspera.Clear();
                    ActualizarListaSalaEspera();
                }
            }
        }

        private void ActualizarListaSalaEspera()
        {
            lbLimpiezaSalaEspera.ItemsSource = limpiezaSalaEspera.Select(i => $"{i.Nombre} - {i.Cantidad}").ToList();
        }

        // Agregar un nuevo insumo o medicamento en Box 1
        private void btAddNewInsumoBox1_Click(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox1.Text.Trim();
            if (string.IsNullOrEmpty(insumo)) return;

            if (!insumosBox1.Any(i => i.Nombre == insumo))
            {
                insumosBox1.Add(new Insumo { Nombre = insumo, Cantidad = 0 });
            }

            tbInsumoBox1.Clear();
            ActualizarListaBox1();
        }

        private void btAddNewMedicamentoBox1_Click(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox1.Text.Trim();
            if (string.IsNullOrEmpty(medicamento)) return;

            if (!medicamentosBox1.Any(i => i.Nombre == medicamento))
            {
                medicamentosBox1.Add(new Insumo { Nombre = medicamento, Cantidad = 0 });
            }

            tbMedicamentoBox1.Clear();
            ActualizarListaBox1();
        }

        private void SumarInsumoBox1(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(insumo))
            {
                var item = insumosBox1.FirstOrDefault(i => i.Nombre == insumo);
                if (item != null && int.TryParse(tbCantidadBox1.Text, out int cantidad))
                {
                    item.Cantidad += cantidad;
                    tbCantidadBox1.Clear();
                    ActualizarListaBox1();
                }
            }
        }

        private void RestarInsumoBox1(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(insumo))
            {
                var item = insumosBox1.FirstOrDefault(i => i.Nombre == insumo);
                if (item != null && int.TryParse(tbCantidadBox1.Text, out int cantidad))
                {
                    item.Cantidad -= cantidad;
                    if (item.Cantidad < 0)
                    {
                        item.Cantidad = 0;
                    }
                    tbCantidadBox1.Clear();
                    ActualizarListaBox1();
                }
            }
        }

        private void SumarMedicamentoBox1(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento))
            {
                var item = medicamentosBox1.FirstOrDefault(i => i.Nombre == medicamento);
                if (item != null && int.TryParse(tbCantidadBox1Medicamentos.Text, out int cantidad))
                {
                    item.Cantidad += cantidad;
                    tbCantidadBox1Medicamentos.Clear();
                    ActualizarListaBox1();
                }
            }
        }

        private void RestarMedicamentoBox1(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox1.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento))
            {
                var item = medicamentosBox1.FirstOrDefault(i => i.Nombre == medicamento);
                if (item != null && int.TryParse(tbCantidadBox1Medicamentos.Text, out int cantidad))
                {
                    item.Cantidad -= cantidad;
                    if (item.Cantidad < 0)
                    {
                        item.Cantidad = 0;
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
                items.Add($"{insumo.Nombre} - {insumo.Cantidad} (Insumo)");

            lbLimpiezaBox1.ItemsSource = items;

            // Agregar medicamentos de Box 1
            var medicamentoItems = new List<string>();
            foreach (var medicamento in medicamentosBox1)
                medicamentoItems.Add($"{medicamento.Nombre} - {medicamento.Cantidad} (Medicamento)");

            lbMedicamentosBox1.ItemsSource = medicamentoItems;
        }

        // Agregar un nuevo insumo o medicamento en Box 2
        private void btAddNewInsumoBox2_Click(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox2.Text.Trim();
            if (string.IsNullOrEmpty(insumo)) return;

            if (!insumosBox2.Any(i => i.Nombre == insumo))
            {
                insumosBox2.Add(new Insumo { Nombre = insumo, Cantidad = 0 });
            }

            tbInsumoBox2.Clear();
            ActualizarListaBox2();
        }

        private void btAddNewMedicamentoBox2_Click(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox2.Text.Trim();
            if (string.IsNullOrEmpty(medicamento)) return;

            if (!medicamentosBox2.Any(i => i.Nombre == medicamento))
            {
                medicamentosBox2.Add(new Insumo { Nombre = medicamento, Cantidad = 0 });
            }

            tbMedicamentoBox2.Clear();
            ActualizarListaBox2();
        }

        private void SumarInsumoBox2(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(insumo))
            {
                var item = insumosBox2.FirstOrDefault(i => i.Nombre == insumo);
                if (item != null && int.TryParse(tbCantidadBox2.Text, out int cantidad))
                {
                    item.Cantidad += cantidad;
                    tbCantidadBox2.Clear();
                    ActualizarListaBox2();
                }
            }
        }

        private void RestarInsumoBox2(object sender, RoutedEventArgs e)
        {
            string insumo = tbInsumoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(insumo))
            {
                var item = insumosBox2.FirstOrDefault(i => i.Nombre == insumo);
                if (item != null && int.TryParse(tbCantidadBox2.Text, out int cantidad))
                {
                    item.Cantidad -= cantidad;
                    if (item.Cantidad < 0)
                    {
                        item.Cantidad = 0;
                    }
                    tbCantidadBox2.Clear();
                    ActualizarListaBox2();
                }
            }
        }

        private void SumarMedicamentoBox2(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento))
            {
                var item = medicamentosBox2.FirstOrDefault(i => i.Nombre == medicamento);
                if (item != null && int.TryParse(tbCantidadBox2Medicamentos.Text, out int cantidad))
                {
                    item.Cantidad += cantidad;
                    tbCantidadBox2Medicamentos.Clear();
                    ActualizarListaBox2();
                }
            }
        }

        private void RestarMedicamentoBox2(object sender, RoutedEventArgs e)
        {
            string medicamento = tbMedicamentoBox2.Text.Trim();
            if (!string.IsNullOrEmpty(medicamento))
            {
                var item = medicamentosBox2.FirstOrDefault(i => i.Nombre == medicamento);
                if (item != null && int.TryParse(tbCantidadBox2Medicamentos.Text, out int cantidad))
                {
                    item.Cantidad -= cantidad;
                    if (item.Cantidad < 0)
                    {
                        item.Cantidad = 0;
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
                items.Add($"{insumo.Nombre} - {insumo.Cantidad} (Insumo)");

            lbLimpiezaBox2.ItemsSource = items;

            // Agregar medicamentos de Box 2
            var medicamentoItems = new List<string>();
            foreach (var medicamento in medicamentosBox2)
                medicamentoItems.Add($"{medicamento.Nombre} - {medicamento.Cantidad} (Medicamento)");

            lbMedicamentosBox2.ItemsSource = medicamentoItems;
        }
    }

    // Clase Insumo para manejar los elementos (insumos o medicamentos)
    public class Insumo
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}


