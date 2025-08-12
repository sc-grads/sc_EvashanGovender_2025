using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Loops
            /* int i = 0;
             while (i < 10)
             {
                 Console.WriteLine(i);
                 i++;
             }*/
            int counter = 0; 
            int secretNumber = 42;
            int userGuess = 0;
           Console.WriteLine("Guess the number Im thinking of between 1 an 100");
            while (userGuess != secretNumber)
            {
                counter++;
                Console.WriteLine("Enter your guess: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess < secretNumber)
                    {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed the number! It took you " + counter + " tries");
                }
            }
                



                Console.ReadKey();
        }
    }
}
