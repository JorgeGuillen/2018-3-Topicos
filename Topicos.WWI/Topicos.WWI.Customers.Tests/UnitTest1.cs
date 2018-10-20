using System;
using Topicos.WWI.Customers.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Topicos.WWI.Customers.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConsultarClientesConLan()
        {
            // prepare el escenario
            var elCriterioDeConsulta = "lan";
            var laEspecificacion = new BL.Logica.Especificacion.Customers();
            var elResultadoEsperado = 14;

            // ejecute el método deseado
            var elResultadoReal = laEspecificacion.ListarPorNombreAproximado(elCriterioDeConsulta);

            // verifique
            Assert.IsNotNull(elResultadoReal);
            Assert.IsTrue(elResultadoReal.Count == elResultadoEsperado);
        }
    }
}
