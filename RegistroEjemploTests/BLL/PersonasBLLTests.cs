using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroEjemplo.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEjemplo.DAL;
using RegistroEjemplo.Entidades;

namespace RegistroEjemplo.BLL.Tests
{
    [TestClass()]
    public class PersonasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<EstadosCiviles> repositorio = new RepositorioBase<EstadosCiviles>(new Contexto());

            EstadosCiviles estadosCiviles = new EstadosCiviles
            {
                Descripcion = "Casado"
            };
            bool paso = repositorio.Guardar(estadosCiviles);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void GuardarCiudadTest()
        {
            RepositorioBase<Ciudades> repositorio = new RepositorioBase<Ciudades>(new Contexto());

            Ciudades ciudad = new Ciudades();

            ciudad.Nombre = "SFM";

            bool paso =repositorio.Guardar(ciudad);

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}