using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is outside the method");
            //myFirstMethod(); // Calling the method
            //string name = "Frank"; // Variable declaration
            // WriteSomething(name); // Calling the method with an argument
            int a = 5; // Variable declaration
            int b = 10; // Variable declaration
            Console.WriteLine("The result of adding " + a + " and " + b + " is: " + AddTwoNumbers(a,b));
            Console.ReadKey();
        }

        static void myFirstMethod()
        {
            Console.WriteLine("MyFirstMethod was called");
        }

        static void WriteSomething(string message)
        {
            Console.WriteLine("You passed this argument to me " + message);
        }

        static int AddTwoNumbers(int a, int b)
        {
            int result = a + b;
            return result; // Returning the result of the addition
        }
    }
}
