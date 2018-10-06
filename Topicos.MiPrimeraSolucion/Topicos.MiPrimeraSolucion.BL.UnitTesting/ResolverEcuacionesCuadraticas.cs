using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Topicos.MiLogicaDeNegocio;

namespace Topicos.MiPrimeraSolucion.BL.UnitTesting
{
    [TestClass]
    public class ResolverEcuacionesCuadraticas
    {
        private const int numDecimales = 4;

        [TestMethod]
        public void ElValorDeAEsCero()

        {
            // preparar el escenario
            float coeficienteA = 0;
            float coeficienteB = 123;
            float coeficienteC = 1234;
            ResultadoEcuacionCuadratica elResultadoActual;
            var elResultadoEsperado = new ResultadoEcuacionCuadratica();
            elResultadoEsperado.PrimeraRaiz = elResultadoEsperado.SegundaRaiz = null;
            var laEspecificacion = new MiLogicaDeNegocio.Logica.Especificacion.ResuelvaEcuacionCuadratica();

            // ejecutar la prueba
            elResultadoActual = laEspecificacion.ResolverEcuacionCuadratica(coeficienteA, coeficienteB, coeficienteC);

            // verificar el resultado obtenido
            Assert.AreEqual(elResultadoEsperado.PrimeraRaiz, elResultadoActual.PrimeraRaiz);
            Assert.AreEqual (elResultadoEsperado.SegundaRaiz, elResultadoActual.SegundaRaiz);
        }

        [TestMethod]
        public void ElValorDeDiscriminanteEsMenorQueCero()

        {
            // preparar el escenario
            float coeficienteA = -5;
            float coeficienteB = 4;
            float coeficienteC = -7;
            ResultadoEcuacionCuadratica elResultadoActual;
            var elResultadoEsperado = new ResultadoEcuacionCuadratica();
            elResultadoEsperado.PrimeraRaiz = elResultadoEsperado.SegundaRaiz = null;
            elResultadoEsperado.Discriminante = -124;
            var laEspecificacion = new MiLogicaDeNegocio.Logica.Especificacion.ResuelvaEcuacionCuadratica();

            // ejecutar la prueba
            elResultadoActual = laEspecificacion.ResolverEcuacionCuadratica(coeficienteA, coeficienteB, coeficienteC);

            // verificar el resultado obtenido
            Assert.AreEqual(elResultadoEsperado.PrimeraRaiz, elResultadoActual.PrimeraRaiz);
            Assert.AreEqual(elResultadoEsperado.SegundaRaiz, elResultadoActual.SegundaRaiz);
            Assert.AreEqual(elResultadoEsperado.Discriminante, elResultadoActual.Discriminante);
        }

        [TestMethod]
        public void ElValorDeDiscriminanteEsCero()

        {
            // preparar el escenario
            float coeficienteA = 3;
            float coeficienteB = 6;
            float coeficienteC = 3;
            ResultadoEcuacionCuadratica elResultadoActual;
            var elResultadoEsperado = new ResultadoEcuacionCuadratica();
            elResultadoEsperado.PrimeraRaiz = elResultadoEsperado.SegundaRaiz = -1;
            elResultadoEsperado.Discriminante = 0;
            var laEspecificacion = new MiLogicaDeNegocio.Logica.Especificacion.ResuelvaEcuacionCuadratica();

            // ejecutar la prueba
            elResultadoActual = laEspecificacion.ResolverEcuacionCuadratica(coeficienteA, coeficienteB, coeficienteC);

            // verificar el resultado obtenido
            Assert.AreEqual(elResultadoEsperado.PrimeraRaiz, elResultadoActual.PrimeraRaiz);
            Assert.AreEqual(elResultadoEsperado.SegundaRaiz, elResultadoActual.SegundaRaiz);
            Assert.AreEqual(elResultadoEsperado.Discriminante, elResultadoActual.Discriminante);
        }

        [TestMethod]
        public void ElHappyDayFlotanteAproximado()

        {
            // preparar el escenario
            float coeficienteA = 4;
            float coeficienteB = 2;
            float coeficienteC = -3;
            ResultadoEcuacionCuadratica elResultadoActual;
            var elResultadoEsperado = new ResultadoEcuacionCuadratica();
            elResultadoEsperado.PrimeraRaiz = -1.15137; elResultadoEsperado.SegundaRaiz = 0.65137;
            elResultadoEsperado.Discriminante = 52;
            var laEspecificacion = new MiLogicaDeNegocio.Logica.Especificacion.ResuelvaEcuacionCuadratica();

            // ejecutar la prueba
            elResultadoActual = laEspecificacion.ResolverEcuacionCuadratica(coeficienteA, coeficienteB, coeficienteC);

            // verificar el resultado obtenido
            Assert.AreEqual(elResultadoEsperado.Discriminante, elResultadoActual.Discriminante);
            // verificar el resultado obtenido
            Assert.IsTrue (
                (Math.Round((double)elResultadoEsperado.PrimeraRaiz, numDecimales) == Math.Round((double)elResultadoActual.PrimeraRaiz, numDecimales)) ||
                (Math.Round((double)elResultadoEsperado.PrimeraRaiz, numDecimales) == Math.Round((double)elResultadoActual.SegundaRaiz, numDecimales))
                );
            Assert.IsTrue(
                (Math.Round((double)elResultadoEsperado.SegundaRaiz, numDecimales) == Math.Round((double)elResultadoActual.PrimeraRaiz, numDecimales)) ||
                (Math.Round((double)elResultadoEsperado.SegundaRaiz, numDecimales) == Math.Round((double)elResultadoActual.SegundaRaiz, numDecimales))
                );

            Assert.AreEqual(elResultadoEsperado.Discriminante, elResultadoActual.Discriminante);
        }


    }
}
