using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeT
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1988,5,31);
            Console.WriteLine("My birthday is : {0}",dateTime);

            // Display the current date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: {0}", currentDateTime);
            Console.WriteLine("Tomorrow's date is: {0}", getTomorrow());
            Console.WriteLine("Today is {0}",DateTime.Today.DayOfWeek);
            Console.WriteLine("The first day of the year 1999 is: {0}", GetFirstDayOfYear(1999).DayOfWeek);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: ", now.Minute);

            Console.WriteLine("{0}:{1}:{2}",now.Hour,now.Minute,now.Second);

            Console.WriteLine("Write a date in this format: yyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input,out dateTime))
            {
                Console.WriteLine("You entered a valid date: {0}", dateTime);
                TimeSpan timeSpan = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}",timeSpan.Days);
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
            {

            }
            Console.ReadKey();
        }

        static DateTime getTomorrow()
        {
            // Get the current date and time
            DateTime currentDateTime = DateTime.Today;
            // Add one day to the current date
            DateTime tomorrow = currentDateTime.AddDays(1);
            // Return the new date
            return tomorrow;
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            // Create a new DateTime object for the first day of the specified year
            DateTime firstDay = new DateTime(year, 1, 1);
            // Return the new date
            return firstDay;
        }
    }
}
