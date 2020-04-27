﻿using System;


// Namespace
namespace NumberGuesser
{
    // Main Class
    class MainClass
    {
        // Entry Point Method
        public static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function

            GreetUser(); // Ask for user's name and greet


            while (true)
            {
                // Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;


                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");


                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Pleae use an actual number.");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Congratulations! You are correct!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
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


        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Christiaan Venter";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }


        // Ask user's name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Not a number message
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}