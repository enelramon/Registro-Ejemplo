using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroEjemplo.Entidades
{
    public class Visitas
    {
        [Key]
        public int VisitaId { get; set; }
        public DateTime Fecha { get; set; }

        [StringLength(100)]
        public string Comentarios { get; set; }

        /*Lista tipo VisitasDetalle
        le colocamos virtual para usar el LazyLoading
        LazyLoading consiste en retrasar la carga de un objeto
        hasta el mismo momento de su utilización. */
        public virtual ICollection<VisitasDetalle> Detalle { get; set; }

        public Visitas()
        {
            //Es obligatorio inicializar la lista
            this.Detalle = new List<VisitasDetalle>();
        }

        /// <summary>
        /// Este metodo permite agretar un item a la lista
        /// No es obligatorio, lo creo por comodidad
        /// </summary>
        public void AgregarDetalle(int id,int VisitaId,int CiudadId, int Cantidad)
        {
            this.Detalle.Add(new VisitasDetalle(id,VisitaId,CiudadId, Cantidad));
        }

    } 
}
