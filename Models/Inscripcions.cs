using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialAplicada2.Models
{
    public class Inscripcions
    {
        [Key]
        public int InscripcionId { get; set; }
        public string Semestre { get; set; }
        public int Limite { get; set; }
        public int Tomados { get; set; }
        public int Disponible { get; set; }

        public Inscripcions()
        {
            InscripcionID = 0;
            Semestre = String.Empty;
            Limite = 0;
            Tomados = 0;
            Disponible = 0;
        }
    }
}
