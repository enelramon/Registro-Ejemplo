using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroEjemplo.BLL;
using RegistroEjemplo.DAL;
using RegistroEjemplo.Entidades;

namespace RegistroEjemploTests.BLL
{
    [TestClass]
    public class VistasTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            
            Visitas visita = new Visitas
            {
                Fecha=DateTime.Now,
                Comentarios="Fue Genial"
            };

            //Si no estan creadas las ciudades da error.
            visita.Detalle.Add(new VisitasDetalle(0,0,1, 2));
            visita.Detalle.Add(new VisitasDetalle(0,0,2, 3));

            bool paso = VisitasBLL.Guardar(visita);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void ModificarTest()
        {
            int idVisita = VisitasBLL.GetList(x => true)[0].VisitaId;

            Visitas visita = VisitasBLL.Buscar(idVisita);

            visita.Detalle.Remove(visita.Detalle[0]);

            //agregtar otro
            visita.Detalle.Add(new VisitasDetalle(0,visita.VisitaId, 2, 4));


            bool paso = VisitasBLL.Modificar(visita);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void BuscarTest()
        {
            int idVisita = VisitasBLL.GetList(x => true)[0].VisitaId;
            Visitas visita = VisitasBLL.Buscar( idVisita);                     

            bool paso = visita.Detalle.Count>0;
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void EliminarTest()
        {
            int idVisita = VisitasBLL.GetList(x => true)[0].VisitaId;
  

            bool paso = VisitasBLL.Eliminar(idVisita);
            Assert.AreEqual(true, paso);
        }
    }
}
