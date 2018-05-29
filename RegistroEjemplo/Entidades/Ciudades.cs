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
    }
}
