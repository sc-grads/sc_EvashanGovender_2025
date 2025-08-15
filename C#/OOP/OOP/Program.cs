using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car audi = new Car("A3","Audi",false);
            Car bmw = new Car("i7","BMW",true);
            Console.WriteLine("Enter the model of the car:");
            audi.Brand = Console.ReadLine();
            Console.WriteLine("Brand: " + audi.Brand);
            Console.WriteLine("Brand: " + bmw.Brand);
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("Frank The Tank", "1234 Elm St", "555-1234");
            Console.WriteLine("Customer Name: " + earl.Name);

            Customer defaultCustomer = new Customer(); // This will use the default constructor
            Console.WriteLine("Customer Name: " + defaultCustomer.Name);*/
            Car myAudi = new Car("A3", "Audi", false);
            myAudi.Drive();
            Console.WriteLine(AddNumbers(firstNum: 5, secondNum: 10)); // Named arguments for clarity
            Console.ReadKey();
        }

        static int AddNumbers(int firstNum, int secondNum)
        {
            return firstNum + secondNum ;
        }
    }
}
