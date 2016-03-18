using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Matriz.Training
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public double[] [] Copiar (double[,] laMatriz, int numFilas, int numColumnas)
        {
            // Declare local jagged array with numFilas rows.
            double[][] resultado = new double[numFilas][];
            for (int i = 0; i < numFilas; i++)
            {
                double[] laFila = new double[numColumnas];
                for (int j = 0; j < numColumnas; j++)
                {
                    laFila[j] = laMatriz[i,j];
                }
                resultado[i] = laFila;
            }
            return resultado;
        }

        public double[][] Multi(double[,] laMatrizA, double[,] laMatrizB, int numFilas, int numColumnas)
        {
            // Declare local jagged array with numFilas rows.
            double[][] resultado = new double[numFilas][];

           
            for (int i = 0; i < numFilas; ++i)
            {
                double[] laFila = new double[numColumnas];
                for (int j = 0; j < numColumnas; ++j)
                {

                    laFila[j] = laMatrizB[i, j];
                }
                resultado[i] = laFila;
            }
              

            return resultado;
        }

        public int[][] Transpuesta(int [][]laMatriz, int numFilas, int numColumnas)
        {
            // Declare local jagged array with numFilas rows.
            int[][] resultado = new int[numFilas][];
            for (int i = 0; i < numFilas; i++)
            {
                

                for (int j = 0; j < numColumnas; j++)
                {
                    resultado[i][j] = laMatriz[j][i];
                }
               
            }
            return resultado;
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
