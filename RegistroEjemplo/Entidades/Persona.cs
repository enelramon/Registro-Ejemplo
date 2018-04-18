using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEjemplo.Entidades
{
    //Colocamos Public Aqui Para que la clase se pueda encontrar en cualquier parte del proyecto
    public class Persona
    {

        //Esta es la llave primaria y luego de agregarla hay que agregar su libreria llamada using System.ComponentModel.DataAnnotations;
        [Key]
        // Atributos de nuestra clase 
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string  Direccion { get; set; }
        //Constructor Con parametros
        public Persona(int id, string nombre, string cedula, string telefono, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Direccion = direccion;
        }
        //Constructor vacio
        public Persona()
        {
            Id = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
        }
    }
}
