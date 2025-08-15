using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuizApp
{
    internal class Quiz
    {
        private Questions[] questions;
        private int score;
        public Quiz(Questions[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                           Welcome to the Quiz!                          ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            int questionNumber = 1;
            foreach (Questions question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrect(userChoice))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct Answer!");
                    Console.ResetColor();
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong Answer! The correct answer was {question.Answers[question.CorrectAnswerIndex]}");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine($"You got a score of {score}/{questions.Length}"); 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank you for participating in the quiz!");
            Console.ResetColor();
        }
        public void DisplayQuestion(Questions question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");

            }

            
        }

        private int GetUserChoice()
        {
            int choice = 0;
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            while (!int.TryParse(input,out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please Enter a number between 1 and 4.");
                input = Console.ReadLine();
            }

            return choice - 1; // Convert to zero-based index
        }
    }
}
