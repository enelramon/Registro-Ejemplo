using RegistroEjemplo.Entidades;
using System.Data.Entity;

namespace RegistroEjemplo.DAL
{
    // Aqui agregamos public tambien, para que la clase pueda ser encontrada en cualquier parte del proyecto, 
    //y heredamos de  DbContext para que EntityFramework pueda hacer su magia
    public class Contexto : DbContext    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<TiposClientes> TiposClientes { get; set; }
        public DbSet<EstadosCiviles> EstadosCiviles { get; set; }

        // base("ConStr") para pasar la conexion a la clase base de EntityFramework 
        public Contexto() : base("ConStr")
        {       }
    }
}
