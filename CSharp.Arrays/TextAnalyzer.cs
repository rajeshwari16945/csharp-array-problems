using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class TextAnalyzer
    {
        public static void Analyze()
        {
            Console.WriteLine("Enter text to analyze:");
            string text = Console.ReadLine();

            int[] freq = new int[26];
            int letterCount = 0;
            int wordCount = 0;
            bool inWord = false;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (IsLetter(c))
                {
                    letterCount++;
                    char lower = ToLower(c);
                    int index = lower - 'a';
                    freq[index]++;

                    if (!inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            Console.WriteLine("\n===== TEXT ANALYSIS =====");
            Console.WriteLine($"Letters: {letterCount}");
            Console.WriteLine($"Words:   {wordCount}\n");

            Console.WriteLine("Letter Frequencies:");
            for (int i = 0; i < 26; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"{(char)('A' + i)}: {freq[i]}");
                }
            }
        }

        static bool IsLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        static char ToLower(char c)
        {
            if (c >= 'A' && c <= 'Z')
                return (char)(c + 32);
            return c;
        }
    }
}
