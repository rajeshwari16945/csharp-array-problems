using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class DynamicArray
    {

        int[] firstArray = new int[2];
        int[] secondArray;
        int count = 0;

        public void ResizeArrayDynamically()
        {
            Console.WriteLine("Enter the any: 1. Insert At Last 2. Print 3. Insert At First 4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the element in the last of the array: ");
                InsertElementAtLast();
            }
            else if (choice == 2)
            {
                Console.WriteLine("The elements in the array are: ");
                PrintArray();
            }
            else if(choice == 3)
            {
                Console.WriteLine("Enter the element in the first of the array: ");
                InsertElementAtFirst();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Exit from the program");
            }
        }

        public void InsertElementAtFirst()
        {
            if (firstArray != null && count < firstArray.Length)
                ReadAndInsertElementInFirst("first");
            else if (secondArray != null && count < secondArray.Length)
                ReadAndInsertElementInFirst("second");
            else if (firstArray != null && count == firstArray.Length)
            {
                secondArray = CreateArrayForFirst(firstArray, secondArray, Convert.ToInt32(Console.ReadLine()));
                firstArray = null;
            }
            else if (secondArray != null && count == secondArray.Length)
            {
                firstArray = CreateArrayForFirst(secondArray, firstArray, Convert.ToInt32(Console.ReadLine()));
                secondArray = null;
            }
            ResizeArrayDynamically();
        }

        public void InsertElementAtLast()
        {
            if (firstArray != null && count < firstArray.Length)
                ReadAndInsertElementInLast("first");
            else if (secondArray != null && count < secondArray.Length)
                ReadAndInsertElementInLast("second");
            else if (firstArray != null && count == firstArray.Length)
            {
                secondArray = CreateArrayForLast(firstArray, secondArray);
                firstArray = null;
                ReadAndInsertElementInLast("second");
            }
            else if (secondArray != null && count == secondArray.Length)
            {
                firstArray = CreateArrayForLast(secondArray, firstArray);
                secondArray = null;
                ReadAndInsertElementInLast("first");

            }
            ResizeArrayDynamically();
        }

        public void ReadAndInsertElementInFirst(string whichArray)
        {
            if(whichArray == "first")
            {
                int value = Convert.ToInt32(Console.ReadLine());
                firstArray = moveElementsOnePositionToRight(firstArray, value);
            }
            else if(whichArray == "second")
            {
                int value=  Convert.ToInt32(Console.ReadLine());
                secondArray = moveElementsOnePositionToRight(secondArray, value);
            }
            count++;
        }

        public void ReadAndInsertElementInLast(string whichArray)
        {
            if (whichArray == "first")
            {
                firstArray[count] = Convert.ToInt32(Console.ReadLine());
            }
            else if (whichArray == "second")
            {
                secondArray[count] = Convert.ToInt32(Console.ReadLine());
            }
            count++;
        }

        public int[] moveElementsOnePositionToRight(int[] array, int value)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = value;
            return array;
        }

        public int[] CreateArrayForLast(int[] orginalArray, int[] newArray)
        {
            newArray = new int[orginalArray.Length + 2];
            for (int i = 0; i < orginalArray.Length; i++)
            {
                newArray[i] = orginalArray[i];
            }
            return newArray;
        }

        public int[] CreateArrayForFirst(int[] orginalArray, int[] newArray, int val)
        {
            newArray = new int[orginalArray.Length + 2];
            newArray[0] = val;
            for (int i = 0; i < orginalArray.Length; i++)
            {
                newArray[i+1] = orginalArray[i];
            }
            count++;
            return newArray;
        }

        public void PrintArray()
        {
            if (firstArray != null)
            {
                Console.WriteLine(string.Join(", ", firstArray)); 
            }
            else if (secondArray != null)
            {
                Console.WriteLine(string.Join(", ", secondArray));
            }
            ResizeArrayDynamically();
        }
    }
}
