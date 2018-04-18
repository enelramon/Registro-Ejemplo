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
    //Recordemos siempre ponerle Public delante de Class a todas las clases
    public class PersonaBLL
    {
        //En la clase de la BLL es donde va toda la programacion logica 
        
        //Este es el metodo para guardar en la base de datos 
        public static bool Guardar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.People.Add(persona)!=null)
                {
                    db.SaveChanges();
                    paso = true;
                }

                //siempre hay que cerrar la conexion, para esto es el dispose
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        //Este es el metodo para Elminar en la base de datos 
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                var eliminar = db.People.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                if(db.SaveChanges()>0)
                {
                    paso = true;
                }
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        //Este es el metodo para Modificar en la base de datos 
        public static bool Modificar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(persona).State = EntityState.Modified;
                if(db.SaveChanges() >0)
                {
                    paso = true;

                }
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        //Este es el metodo para buscar en la base de datos 
        public static Persona Buscar(int id)
        {
            Contexto db = new Contexto();
            Persona persona = new Persona();
            try
            {
                persona = db.People.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return persona;
        }

        //Este es el metodo para listar o consultar lo que teneos en la base de datos 
        public static List<Persona> GetList(Expression<Func<Persona, bool >> persona)
        {
            List<Persona> people = new List<Persona>();
            Contexto db = new Contexto();
            try
            {
                people = db.People.Where(persona).ToList();
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return people;
        }
    }
}
