using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Repositorio<Ciudades> repositorio = new Repositorio<Ciudades>( contexto);
            
            repositorio.Guardar(new Ciudades { Nombre = "SFM" });
            paso=repositorio.Guardar(new Ciudades { Nombre = "SANTIAGO" });

            repositorio.Dispose();

            Assert.AreEqual(true, paso);
        }
    }
}
