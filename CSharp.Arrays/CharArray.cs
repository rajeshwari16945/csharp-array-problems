using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class CharArray
    {
        public static void PrintCharArray() 
        {
            string[] names = { "Alice", "Bob", "Charlie" };
            Console.WriteLine("Names in the array:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            char[] word = { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine("Original char array: " + new string(word));

            for (int i = 0; i < word.Length; i++)
            {
                word[i] = char.ToUpper(word[i]);
            }

            Console.WriteLine("Uppercase char array: " + new string(word));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
