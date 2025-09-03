using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            oddNumbers(numbers);
            Console.ReadKey();

        }

        static void oddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers:");
            IEnumerable<int> oddNumbers = from n in numbers
                                          where n % 2 != 0
                                          select n;


            foreach (int n in oddNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
