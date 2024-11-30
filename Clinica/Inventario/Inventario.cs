using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ProyectoConsultorio.Clinica.Inventario
{
    public class Inventario
    {
        public List<IInsumo> Limpieza { get; set; } = new List<IInsumo>();
        public List<IInsumo> Desechables { get; set; } = new List<IInsumo>();
        public List<IInsumo> Medicamentos { get; set; } = new List<IInsumo>();

        private const string ArchivoJson = "inventario.json";

        // Cargar inventario desde JSON
        public void CargarInventario()
        {
            if (File.Exists(ArchivoJson))
            {
                var jsonData = File.ReadAllText(ArchivoJson);
                var inventario = JsonSerializer.Deserialize<Inventario>(jsonData, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (inventario != null)
                {
                    Limpieza = inventario.Limpieza;
                    Desechables = inventario.Desechables;
                    Medicamentos = inventario.Medicamentos;
                }
            }
        }

        // Guardar inventario en JSON
        public void GuardarInventario()
        {
            var jsonData = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ArchivoJson, jsonData);
        }

        // Métodos para modificar insumos
        public void AgregarInsumo(string categoria, IInsumo insumo)
        {
            var lista = ObtenerListaPorCategoria(categoria);
            lista.Add(insumo);
            GuardarInventario();
        }

        public void ModificarCantidad(string categoria, string nombre, int cantidad)
        {
            var lista = ObtenerListaPorCategoria(categoria);
            var insumo = lista.FirstOrDefault(i => i.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (insumo != null)
            {
                insumo.AddCantidad(cantidad);
                GuardarInventario();
            }
        }

        private List<IInsumo> ObtenerListaPorCategoria(string categoria)
        {
            return categoria.ToLower() switch
            {
                "limpieza" => Limpieza,
                "desechables" => Desechables,
                "medicamentos" => Medicamentos,
                _ => throw new ArgumentException("Categoría no válida")
            };
        }
    }
}
