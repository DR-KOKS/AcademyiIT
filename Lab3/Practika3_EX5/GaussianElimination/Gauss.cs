using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GaussianElimination
{
    static class Gauss
    {
        /// <summary>
        /// Number of equations (and variables) to solve for
        /// </summary>
        public const int numberOfEquations = 4;

        /// <summary>
        /// Solve simultaneous equations using Gaussian method
        /// </summary>
        /// <param name="coefficients">Coefficients from all equations</param>
        /// <param name="rhs">Constants from all equations</param>
        /// <returns>Array of solution results</returns>
        public static double[] SolveGaussian(double[,] coefficients, double[] rhs)
        {
            double[,] a = DeepCopy2D(coefficients);
            double[] b = DeepCopy1D(rhs);

            // TODO Exercise 5, Task 3
            double x, sum;
            for (int k = 0; k < numberOfEquations - 1; k++)
            {
                try
                {
                    for (int i = k + 1; i < numberOfEquations; i++)
                    {
                        x = a[i, k] / a[k, k];
                        for (int j = k + 1; j < numberOfEquations; j++)
                            a[i, j] = a[i, j] - a[k, j] * x;
                        b[i] = b[i] - b[k] * x;
                    }
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            b[numberOfEquations - 1] = b[numberOfEquations - 1] / a[numberOfEquations - 1, numberOfEquations - 1];

            for (int i = numberOfEquations - 2; i >= 0; i--)
            {
                sum = b[i];
                for (int j = i + 1; j < numberOfEquations; j++)
                    sum = sum - a[i, j] * b[j];
                b[i] = sum / a[i, i];
            }

            return b;
        }
 
        

        private static double[] DeepCopy1D(double[] array)
        {
            
            int columns = array.GetLength(0);
            
            double[] newArray = new double[columns];
            
            for (int i = 0; i < columns; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        private static double[,] DeepCopy2D(double[,] array)
        {
 
           int columns = array.GetLength(0);
           int rows = array.GetLength(1);
 
           double[,] newArray = new double[columns, rows];
 
           for (int i = 0; i < columns; i++)
           {
              for (int j = 0; j < rows; j++)
              {
               newArray[i,j] = array[i,j];
              }
           }
           return newArray;
         }  
    }
}
