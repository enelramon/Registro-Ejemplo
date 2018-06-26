using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepasoDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            DAL.Contexto contexto = new DAL.Contexto();

            Cotizaciones cotizacion = new Cotizaciones()
            {
                CotizacionId = 0,
                Fecha = new DateTime(2018, 1, 1),
                Monto = 100
            };

            cotizacion.AgregarDetalle(1, "Pan", 2);
            cotizacion.AgregarDetalle(1, "Mantequilla", 1);
            
            contexto.Cotizaciones.Add(cotizacion);

            contexto.SaveChanges();
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            DAL.Contexto contexto = new DAL.Contexto();

            Cotizaciones cotizacion = new Cotizaciones();

            cotizacion = contexto.Cotizaciones.Find(1);
            contexto.Dispose();//me desconecto aqui

             contexto = new DAL.Contexto();

            cotizacion.AgregarDetalle(1, "Croissant", 2);
            cotizacion.AgregarDetalle(1, "Croissant", 2);
            cotizacion.AgregarDetalle(1, "Croissant", 2);
            cotizacion.AgregarDetalle(1, "Croissant", 2);
            cotizacion.AgregarDetalle(1, "Croissant", 2);

            //recorrer el detalle
            foreach (var item in cotizacion.Detalle)
            {
                item.CotizacionId = cotizacion.CotizacionId;
                contexto.Entry(item).State = EntityState.Added;
            }

            contexto.SaveChanges();

        }
    }
}


namespace Entidades
{
    public class Cotizaciones
    {
        [Key]
        public int CotizacionId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }

        public List<CotizacionesDetalle> Detalle { get; set; }

        public Cotizaciones()
        {
            this.Detalle = new List<CotizacionesDetalle>();
        }
        public void AgregarDetalle(int cantidad, string descripcion, double precio)
        {
            this.Detalle.Add(new CotizacionesDetalle(cantidad, descripcion, precio));
        }
    }

    public class CotizacionesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int CotizacionId { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public CotizacionesDetalle(int cantidad, string descripcion, double precio)
        {
            Cantidad = cantidad;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cotizaciones> Cotizaciones { get; set; }
        public Contexto() : base(@"Data Source=.\SqlExpress;Initial Catalog = RepasoDb; Integrated Security = True")
        {

        }

    }
}