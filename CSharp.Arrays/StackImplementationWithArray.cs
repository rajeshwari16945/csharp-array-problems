using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class StackImplementationWithArray
    {
        int[] stackIntArray;
        int count = 0;

        public StackImplementationWithArray()
        {
            stackIntArray = new int[5];
        }

        public void Push(int value)
        {
            stackIntArray[count] = value;
            count++;
            PrintSack();
        }

        public void Pop()
        {
            if (count > 0)
            {
                stackIntArray[count - 1] = 0;
                Console.WriteLine("Element popped successfully.");
            }
            count--;
            PrintSack();
        }

        public void Peek()
        {
            if (count > 0)
            {
                Console.WriteLine("Top element is: " + stackIntArray[count - 1]);
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
            PrintSack();
        }

        public void PrintSack()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(stackIntArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
