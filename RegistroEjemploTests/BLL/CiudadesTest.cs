using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroEjemplo.BLL;
using RegistroEjemplo.DAL;
using RegistroEjemplo.Entidades;

namespace RegistroEjemploTests.BLL
{
    [TestClass]
    public class CiudadesTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            bool paso;
            Contexto contexto = new Contexto();
            RepositorioBase<Ciudades> repositorio = new RepositorioBase<Ciudades>( contexto);
            
            repositorio.Guardar(new Ciudades { Nombre = "SFM",CantidadVisitas=0 });
            paso=repositorio.Guardar(new Ciudades { Nombre = "SANTIAGO", CantidadVisitas = 0 });

            repositorio.Dispose();

            Assert.AreEqual(true, paso);
        }
    }
}
