using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Q1 = "What is the capital of Germany";
            string A1 = "Berlin";

            string Q2 = "What is 2+2";
            string A2 = "4";

            string Q3 = "What color do you get by mixing blue and yellow";
            string A3 = "Green";

            int score = 0;

            Console.WriteLine("Welcome to the Quiz App!");
            Console.WriteLine("Please answer the following questions:\n");
            Console.WriteLine("1. " + Q1);
            string answer1 = Console.ReadLine();

            if (answer1.Trim().Equals(A1, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + A1);
            }

            Console.WriteLine("\n2. " + Q2);
            string answer2 = Console.ReadLine();
            if (answer2.Trim().Equals(A2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + A2);
            }

            Console.WriteLine("\n3. " + Q3);
            string answer3 = Console.ReadLine();
            if (answer3.Trim().Equals(A3, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + A3);
            }
            Console.WriteLine("Your score is :" + score);
            Console.ReadKey();
        }
    }
}
