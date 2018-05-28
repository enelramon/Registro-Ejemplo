using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEjemplo.Entidades
{
    public class TiposClientes
    {
        [Key]
        public int TipoId { get; set; }
        public int Descripcion { get; set; }
        public TiposClientes()
        {
                
        }

    }
}
