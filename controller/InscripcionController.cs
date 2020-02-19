using ParcialAplicada2.Data;
using ParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialAplicada2.controller
{
    public class InscripcionController
    {
        public bool Guardar(Inscripcions inscripcion)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if(inscripcion.InscripcionId == 0)
                {
                    paso =
                }
            }

        }
        
    }
}
