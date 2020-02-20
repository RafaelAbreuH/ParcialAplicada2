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
        [Required(ErrorMessage ="Debes introducir un Semestre")]
        public string Semestre { get; set; }
        [Required(ErrorMessage ="Debes introducir un Limite de Credito")]
        public int Limite { get; set; }
        [Required(ErrorMessage ="Debes introducir la cantidad de creditos tomados")]
        public int Tomados { get; set; }
        public int Disponible { get; set; }

        public Inscripcions()
        {
            InscripcionId = 0;
            Semestre = String.Empty;
            Limite = 0;
            Tomados = 0;
            Disponible = 0;
        }
    }
}
