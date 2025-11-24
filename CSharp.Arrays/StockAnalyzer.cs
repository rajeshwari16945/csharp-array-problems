using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    class StockAnalyzer
    {
        public static void calculate()
        {
            Console.WriteLine("Enter the number of days:");
            int n = int.Parse(Console.ReadLine());
            int[] prices = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter price for day {i + 1}: ");
                prices[i] = int.Parse(Console.ReadLine());
            }

            int minPrice = prices[0], maxProfit = 0;
            int buyDay = 0, sellDay = 0;

            for (int i = 1; i < n; i++)
            {
                int profit = prices[i] - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                    sellDay = i;
                }
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    buyDay = i;
                }
            }

            double sum = 0;
            foreach (int price in prices)
                sum += price;
            double avg = sum / n;

            Console.WriteLine($"\nMinimum price: {minPrice}");
            Console.WriteLine($"Maximum price: {prices[sellDay]}");
            Console.WriteLine($"Average price: {avg:F2}");
            Console.WriteLine($"Maximum profit possible: {maxProfit}");
            Console.WriteLine($"Buy on day {buyDay + 1}, Sell on day {sellDay + 1}");
        }
    }

}
