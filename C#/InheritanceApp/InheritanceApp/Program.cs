using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal drake = new Dog();
          //  drake.Eat(); // Calls the method from the base class Animal
            Dog myDog = new Dog();
            myDog.MakeSound(); // Calls the overridden method in Dog
           // myDog.Eat(); // Calls the method from the base class Animal

            Cat myCat = new Cat();
            myCat.MakeSound(); // Calls the overridden method in Cat
            //myCat.Eat(); // Calls the method from the base class Animal

            Manager Joe  = new Manager("Joe", 30, "Software Engineer", 12345,10);
            Joe.BecomeOlder(5);
            Joe.DisplayManagerInfo();
             
            //Joe.ToString();
            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Eat()
        {
            
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound...");
        }
    }

    //Derived class: The class that inherits the members of the base class
    class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound(); // Calls the base class method
            Console.WriteLine("Barking...");
        }
    }

    class Collie : Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts...");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        { 
            Console.WriteLine("Meowing...");
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Person Constructor Called");
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }

        public void BecomeOlder(int years)
        {
            Age += years;
        }

    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }

        public int EmployeeId { get; set; }
        public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
            Console.WriteLine($"Employee Constructor Called");
           
        }
        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"I work as a {JobTitle} with Employee ID: {EmployeeId}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get;private set; }
        public Manager(string name, int age, string jobTitle, int employeeId, int teamSize) : base(name, age, jobTitle, employeeId)
        {
            TeamSize = teamSize;
            Console.WriteLine($"Manager Constructor Called");
            
        }
        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine("Team Size: " + TeamSize);
        }
    }
}
