using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class JumpGameWithArray
    {
        public void CanJump()
        {
            Console.WriteLine("Enter the size of the array:");
            int size =  int.Parse(Console.ReadLine());
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                nums[i] = int.Parse(Console.ReadLine());
            }
            int pos = 0;
            while(pos < nums.Length)
            {
                if(pos == nums.Length - 1)
                {
                    Console.WriteLine("True");
                    return;
                } else
                {
                    pos += nums[pos];
                }
            }
            Console.WriteLine("False");

        }
    }
}
