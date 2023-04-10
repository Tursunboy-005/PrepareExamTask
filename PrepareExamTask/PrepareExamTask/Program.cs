using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepareExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateDiagonal();
            Console.ReadLine();
        }
        public static void CalculateDiagonal()
        {
            Random random = new Random();
            int[][] array = new int[5][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[5];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(1, 10);
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }


            int diagonalsum = 0;
            int lastSum = 0;
            bool result = false;

            for (int i = 0;i < array.Length; i++)
            {
                for (int j = 0;j < array[i].Length; j++)
                {
                    if (i == j ) 
                    {
                        diagonalsum += array[i][j];
                    }
                    if ( i == array[i].Length - 1)
                    {
                        lastSum += array[i][j];
                    }

                    if( diagonalsum > lastSum)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            
            Console.WriteLine($"Diagonal summa : {diagonalsum}");
            Console.WriteLine($"Last summa : {lastSum}");
            Console.Write($"Result : {result}");

        }
    }
}
