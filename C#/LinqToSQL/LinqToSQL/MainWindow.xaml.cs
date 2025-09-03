using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.PanjutorialsDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
            //InsertUniversity();
            //InsertStudent();
            //InsertLectures();
            //InsertStudentLectureAssociation();
            //GetUniversityofToni();
            //GetToniLectures();
            //GetAllStudentsFromYale();
            //GetAllLecturesFromBeijingTech();
            UpdateToni();
        }

        public void InsertUniversity()
        {
            dataContext.ExecuteCommand(" FROM University");
            University university = new University();
            university.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(university);
            dataContext.SubmitChanges();

            University beijingTech = new University();
            beijingTech.Name = "Beijing Tech";
            dataContext.Universities.InsertOnSubmit(beijingTech);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudent()
        {
            University yale = dataContext.Universities.FirstOrDefault(u => u.Name == "Yale");
            University beijingTech = dataContext.Universities.FirstOrDefault(u => u.Name == "Beijing Tech");
            List<Student> students = new List<Student>()
            {
                new Student(){ Name="Carla", Gender="female", UniversityID=yale.Id },
                new Student(){ Name="Toni",Gender="male",  University = yale },
                new Student(){ Name="Leyla", Gender="female", University = beijingTech},
                new Student(){ Name="David", Gender="male",  University = beijingTech }
            };
            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture() { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture() { Name = "Physics" });

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociation()
        {
            Student carla = dataContext.Students.FirstOrDefault(s => s.Name == "Carla");
            Student leyla = dataContext.Students.FirstOrDefault(s => s.Name == "Leyla");
            Student toni = dataContext.Students.FirstOrDefault(s => s.Name == "Toni");
            Student david = dataContext.Students.FirstOrDefault(s => s.Name == "David");
            Lecture math = dataContext.Lectures.FirstOrDefault(l => l.Name == "Math");
            Lecture physics = dataContext.Lectures.FirstOrDefault(l => l.Name == "Physics");
            List<StudentLecture> studentLectures = new List<StudentLecture>()
            {
                new StudentLecture(){ Student=carla, Lecture=math },
                new StudentLecture(){ Student=carla, Lecture=physics },
                new StudentLecture(){ Student=leyla, Lecture=math },
                new StudentLecture(){ Student=toni, Lecture=math },
                new StudentLecture(){ Student=david, Lecture=physics }

            };
            dataContext.StudentLectures.InsertAllOnSubmit(studentLectures);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityofToni()
        {
            Student toni = dataContext.Students.FirstOrDefault(s => s.Name == "Toni");
            University ToniUni = toni.University;
            List<University> universities = new List<University>();
            universities.Add(ToniUni);
            MainDataGrid.ItemsSource = universities;
        }

        public void GetToniLectures()
        {
            Student toni = dataContext.Students.FirstOrDefault(s => s.Name == "Toni");
            var ToniLectures = from sl in toni.StudentLectures
                              select sl.Lecture;
            MainDataGrid.ItemsSource = ToniLectures;
        }

        public void GetAllStudentsFromYale()
        {
            University yale = dataContext.Universities.FirstOrDefault(u => u.Name == "Yale");
            var yaleStudents = from s in yale.Students
                               select s;
            MainDataGrid.ItemsSource = yaleStudents;
        }

        public void GetAllLecturesFromBeijingTech()
        {
            var beijingTechLectures = from s in dataContext.StudentLectures
                                      join student in dataContext.Students on s.StudentId equals student.Id
                                      where student.University.Name == "Beijing Tech"
                                      select s.Lecture;
            MainDataGrid.ItemsSource = beijingTechLectures.Distinct();
        }

        public void UpdateToni()
        {
            Student toni = dataContext.Students.FirstOrDefault(s => s.Name == "Toni");
            toni.Name = "Antonio";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteDavid()
        {
            Student david = dataContext.Students.FirstOrDefault(s => s.Name == "David");
            dataContext.Students.DeleteOnSubmit(david);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
