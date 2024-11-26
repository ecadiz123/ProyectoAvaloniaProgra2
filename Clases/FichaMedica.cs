using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsultorio.Clientes
{
    internal class FichaMedica
    {
        private string grupoSanguineo = string.Empty;
        private string antecedentes = string.Empty;
        private string alergias = string.Empty;
        private string observaciones = string.Empty;

        public string GrupoSanguineo { get => grupoSanguineo; set => grupoSanguineo = value; }
        public string Antecedentes { get => antecedentes; set => antecedentes = value; }
        public string Alergias { get => alergias; set => alergias = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    } 
}
