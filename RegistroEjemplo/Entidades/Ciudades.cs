using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroEjemplo.Entidades
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string Nombre { get; set; }

        public Ciudades()
        {

        }

        //Este truco permitira que se vea el nombre 
        //de la ciudad en el grid.
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
