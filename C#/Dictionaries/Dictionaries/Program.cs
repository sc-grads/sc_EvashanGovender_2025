using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

        public Employee(int age, string name, int salary)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> employees = new Dictionary<int, string>
            {
                { 101, "Alice" },
                { 102, "Bob" },
                { 103, "Charlie" }
            };

            employees.Add(104, "David");
            employees.Add(105, "John");

            string name  = employees[102];
            employees[102] = "Robert";
            employees.Remove(103);
            foreach (KeyValuePair<int,string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key} - Name: {employee.Value}");
            }

            //bool tryAdd = employees.TryAdd(106, "Eve");*/

            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            employees.Add(1, new Employee(35, "John Doe", 100000));   
            employees.Add(2, new Employee(28, "Jane Smith", 120000));
            employees.Add(3, new Employee(45, "Alice Johnson", 150000));
            employees.Add(4, new Employee(30, "Bob Brown", 90000));
            foreach(var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key} - Name: {employee.Value.Name}, Age: {employee.Value.Age}, Salary: {employee.Value.Salary}");
            }
            Console.ReadKey();
        }
    }
}
