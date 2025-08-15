using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions[] questions = new Questions[]
            {
                new Questions("What is the capital of France?", new string[] { "Madrid", "Berlin", "Paris", "London" }, 1),
                new Questions("What is 2 + 2?", new string[] { "3", "4", "5", "6" }, 1),
                new Questions("What is the largest planet in our solar system?", new string[] { "Earth", "Mars", "Jupiter", "Saturn" }, 2)
            };
            Quiz quiz = new Quiz(questions);
            //Console.WriteLine("Welcome to the OOP Quiz!");
            // Here you would typically call a method to start the quiz, e.g., quiz.Start();
            quiz.StartQuiz();

            Console.ReadKey();
        }
    }
}
