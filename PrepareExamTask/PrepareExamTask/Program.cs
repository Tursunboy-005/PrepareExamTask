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
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
           

            Console.WriteLine(Summa(n));
            Console.ReadLine();
            Console.ReadKey();
            
        }
        public static int Summa(int n)
        {
            int sum = 0;
            int qoldiq = 0;
            while(n != 0)
            {
                qoldiq = n % 10;
                sum += qoldiq;
                n /= 10;
            }
            return sum;
        }

    }
}
