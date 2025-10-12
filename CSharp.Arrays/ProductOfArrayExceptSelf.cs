using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ProductOfArrayExceptSelf
    {
        public void getTheProductOfArrayExceptSelf()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] inputArray = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] resultArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                int result = 1;
                for (int j = 0; j < size; j++)
                {
                    if(i != j)
                    {
                        result *= inputArray[j];
                    }
                }
                resultArray[i] = result;
            }

            Console.WriteLine("The product of array except self is:" + string.Join(", ", resultArray));
        }
    }
}
