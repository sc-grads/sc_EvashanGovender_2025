using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = { 5, 12, 13, 14, 15 }; // Declare an array of integers with 5 elements
           /* myIntArray[0] = 10; // Assign value to the first element
            myIntArray[1] = 20; // Assign value to the second element
            myIntArray[2] = 30; // Assign value to the third element
            myIntArray[3] = 40; // Assign value to the fourth element
            myIntArray[4] = 50; // Assign value to the fifth element*/
           int length = myIntArray.Length; // Get the length of the array
            Console.WriteLine("Elements of myIntArray:");
           /* for (int i = 0; i < myIntArray.Length; i++) // Loop through the array elements
            {
                Console.WriteLine(myIntArray[i]); // Output each element
            }*/
            foreach (int element in myIntArray) // Using foreach to iterate through the array
            {
                Console.WriteLine(element); // Output each element
            }
            Console.WriteLine($"Length of array: {length}"); // Output the length of the array
            Console.ReadKey();
        }
    }
}
