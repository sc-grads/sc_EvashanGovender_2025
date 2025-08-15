using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Debug.WriteLine("Main method is running");
            
            try
            {
                int number = 0;
                int number2 = 2;
                result = number2 / number;
            }
            catch (DivideByZeroException ex)
            {
               // Console.WriteLine("You cannot divide by zero.");
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // This block always executes, regardless of whether an exception was thrown or not.
                Console.WriteLine("This block always executes.");
            }
            getUserAge("S");
            Console.ReadKey();

        }

        static int getUserAge(string input)
        {
            int age;
            if(!int.TryParse(input,out age))
            {
                                throw new ArgumentException("Invalid input for age. Please enter a valid number.");
            }
            if(age < 0 || age > 120)
            {
                throw new ArgumentOutOfRangeException("Age must be between 0 and 120.");
            }
            return age;
        }
    }
}
