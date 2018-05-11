using System.ComponentModel.DataAnnotations; 
namespace RegistroEjemplo.Entidades{
    //Debe ser PUBLIC para que sea visible para las demas capas
    public class Personas    {
        //Esta es la llave primaria
        [Key]//hay que importar System.ComponentModel.DataAnnotations;
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Personas()        {
            PersonaId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
        }
    }
}
