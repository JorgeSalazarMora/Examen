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
            laMatrizOriginalB[0, 2] = 7;
            laMatrizOriginalB[1, 0] = 5;
            laMatrizOriginalB[1, 1] = 6;
            laMatrizOriginalB[1, 2] = 8;

            double[,] laMatrizBest = new double[4, 3];
            laMatrizOriginalB[0, 0] = 3;
            laMatrizOriginalB[0, 1] = 4;
            laMatrizOriginalB[0, 2] = 7;
            laMatrizOriginalB[0, 3] = 7;
            laMatrizOriginalB[1, 0] = 3;
            laMatrizOriginalB[1, 1] = 4;
            laMatrizOriginalB[1, 2] = 7;
            laMatrizOriginalB[1, 3] = 7;
            laMatrizOriginalB[2, 0] = 3;
            laMatrizOriginalB[2, 1] = 4;
            laMatrizOriginalB[2, 2] = 7;
            laMatrizOriginalB[2, 3] = 7;
            laMatrizOriginalB[3, 0] = 3;
            laMatrizOriginalB[3, 1] = 4;
            laMatrizOriginalB[3, 2] = 7;
            laMatrizOriginalB[3, 3] = 7;

            Matriz.Training.Service1 recursos = new Matriz.Training.Service1();

            double[][] laMatrizResultante = recursos.Multi(laMatrizOriginalA,laMatrizOriginalB, 4, 3);

            Assert.AreEqual(laMatrizResultante[4][3], laMatrizBest[4, 3]);

           
        }



        /*
        This method make the test for a matriz "Transpuesta"
        */
        [TestMethod]
        public void TestTranspuesta()
        {
            int[][] laMatrizOriginal = new int[2][];
            laMatrizOriginal[0][0] = 1;
            laMatrizOriginal[0][1] = 2;
            laMatrizOriginal[1][0] = 3;
            laMatrizOriginal[1][1] = 4;

            int[][] laMatrizBest = new int[2][];
            laMatrizOriginal[0][0] = 4;
            laMatrizOriginal[0][1] = 3;
            laMatrizOriginal[1][0] = 2;
            laMatrizOriginal[1][1] = 1;


            Matriz.Training.Service1 recursos = new Matriz.Training.Service1();

            int[][] laMatrizResultante = recursos.Transpuesta(laMatrizOriginal, 2, 2);


            Assert.AreNotSame(laMatrizResultante[2][2], laMatrizOriginal[2][2]);
        }



    }
}
