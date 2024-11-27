using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clinica.Clientes
{
    public enum GrupoSanguineo
    {
        A, B, AB, O
    }
    public class FichaMedica
    {
        private GrupoSanguineo grupoSanguineo;
        private string antecedentes = string.Empty;
        private string alergias = string.Empty;
        private string observaciones = string.Empty;

        public GrupoSanguineo GrupoSanguineo { get => grupoSanguineo; set => grupoSanguineo = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
