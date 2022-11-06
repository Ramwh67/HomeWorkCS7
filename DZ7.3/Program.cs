using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
           int[,] createMatrix(int m, int n)
           {
              int[,] matrix = new int[m,n];
              for (int i=0; i<m; i++)
              {
                    for (int j=0; j<n; j++)
                    {
                        matrix[i,j] = new Random().Next(0,10);
                    }
              }
              return matrix;
           }

           void printMatrix(int[,] matrix)
           {
                for (int i=0; i<matrix.GetLength(0); i++)
                {
                    for (int j=0; j<matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                    Console.WriteLine();
                }
           }

           double[] getAvgColumns(int[,] matrix)
           {
                double[] array = new double[matrix.GetLength(1)];
                double avg;

                for (int j=0; j<matrix.GetLength(1); j++)
                {
                    avg = 0;
                    for (int i=0; i<matrix.GetLength(0); i++)
                    {
                        avg = avg + matrix[i,j];
                    } 
                    array[j] = avg/matrix.GetLength(0);
                }
                return array;
           }

           void printArray(double[] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }

           //Console.Write("Введите число m: "); 
           //int m = Convert.ToInt32(Console.ReadLine());
           //Console.Write("Введите число n: ");
           //int n = Convert.ToInt32(Console.ReadLine());
           //int[,] a = createMatrix(m,n);
           int[,] a = createMatrix(4,4);
           printMatrix(a);
           double[] avg = getAvgColumns(a);
           printArray(avg);
        }
    }
}