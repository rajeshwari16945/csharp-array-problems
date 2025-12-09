using System;
using System.Threading;

class MemoryGame
{
    public static void play()
    {
        Console.WriteLine("=== Memory Sequence Game (Simon Says Lite) ===\n");
        Console.WriteLine("You will see a sequence of numbers.");
        Console.WriteLine("Repeat them exactly to move to the next round.\n");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();

        Random rand = new Random();
        int[] sequence = new int[50]; 
        int level = 1;

        for (int i = 0; i < sequence.Length; i++)
            sequence[i] = rand.Next(1, 10);

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"=== ROUND {level} ===");
            Console.WriteLine("Memorize the numbers:");

            for (int i = 0; i < level; i++)
            {
                Console.Write(sequence[i] + " ");
                Thread.Sleep(600);
            }

            Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine($"Enter the {level} numbers, separated by space:");

            string input = Console.ReadLine();
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != level)
            {
                Console.WriteLine("❌ Wrong number of inputs!");
                break;
            }

            bool correct = true;
            for (int i = 0; i < level; i++)
            {
                if (int.Parse(parts[i]) != sequence[i])
                {
                    correct = false;
                    break;
                }
            }

            if (!correct)
            {
                Console.WriteLine("\n❌ Wrong sequence!");
                Console.WriteLine($"You reached level {level}.");
                break;
            }

            Console.WriteLine("✔ Correct! Next round...");
            Thread.Sleep(900);
            level++;
        }

        Console.WriteLine("\n=== GAME OVER ===");
    }
}
