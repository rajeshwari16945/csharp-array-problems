using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class GuessFromArray
    {
        public static void GuessTheValueFromArray()
        {

            Console.WriteLine("=== Guess the Value From Array Game ===\n");

            // Step 1: Define an array of possible values
            string[] values = { "apple", "banana", "cherry", "date", "fig", "grape" };

            // Step 2: Randomly select one value as the secret
            Random random = new Random();
            string secretValue = values[random.Next(values.Length)];

            // Step 3: Prepare an array to store guesses
            string[] guesses = new string[100]; // max 100 guesses
            int attempts = 0;
            bool guessed = false;

            Console.WriteLine("I have picked a fruit from the following list:");
            Console.WriteLine(string.Join(", ", values));
            Console.WriteLine("\nTry to guess which one it is!\n");

            // Step 4: Game loop
            while (!guessed && attempts < guesses.Length)
            {
                Console.Write("Enter your guess: ");
                string userGuess = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(userGuess))
                {
                    Console.WriteLine(" Please enter a valid value.\n");
                    continue;
                }

                // Store the guess
                guesses[attempts] = userGuess;
                attempts++;

                // Check the guess
                if (userGuess.Equals(secretValue, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n Correct! You guessed it in {attempts} attempts!");
                    guessed = true;
                }
                else
                {
                    Console.WriteLine(" Wrong guess. Try again!\n");
                }
            }

            // Step 5: Display guess history
            Console.WriteLine("\nYour guesses were:");
            for (int i = 0; i < attempts; i++)
            {
                Console.Write(guesses[i]);
                if (i < attempts - 1) Console.Write(", ");
            }

            Console.WriteLine("\n\nThanks for playing! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
