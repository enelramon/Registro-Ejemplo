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
        {        }

        //Este truco permitira que se vea el nombre 
        //de la ciudad en el grid.
        public override string ToString()
        {
            return   this.CiudadId.ToString() +" - "+ this.Nombre;
        }

        void nuevo()
        {
            Ciudades ciudades = new Ciudades();

            ciudades.CiudadId = 56;
            ciudades.Nombre = "SFM";

            string texto = "";

            //Imprime "56 - SFM"
            texto = ciudades.ToString();

            //Imprime "56 - SFM"
            texto= Convert.ToString( ciudades);  
        }
    }

    
}
