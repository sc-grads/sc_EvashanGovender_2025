using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    // This is a delegate declaration
    public delegate void Notify(string message);
    public delegate void LogHandler(string logMessage);

    public delegate int Comparison<T>(T x, T y);

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        // Swap
                        var temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }
    public class Logger
    {
        public void LogtoConsole(string message)
        {
            // Raise the event
            Console.WriteLine("Console Log: " + message);
        }

        public void LogtoFile(string message)
        {
            // Raise the event
            Console.WriteLine("File Log: " + message);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*//instantiate the delegate
            Notify notifyDelegate = ShowMessage;
            //Notify notifyDelegate = new Notify(ShowMessage);

            //invoke the delegate
            notifyDelegate("Hello, this is a message from the delegate!");*/


            Logger logger = new Logger();
            LogHandler logHandler = logger.LogtoConsole;
            logHandler += logger.LogtoFile;
            logHandler("This is a log message.");

            foreach (var handler in logHandler.GetInvocationList())
            {
                Console.WriteLine("Handler: " + handler.Method.Name);
            }
            logHandler -= logger.LogtoFile;
            InvokeSafely(logHandler,"This is another log message after removing the file logger.");
            ;
            /*int[] numbers = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "One", "Two", "Three", "Four" };
            // Using the generic method to print the array
            PrintArray(numbers);
            PrintArray(stringArray);

            Person[] people = new Person[]
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };
            PersonSorter sorter = new PersonSorter();
            // Using a lambda expression for comparison
            sorter.Sort(people, ComparePersonsByName);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }*/
            Console.ReadKey();

        }

        public static void InvokeSafely(LogHandler logHandler, string message)
        {
            if (logHandler != null)
            {
                logHandler(message);
            }
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Example of a generic method to print an array
        public static void PrintArray<T>(T[] array) {            
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static int ComparePersonsByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        public static int ComparePersonsByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
