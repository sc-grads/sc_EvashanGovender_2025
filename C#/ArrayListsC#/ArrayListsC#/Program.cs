using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListsC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();// Initialize an empty ArrayList
            ArrayList myArrayList2 = new ArrayList(100);// Initialize an ArrayList with a capacity of 100

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(3.14);
            myArrayList.Add(true);
            
            myArrayList.Remove(3.14); // Remove the double value 3.14 from the ArrayList

            myArrayList.RemoveAt(1); // Remove the element at index 1 (which is "Hello")

            Console.WriteLine(myArrayList.Count); // Output the number of elements in the ArrayList
            foreach (object item in myArrayList)
            {
                Console.WriteLine(item); // Print each item in the ArrayList
            }

            Console.ReadKey(); // Wait for a key press before closing the console window
        }
    }
}
