using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(4.2));
            Console.WriteLine("Floor: " + Math.Floor(4.8));

            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Min: " + Math.Min(num1, num2));
            Console.WriteLine("Max: " + Math.Max(num1, num2));

            Console.WriteLine("3 to the power of 5 is {0}",Math.Pow(3, 5));
            Console.WriteLine("Square root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("PI is: {0}", Math.PI);
            Console.WriteLine("Absolute value of -25 is: {0}",Math.Abs(-25));

            Console.ReadKey();
        }
    }
}
