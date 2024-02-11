using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter forst number");
            String num1=Console.ReadLine();

            Console.WriteLine("Enter second number");
            String num2 = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(num1)+Convert.ToInt32(num2));
            Console.ReadKey();

        }
    }
}
