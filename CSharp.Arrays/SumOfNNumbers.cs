using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class SumOfNNumbers
    {
        public void Run()
        {
            int number;

            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();

            if (!ValidateInput(input, out number))
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int sum = CalculateSum(number);
            Console.WriteLine($"The sum of numbers from 1 to {number} is: {sum}");
        }

        private bool ValidateInput(string input, out int number)
        {
            return int.TryParse(input, out number) && number > 0;
        }

        private int CalculateSum(int number)
        {
            return number * (number + 1) / 2;
        }
    }
}
