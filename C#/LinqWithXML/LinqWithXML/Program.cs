using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>1</Semester>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>10</Semester>
                            </Student>
                        </Students>";
            XDocument studentsXDoc = new XDocument();
            studentsXDoc = XDocument.Parse(studentsXML);

            var students = from s in studentsXDoc.Descendants("Student")
                           where (int)s.Element("Age") > 18
                           select new
                           {
                               Name = s.Element("Name").Value,
                               Age = (int)s.Element("Age"),
                               University = s.Element("University").Value,
                               Semester = (int)s.Element("Semester")
                           };

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, University: {student.University}, Semester: {student.Semester}");
            }

            var sortedStudents = from s in students
                                 orderby s.Age
                                 select s;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, University: {student.University}, Semester: {student.Semester}");
            }

            Console.ReadKey();
        }
    }
}
