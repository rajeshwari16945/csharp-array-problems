using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class StabilityAwareReordering
    {
        public static int[] ReorderArray(int[] arr)
        {
            List<int> primes = new List<int>();
            List<int> nonPrimeEvens = new List<int>();
            List<int> nonPrimeOdds = new List<int>();

            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                }
                else if (num % 2 == 0)
                {
                    nonPrimeEvens.Add(num);
                }
                else
                {
                    nonPrimeOdds.Add(num);
                }
            }

            int[] result = new int[arr.Length];
            int index = 0;

            foreach (int p in primes)
                result[index++] = p;

            foreach (int e in nonPrimeEvens)
                result[index++] = e;

            foreach (int o in nonPrimeOdds)
                result[index++] = o;

            return result;
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
