using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");

            colors.Remove("Red");
            List<string> colors = new List<string> { "Red", "Green", "Blue" }; // Using collection initializer

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }*/

            /*List<int> numbers = new List<int> { 10, 5, 15, 3, 9, 25, 18};
            bool hasLargeNumber = numbers.Any(x => x > 20); // Checks if the list contains any elements
            if (hasLargeNumber)
            {
                Console.WriteLine("The list contains a number greater than 20.");
            }
            else
            {
                Console.WriteLine("The list does not contain any number greater than 20.");
            }
            Predicate<int> isGreaterThan10 = x => x > 10; // Predicate to check if a number is greater than 10
            List<int> higherEqual10 = numbers.FindAll(isGreaterThan10); // Finds all numbers greater than 10
            numbers.Sort(); // Sorts the list in ascending order
            foreach (int number in higherEqual10)
            {
                Console.WriteLine(number);
            }*/

            List<Product> products = new List<Product>
            {
                new Product("Laptop", 999.99),
                new Product("Smartphone", 499.99),
                new Product("Tablet", 299.99)
            };
            //foreach (Product product in products)
            //{
             //   Console.WriteLine(product);
            //}
           List<Product> expensiveProducts = products.Where(p => p.Price > 300).ToList(); // Filters products with price greater than 300
           foreach (Product product in expensiveProducts)
            {
                Console.WriteLine(product);
            }
            Console.ReadKey();
        }
    }
}
