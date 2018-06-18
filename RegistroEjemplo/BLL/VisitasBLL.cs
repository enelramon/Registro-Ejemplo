using RegistroEjemplo.DAL;
using RegistroEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEjemplo.BLL
{
    public class VisitasBLL
    {

        /// <summary>
        /// Permite guardar una entidad en la base de datos
        /// </summary>
        /// <param name="visita">Una instancia de visita</param>
        /// <returns>Retorna True si guardo o Falso si falló </returns>
        public static bool Guardar(Visitas visita)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Visitas.Add(visita) != null)
                {
                    contexto.SaveChanges(); //Guardar los cambios
                    paso = true;
                }
                //siempre hay que cerrar la conexion
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Modificar una entidad en la base de datos 
        /// </summary>
        /// <param name="visita">Una instancia de visita</param>
        /// <returns>Retorna True si Modifico o Falso si falló </returns>
        public static bool Modificar(Visitas visita)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                //todo: buscar las entidades que no estan para removerlas
                var visitaant = VisitasBLL.Buscar(visita.VisitaId);
                foreach (var item in visitaant.Detalle)//recorrer el detalle aterior
                {
                    //determinar si el item no esta en el detalle actual
                    if (!visita.Detalle.ToList().Exists(v => v.Id == item.Id))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                //recorrer el detalle
                foreach (var item in visita.Detalle)
                {
                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                //Idicar que se esta modificando el encabezado
                contexto.Entry(visita).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Eliminar una entidad en la base de datos
        /// </summary>
        ///<param name="id">El Id de la visita que se desea eliminar </param>
        /// <returns>Retorna True si Eliminó o Falso si falló </returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Visitas visita = contexto.Visitas.Find(id);

                contexto.Visitas.Remove(visita);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Buscar una entidad en la base de datos
        /// </summary>
        ///<param name="id">El Id de la visita que se desea encontrar </param>
        /// <returns>Retorna la visita encontrada </returns>
        public static Visitas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Visitas visita = new Visitas();
            try
            {
                visita = contexto.Visitas.Find(id);
                //Cargar la lista en este punto porque
                //luego de hacer Dispose() el Contexto 
                //no sera posible leer la lista
                visita.Detalle.Count();

                //Cargar los nombres de las ciudades
                foreach (var item in visita.Detalle)
                {
                    //forzando la ciudad a cargarse
                    string s = item.Ciudad.Nombre;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return visita;
        }

        /// <summary>
        /// Permite extraer una lista de Visitas de la base de datos
        /// </summary> 
        ///<param name="expression">Expression Lambda conteniendo los filtros de busqueda </param>
        /// <returns>Retorna una lista de Visitas</returns>
        public static List<Visitas> GetList(Expression<Func<Visitas, bool>> expression)
        {
            List<Visitas> Visitas = new List<Visitas>();
            Contexto contexto = new Contexto();
            try
            {
                Visitas = contexto.Visitas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return Visitas;
        }
    }
}
