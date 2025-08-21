using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsApp
{
    public struct Point
    {
        //Its a common practise to make structs immutable
        //by declaring all fields as readonly and providing only
        //get accessors for properties.
        public  double X { get; }
        public double Y { get;}
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point({X}, {Y})");
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(20,30);
            p1.Display();
            p2.Display();
            // Demonstrating value type behavior
            Point p3 = p1; // Copying value
           // p3.X = 100; // Modifying p3 does not affect p1
            //p1.Display(); // Should still show (10, 20)
            //p3.Display(); // Should show (100, 20)

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between p1 and p2: {distance:F2}");
            Console.ReadLine();
        }
    }
}
