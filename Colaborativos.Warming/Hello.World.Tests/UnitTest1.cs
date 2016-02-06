using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello.World.Tests.Client;

namespace Hello.World.Tests
{
    [TestClass]
    public class UnitTest1
    {
        string myName;
        string resultadoEsperado;
        string resultadoReal;
        HelloWorldClient client = new HelloWorldClient();
        const string mensajeAssert =
                "El resultado esperado es [{0}], pero el resultado real es [{1}]";


        [TestMethod]
        public void TestSayHelloMyName ()
        {
            // preparar el escenario
            myName = "Héctor";
            resultadoEsperado = "Hello world, Héctor";

            // invoco al método correspondiente
            resultadoReal = client.SayHello(myName);

            // comparación de resultados
            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAssert, resultadoEsperado.ToString(), resultadoReal.ToString())
                );

        }

        [TestMethod]
        public void TestSayHelloEmptyName()
        {
            // preparar el escenario
            myName = string.Empty;
            resultadoEsperado = "Hello world";

            // invoco al método correspondiente
            resultadoReal = client.SayHello(myName);

            // comparación de resultados
            Assert.AreEqual(resultadoEsperado, resultadoReal,
                string.Format(mensajeAssert, resultadoEsperado.ToString(), resultadoReal.ToString())
                );
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
