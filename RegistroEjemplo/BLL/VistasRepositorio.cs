using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEjemplo.BLL;
using RegistroEjemplo.DAL;
using RegistroEjemplo.Entidades;
namespace RegistroEjemplo.BLL
{
    public class VistasRepositorio : RepositorioBase<Visitas>
    {
        public VistasRepositorio(Contexto contexto) : base(contexto)
        {
        }

        public override Visitas Buscar(int id)
        {
            Visitas visita = new Visitas();
            try
            {
                visita = _contexto.Visitas.Find(id);

                visita.Detalle.Count();//Cargar la lista en este punto porque                //luego de hacer Dispose() el Contexto                 //no sera posible leer la lista

                foreach (var item in visita.Detalle)//Cargar los nombres de las ciudades            
                { string s = item.Ciudad.Nombre; } //forzando la ciudad a cargarse

            }
            catch (Exception)
            {

                throw;
            }
            return visita;
        }

        public override bool Modificar(Visitas visita)
        {
            bool paso = false;
            try
            {
                //todo: buscar las entidades que no estan para removerlas

                //recorrer el detalle
                foreach (var item in visita.Detalle)
                {
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added; //Muy importante indicar que pasara con la entidad del detalle
                    _contexto.Entry(item).State = estado;
                }

                //Idicar que se esta modificando el encabezado
                _contexto.Entry(visita).State = EntityState.Modified;

                if (_contexto.SaveChanges() > 0)
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



    }
}
