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
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} foobar ");
                }else if (i % 3 == 00)
                {
                    Console.WriteLine($"{i} foo");
                }else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} bar");
                }
            }
            Console.ReadLine();
        }
    }
}
