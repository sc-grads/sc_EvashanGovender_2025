using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    internal class Program
    {
        //Key - Value pair
        //Auto - car
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student student1 = new Student(1, "Alice", 3.5);
            Student student2 = new Student(2, "Bob", 3.8);
            Student student3 = new Student(3, "Charlie", 3.2);
            Student student4 = new Student(4, "David", 3.9);

            studentsTable.Add(student1.Id, student1);
            studentsTable.Add(student2.Id, student2);
            studentsTable.Add(student3.Id, student3);
            studentsTable.Add(student4.Id, student4);

            Student storedStudent1 = (Student)studentsTable[1];

            foreach (DictionaryEntry entry in studentsTable)
            {
                Student student = (Student)entry.Value;
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, GPA: {student.GPA}");
            }

          //  Console.WriteLine($"Student ID: {storedStudent1.Id}, Name: {storedStudent1.Name}, GPA: {storedStudent1.GPA}");
            Console.ReadKey();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double GPA { get; set; }
        public Student(int id, string name, double gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }
    }
}
