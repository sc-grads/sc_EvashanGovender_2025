using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectsAndQueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.malesStudents();
            um.femalesStudents();
            um.SortStudentsByAge();
            um.AllStudentFromBeijingTech();
            Console.Write("Enter University ID: ");
            um.GetStudent(int.Parse(Console.ReadLine()));
            um.StudentAndUniversityNameCollection();
            Console.ReadKey();
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "male", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void malesStudents()
        {
            IEnumerable<Student> maleStudents = from s in students where s.Gender == "male" select s;
            Console.WriteLine("Males - Students: ");
            foreach (var student in maleStudents)
            {
                student.Print();
            }
        }

        public void femalesStudents()
        {
            IEnumerable<Student> femaleStudents = from s in students
                                                  where
                                                  s.Gender == "female"
                                                  select s;
            Console.WriteLine("Female - Students");
            foreach (var student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            IEnumerable<Student> sortedStudents = from s in students
                                                  orderby s.Age
                                                  select s;
            Console.WriteLine("Sorted Students by Age: ");
            foreach (var student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentFromBeijingTech()
        {
            IEnumerable<Student> studentFromBejingTech = from s in students
                                                        join u in universities on s.UniversityId equals u.Id
                                                        where u.Name == "Beijing Tech"
                                                        select s;
            Console.WriteLine("Students from Beijing Tech: ");
            foreach (var student in studentFromBejingTech)
            {
                student.Print();
            }
        }

        public void GetStudent(int id)
        {
            IEnumerable<Student> myStudents = from s in students
                                                         join u in universities on s.UniversityId equals u.Id
                                                         where u.Id == id
                                                         select s;
            Console.WriteLine("Students from Uni {0}: ", id);
            foreach (var student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from s in students
                                join u in universities on s.UniversityId equals u.Id
                                orderby s.Name
                                select new { StudentName = s.Name, UniversityName = u.Name };

            Console.WriteLine("New Collection: ");
            foreach (var item in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", item.StudentName, item.UniversityName);
            }
        }
    }

    class University
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}",Name,Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        // Foreign key
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("Student {0} with id {1} age {3} from university with id {2}", Name, Id, UniversityId,Age);
        }
    }
}
