using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrepareExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (long i = 1; i < 10000000000; i++) 
            {
                Result(i.ToString());
            }
            Console.ReadLine();
        }
        public static void Result(string input) {
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
        }
            
        
    }
}
