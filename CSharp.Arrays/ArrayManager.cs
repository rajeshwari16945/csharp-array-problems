using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArrayManager
    {
        public static void StringArrayManager()
        {
            List<string> words = new List<string>();
            bool running = true;

            Console.WriteLine("=== String Array Manager ===");
            Console.WriteLine("Commands: add, show, search, remove, exit");

            while (running)
            {
                Console.Write("\nEnter a command: ");
                string command = Console.ReadLine()?.Trim().ToLower();

                switch (command)
                {
                    case "add":
                        Console.Write("Enter a word to add: ");
                        string word = Console.ReadLine()?.Trim();
                        if (!string.IsNullOrEmpty(word))
                        {
                            words.Add(word);
                            Console.WriteLine($"'{word}' added to the list.");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid word.");
                        }
                        break;

                    case "show":
                        Console.WriteLine("\nCurrent words:");
                        if (words.Count == 0)
                            Console.WriteLine("List is empty.");
                        else
                            Console.WriteLine(string.Join(", ", words));
                        break;

                    case "search":
                        Console.Write("Enter a word to search for: ");
                        string search = Console.ReadLine()?.Trim();
                        if (words.Contains(search))
                            Console.WriteLine($"'{search}' found in the list.");
                        else
                            Console.WriteLine($"'{search}' not found.");
                        break;

                    case "remove":
                        Console.Write("Enter a word to remove: ");
                        string remove = Console.ReadLine()?.Trim();
                        if (words.Remove(remove))
                            Console.WriteLine($"'{remove}' removed from the list.");
                        else
                            Console.WriteLine($"'{remove}' not found in the list.");
                        break;

                    case "exit":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Unknown command. Try: add, show, search, remove, or exit.");
                        break;
                }
            }
        
        }
    }
}
