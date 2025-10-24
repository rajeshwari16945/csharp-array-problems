using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class StackImplementationWithArray
    {
        Object[] stackIntArray;
        int count = 0;

        public StackImplementationWithArray()
        {
            stackIntArray = new Object[5];
        }

        public void Push(Object value)
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

    public class StackImplementationWithStringArray
    {
        string[] stackStringArray;
        int count = 0;

        public StackImplementationWithStringArray()
        {
            stackStringArray = new string[5];
        }

        public void Push(string value)
        {
            stackStringArray[count] = value;
            count++;
            PrintSack();
        }

        public void Pop()
        {
            if (count > 0)
            {
                stackStringArray[count - 1] = "";
                Console.WriteLine("Element popped successfully.");
            }
            count--;
            PrintSack();
        }

        public void Peek()
        {
            if (count > 0)
            {
                Console.WriteLine("Top element is: " + stackStringArray[count - 1]);
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
                Console.Write(stackStringArray[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public class StackImplementationWithFloatArray
    {
        float[] stackStringArray;
        int count = 0;

        public StackImplementationWithFloatArray()
        {
            stackStringArray = new float[5];
        }

        public void Push(float value)
        {
            stackStringArray[count] = value;
            count++;
            PrintSack();
        }

        public void Pop()
        {
            if (count > 0)
            {
                stackStringArray[count - 1] = 0.0f;
                Console.WriteLine("Element popped successfully.");
            }
            count--;
            PrintSack();
        }

        public void Peek()
        {
            if (count > 0)
            {
                Console.WriteLine("Top element is: " + stackStringArray[count - 1]);
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
                Console.Write(stackStringArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
