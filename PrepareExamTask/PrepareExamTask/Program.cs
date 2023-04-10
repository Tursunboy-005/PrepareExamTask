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
            Console.Write("enter a number : ");
            string input = Console.ReadLine();
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
                if ((input.Length - i - 1) % 3 == 0 && i != input.Length - 1)
                {
                    output += ",";
                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
