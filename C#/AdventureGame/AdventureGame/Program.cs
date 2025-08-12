using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure Game!");
            Console.WriteLine("Enter your charcter's name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Choose your character type(Warrior,Wizard,Archer)");
            string characterType = Console.ReadLine().ToLower();

            Console.WriteLine($"You, {playerName} the {characterType} find youself at the edge of a dark forest");
            Console.WriteLine("Do you want to enter the forest or camp outside? (Enter/Camp)");
            string choice = Console.ReadLine().ToLower();
            if (choice == "enter")
            {
                Console.WriteLine("You bravely enter the forest");
            }
            else
            {
                Console.WriteLine("You decide to camp outside and wait for morning light");
            }

            bool gameContinues = true;
            while (gameContinues)
            {
                Console.WriteLine("You come to a fork in the road. Go left or right?");
                string direction = Console.ReadLine().ToLower();
                if (direction == "left")
                {
                    Console.WriteLine("You find a treasure chest");
                    gameContinues = false;
                }
                else
                {
                    Console.WriteLine("You encounter a wild beast!");
                    Console.WriteLine("Do you want to fight or run? (Fight/Run)");
                    string action = Console.ReadLine().ToLower();
                    if (action == "fight")
                    {
                        Random random = new Random();
                        int luck = random.Next(1, 11); // Random number between 1 and 10
                        if(luck > 5)
                        {
                            Console.WriteLine($"You bravely fight the beast and win, {playerName} the {characterType}!");
                            if(luck > 8)
                                Console.WriteLine("You find a magical artifact in the beast's lair!");
                            gameContinues = false;
                        }
                        else
                        {
                            Console.WriteLine("You fought bravely but were defeated by the beast.");
                            Console.WriteLine("Game Over!");
                            gameContinues = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("You run away safely, but the adventure continues another day.");
                        gameContinues = false;
                    }
                }
            }

            Console.WriteLine("Thank you for playing the Adventure Game!");
            Console.ReadKey();
        }
    }
}
