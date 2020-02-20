using Microsoft.EntityFrameworkCore;
using ParcialAplicada2.Data;
using ParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                    paso = Insertar(inscripcion);
                }
                else
                {
                    paso = Modificar(inscripcion);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
     
        private bool Insertar(Inscripcions inscripcions)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Inscripcions.Add(inscripcions);
            paso = db.SaveChanges() > 0;
            return paso;

        }

        private bool Modificar(Inscripcions inscripcions)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Inscripcions.Add(inscripcions).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Inscripcions Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripcions inscripcions = new Inscripcions();

            try
            {
                inscripcions = db.Inscripcions.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return inscripcions;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;

            Inscripcions inscriopcions = new Inscripcions();

            try
            {
                inscriopcions = db.Inscripcions.Find(id);
                db.Entry(inscriopcions).State = EntityState.Deleted;

                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public List<Inscripcions> GetList(Expression<Func<Inscripcions, bool>> expression)
        {
            List<Inscripcions> lista = new List<Inscripcions>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Inscripcions.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }

    }
}
