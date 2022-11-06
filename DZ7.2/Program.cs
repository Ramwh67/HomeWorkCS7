using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {
           double[,] createMatrix(int m, int n)
           {
            
            double[,] matrix = new double[m,n];
              for (int i=0; i<m; i++)
              {
                    for (int j=0; j<n; j++)
                    {
                        matrix[i,j] = new Random().NextDouble()*10;
                    }
              }
              return matrix;
           }

           void printMatrix(double[,] matrix)
           {
                for (int i=0; i<matrix.GetLength(0); i++)
                {
                    for (int j=0; j<matrix.GetLength(1); j++)
                    {
                        Console.Write("{0:0.00}  ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
           }

           void showElement(double[,] matrix)
           {
                Console.WriteLine("Какой элемент Вам показать?");
                Console.Write("Строка: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Столбец: ");
                int m = Convert.ToInt32(Console.ReadLine());
                //Учитываем, что пользователь не знает об отсчёте индексов с нуля
                if (n>=1 && n<=matrix.GetLength(0) && m>=1 && m<=matrix.GetLength(1))
                    Console.WriteLine($"Выбранный Вами элемент имеет значение: {Math.Round(matrix[n-1, m-1],2)}");
                else 
                    Console.WriteLine("Выбранного элемента не существует");
                
           }

           Console.Write("Введите число m: ");
           int m = Convert.ToInt32(Console.ReadLine());
           Console.Write("Введите число n: ");
           int n = Convert.ToInt32(Console.ReadLine());
           double[,] a = createMatrix(m,n);
           printMatrix(a);
           showElement(a);
        }
    }
}