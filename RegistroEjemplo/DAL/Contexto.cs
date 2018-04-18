using RegistroEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEjemplo.DAL
{
    // Aqui agregamos public tambien, para que la clase pueda ser encontrada en cualquier parte del proyecto, y agregamos los dos puntos y la palabra DbContext
    //Junto con su respectiva libreria, eso es para conectar con la base de datos
    public class Contexto : DbContext
    {
        //Este es nuestro atributo de la clase tipo Persona
        public DbSet<Persona> People { get; set; }
        //Aqui creamos un constrtuctor vacio de la clase y le agregamos esta parte : base("ConStr") para hacer la conexion con la base de datos 
        
        public Contexto() : base("ConStr")
        {

        }
    }
}
