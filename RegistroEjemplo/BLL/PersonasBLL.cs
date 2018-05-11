using RegistroEjemplo.DAL;
using RegistroEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RegistroEjemplo.BLL
{
    /// <summary>
    /// En esta clase debemos programar toda la logica de negocios
    /// </summary>
    public class PersonasBLL    {


        /// <summary>
        /// Permite guardar una entidad en la base de datos
        /// </summary>
        /// <param name="persona">Una instancia de Persona</param>
        /// <returns>Retorna True si guardo o Falso si falló </returns>
        public static bool Guardar(Personas persona)
        {
            bool paso = false;
            //Creamos una instancia del contexto para poder conectar con la BD
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.Personas.Add(persona)!=null)
                {
                    contexto.SaveChanges(); //Guardar los cambios
                    paso = true;
                }
                
                contexto.Dispose();//siempre hay que cerrar la conexion
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
        /// <param name="persona">Una instancia de Persona</param>
        /// <returns>Retorna True si Modifico o Falso si falló </returns>
        public static bool Modificar(Personas persona)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(persona).State = EntityState.Modified;
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
        ///<param name="id">El Id de la persona que se desea eliminar </param>
        /// <returns>Retorna True si Eliminó o Falso si falló </returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {               
                Personas persona = contexto.Personas.Find(id);

                contexto.Personas.Remove(persona);
             
                if(contexto.SaveChanges()>0)
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
        ///<param name="id">El Id de la persona que se desea encontrar </param>
        /// <returns>Retorna la persona encontrada </returns>
        public static Personas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Personas persona = new Personas();
            try
            {
                persona = contexto.Personas.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return persona;
        }

        /// <summary>
        /// Permite extraer una lista de Personas de la base de datos
        /// </summary> 
        ///<param name="expression">Expression Lambda conteniendo los filtros de busqueda </param>
        /// <returns>Retorna una lista de personas</returns>
        public static List<Personas> GetList(Expression<Func<Personas, bool >> expression)
        {
            List<Personas> Personas = new List<Personas>();
            Contexto contexto = new Contexto();
            try
            {
                Personas = contexto.Personas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return Personas;
        }
    }
}
