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

            int[,] array2D = new int[3, 3]; // Declare a 2D array with 3 rows and 3 columns

            int[,,] array3D = new int[2, 2, 2]; // Declare a 3D array with 2x2x2 dimensions

            int[,] array2DInitialized = { { 1, 2, 3 },
                                          { 4, 5, 6 }, 
                                          { 7, 8, 9 } 
                                        }; // Declare and initialize a 2D array

            string[,,] array3DInitialized =
            {
                {
                    {"000","001"},
                    {"010","011"}
                },
                {
                    {"100","101" },
                    {"110","111" }
                }
            };

            int[,] array2DWithValues = { { 1, 2, 3 },
                                          { 4, 5, 6 }, 
                                          { 7, 8, 9 } 
                                        }; // Declare and initialize a 2D array
            for(int i = 0; i < array2DWithValues.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < array2DWithValues.GetLength(1); j++)
                {
                    sum += array2DWithValues[i, j]; // Calculate the sum of each row
                }
                Console.WriteLine(sum); // Output the sum of each row
            }
    }
            }
}
