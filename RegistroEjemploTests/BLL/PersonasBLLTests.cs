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
            Repositorio<EstadosCiviles> repositorio = new Repositorio<EstadosCiviles>(new Contexto());

            EstadosCiviles estadosCiviles = new EstadosCiviles
            {
                Descripcion = "Casado"
            };
            bool paso = repositorio.Guardar(estadosCiviles);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
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