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
            Console.WriteLine("Enter the any: 1. Insert 2. Print 3. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the element into the array: ");
                InsertElement();
            }
            else if (choice == 2)
            {
                Console.WriteLine("The elements in the array are: ");
                PrintArray();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Exit from the program");
            }
        }

        public void InsertElement()
        {
            if (firstArray != null && count < firstArray.Length)
                ReadAndInsertElement("first");
            else if (secondArray != null && count < secondArray.Length)
                ReadAndInsertElement("second");
            else if (firstArray != null && count == firstArray.Length)
            {
                secondArray = CreateArray(firstArray, secondArray);
                firstArray = null;
                ReadAndInsertElement("second");
            }
            else if (secondArray != null && count == secondArray.Length)
            {
                firstArray = CreateArray(secondArray, firstArray);
                secondArray = null;
                ReadAndInsertElement("first");

            }
            ResizeArrayDynamically();
        }

        public void ReadAndInsertElement(string whichArray)
        {
            if(whichArray == "first")
            {
                firstArray[count] = Convert.ToInt32(Console.ReadLine());
            }
            else if(whichArray == "second")
            {
                secondArray[count] = Convert.ToInt32(Console.ReadLine());
            }
            count++;
        }

        public int[] CreateArray(int[] orginalArray, int[] newArray)
        {
            newArray = new int[orginalArray.Length + 2];
            for (int i = 0; i < orginalArray.Length; i++)
            {
                newArray[i] = orginalArray[i];
            }
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
