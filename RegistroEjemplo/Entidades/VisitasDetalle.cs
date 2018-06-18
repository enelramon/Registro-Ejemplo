using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEjemplo.Entidades
{
    public class VisitasDetalle
    {
        [Key]

        //GruposDetalle (Id, GrupoId, PersonaId, Cargo)
        public int Id { get; set; }
        public int VisitaId { get; set; }

        public int CiudadId { get; set; }

        [ForeignKey("CiudadId")]
        //Permite indicar por cual campo se usara
        //la NAVIGATION PROPERTY
        public virtual Ciudades Ciudad { get; set; }
        public int Cantidad { get; set; }

        public VisitasDetalle()
        {
            this.Id = 0;
            this.VisitaId = 0;
        }

        /// <summary>
        /// Este constructor es opcional solo lo agrego por comodidad
        /// </summary> 
        public VisitasDetalle(int id, int visitaId, int ciudadId, int cantidad)
        {
            this.Id = id;
            this.VisitaId = visitaId;
            this.CiudadId = ciudadId;
            this.Cantidad = cantidad;

            //todo crear la instancia de this.Ciudad
        }
    }
}
