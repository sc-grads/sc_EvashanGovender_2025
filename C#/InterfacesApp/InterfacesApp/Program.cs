using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp
{
    public interface  IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"Dog is eating {food}.");
        }
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"Cat is eating {food}.");
        }
    }

    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    public class  CreditCardProcessor: IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}.");
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}.");
        }
    }

    public class  PaymentService
    {
        private readonly IPaymentProcessor _processor;
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        //private readonly string _filePath;
        //public FileLogger(string filePath)
        //{
        //    _filePath = filePath;
        //}
        public void Log(string message)
        {
            string directoryPath = @"C:\Logs";// Ensure the directory exists or create it
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");// Combine the directory and file name to create a full path
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath); // Create the directory if it doesn't exist
            }
            File.AppendAllText(filePath, message + "\n");// This line is just an example of how you might log something to a file.
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Here you would implement the logic to log the message to a database.
            Console.WriteLine($"Logging to database: {message}");
        }
    }

    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }
        
        public void work()
        {
            _logger.Log("Application started.");
            // Application logic here
            _logger.Log("Application finished.");
        }
    }

    /*
      Decoupling: The Applicatiom class depends on the ILogger interface, not on a specific implementations.
      This allows you to easily switch between different logging mechanisms 
      (like FileLogger or DatabaseLogger) without changing the Application class code.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("biscuits");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("fish");
            IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);

            IPaymentProcessor payPalProcessor = new PayPalProcessor();
            PaymentService paymentService2 = new PaymentService(payPalProcessor);
            paymentService2.ProcessOrderPayment(50.00m);*/

            ILogger fileLogger = new FileLogger();
            Application appWithFileLogger = new Application(fileLogger);

            ILogger databaseLogger = new DatabaseLogger();
            Application appWithDatabaseLogger = new Application(databaseLogger);
            appWithFileLogger.work();
            appWithDatabaseLogger.work();
            Console.ReadKey();
        }
    }
}
