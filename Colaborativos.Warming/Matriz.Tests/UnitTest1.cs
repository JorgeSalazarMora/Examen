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


        /*
        *This method is goin to take the columns of the matriz A and the rows of B
        and is going to create another matriz
        */
        [TestMethod]
        public void TestMultiMatriz()
        {
            double[,] laMatrizOriginalA = new double[4, 2];
            laMatrizOriginalA[0, 0] = 3;
            laMatrizOriginalA[0, 1] = 4;
            laMatrizOriginalA[1, 0] = 5;
            laMatrizOriginalA[1, 1] = 6;
            laMatrizOriginalA[2, 0] = 7;
            laMatrizOriginalA[2, 1] = 8;
            laMatrizOriginalA[3, 0] = 2;
            laMatrizOriginalA[3, 1] = 9;

            double[,] laMatrizOriginalB = new double[2,3];
            laMatrizOriginalB[0, 0] = 3;
            laMatrizOriginalB[0, 1] = 4;
            laMatrizOriginalB[1, 0] = 5;
            laMatrizOriginalB[1, 1] = 6;
            laMatrizOriginalB[2, 0] = 7;
            laMatrizOriginalB[2, 1] = 8;
            laMatrizOriginalB[3, 0] = 2;
            laMatrizOriginalB[3, 1] = 9;

            Matriz.Training.Service1 recursos = new Matriz.Training.Service1();

            double[][] laMatrizResultante = recursos.Copiar(laMatrizOriginalA, 3, 2);

            Assert.AreEqual(laMatrizResultante[2][0], laMatrizOriginalA[2, 0]);

           
        }

        
    }
}
