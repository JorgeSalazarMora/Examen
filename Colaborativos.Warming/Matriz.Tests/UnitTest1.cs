using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matriz.Training;

namespace Matriz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] laMatrizOriginal = new double[3, 2];
            laMatrizOriginal[0, 0] = 3;
            laMatrizOriginal[0, 1] = 4;
            laMatrizOriginal[1, 0] = 5;
            laMatrizOriginal[1, 1] = 6;
            laMatrizOriginal[2, 0] = 7;
            laMatrizOriginal[2, 1] = 8;

            Matriz.Training.Service1 recursos = new Matriz.Training.Service1();

            double[][] laMatrizResultante = recursos.Copiar(laMatrizOriginal, 3, 2);

            Assert.AreEqual(laMatrizResultante[2][0], laMatrizOriginal[2,0]);
        }
    }
}
