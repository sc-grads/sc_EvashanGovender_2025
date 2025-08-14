using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherSimulatorApp
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];
            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40); // Random temperature between -10 and 35 degrees
                weatherConditions[i] = conditions[random.Next(conditions.Length)]; // Random weather condition
            }

            Console.WriteLine($"Average temperature: {CalculateAverage(temperature)}");
            Console.WriteLine($"Max temperature: {temperature.Max()}");
            Console.WriteLine($"Min temperature: {temperature.Min()}");
            Console.WriteLine($"Most common weather condition: {MostCommonCondition(weatherConditions)}");
            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];
            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[i] == conditions[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }
            }

            return mostCommon;
        }

        static double CalculateAverage(int[] temperatures)
        {
            double sum = 0;
            foreach (int temp in temperatures)
            {
                sum += temp;
            }
            double average =  sum / temperatures.Length;
            return  average;
        }
    }
}
