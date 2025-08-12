using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAddidtionCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = 0;
            int myNum2 = 0;

            Console.WriteLine("Enter a whole Number!");
            string userInput = Console.ReadLine();
            myNum = int.Parse(userInput);
            Console.WriteLine("Enter a whole Number!");
            userInput = Console.ReadLine();
            myNum2 = int.Parse(userInput);

            int sum = myNum + myNum2;   

            Console.WriteLine("The result of " + myNum + " and " + myNum2 + " is " + sum);
            Console.ReadKey();
        }
    }
}
