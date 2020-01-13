using System;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxNumber;
            int minNumber;
            int guess;

            string inputName;
            string inputDirection;
            // Welcome Text
            PrintColorMessage(ConsoleColor.Green, "Welcome to Number Guesser, human!\n_________________________________\n");

            // Setting the initiale variables
            maxNumber = 1000;
            minNumber = 1;
            guess = 500;

            // Player's name
            Console.WriteLine("What's your name?");
            inputName = Console.ReadLine();

            while (true)
            {
                // Starting text
                Console.WriteLine($"\nThink of a number between {minNumber} and {maxNumber}. I will try to guess it.");
                Console.WriteLine($"So, {inputName}, is your number higher or lower than {guess}?");

                // Rule text
                PrintColorMessage(ConsoleColor.DarkYellow, "Write 'H' if is higher, or 'L' if it's lower, and 'Y' if it's correct.");

                // Reach number 1000 (999+1)
                maxNumber += 1;

                // Getting the first guess from player
                inputDirection = Console.ReadLine().ToUpper();

                while (inputDirection != "Y")
                {
                    if (inputDirection == "H")
                    {
                        minNumber = guess;
                        guess = (maxNumber + minNumber) / 2;
                        Console.WriteLine($"Is it higher or lower than... {guess}?");
                        inputDirection = Console.ReadLine().ToUpper();
                    }
                    else if (inputDirection == "L")
                    {
                        maxNumber = guess;
                        guess = (maxNumber + minNumber) / 2;
                        Console.WriteLine($"Is it higher or lower than... {guess}?");
                        inputDirection = Console.ReadLine().ToUpper();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Don't type things that I don't know!");
                        Console.ResetColor();
                        inputDirection = Console.ReadLine().ToUpper();
                    }
                }

                // If the guess is correct
                PrintColorMessage(ConsoleColor.Blue, "That was easy!");

                // Ask to play again
                Console.WriteLine("Play again? [Y/N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    maxNumber = 1000;
                    minNumber = 1;
                    guess = 500;
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
