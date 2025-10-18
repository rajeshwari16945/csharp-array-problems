using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class DynamicArray
    {
        int[] currentArray = new int[2];
        int[] backupArray = null;
        int count = 0;

        public void Menu()
        {
            Console.WriteLine("Enter the any: 1. Insert At Last " +
                "2. Insert At First 3. Insert At Any Position 4. Print 5. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: InsertElementAtLast();
                        break;
                case 2: InsertElementAtFirst();
                        break;
                case 3: InsertElementAtPosition();
                    break;
                case 4: PrintArray();
                        break;
                case 5: Console.WriteLine("Exit from the program");
                        return;
                default: Console.WriteLine("Invalid choice. Try again.");
                        break;
            }
        }

        public void InsertElementAtFirst()
        {
            Console.WriteLine("Enter value to insert at position " + (0 + 1) + ": ");
            int value = Convert.ToInt32(Console.ReadLine());
            checkCapacityAndResize();
            shiftRightAndInsert(value, 0);
            count++;
            Menu();
        }

        public void InsertElementAtPosition()
        {
            Console.WriteLine("Enter the position from: 0 to " + (count + 1));
            int pos = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Enter value to insert at position " + (pos+1) + ": ");
            int value = Convert.ToInt32(Console.ReadLine());
            checkCapacityAndResize();
            shiftRightAndInsert(value, pos);
            count++;
            Menu();
        }

        public void InsertElementAtLast()
        {
            Console.WriteLine("Enter value to insert at end: ");
            int value = Convert.ToInt32(Console.ReadLine());
            checkCapacityAndResize();
            GetActiveArray()[count] = value;
            count++;
            Menu();
        }

        public int[] shiftRightAndInsert(int value, int pos)
        {
            int[] array = GetActiveArray();
            for (int i = array.Length - 1; i > 0+pos; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = value;
            return array;
        }

        private void checkCapacityAndResize()
        {
            int[] array = GetActiveArray();
            if (count < array.Length) return;

            int[] newArray = new int[array.Length + 2];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }

            if (currentArray != null)
            {
                backupArray = newArray;
                currentArray = null;
            }
            else
            {
                currentArray = newArray;
                backupArray = null;
            }
        }

        public void PrintArray()
        {
            int[] array = GetActiveArray();
            Console.WriteLine("The elements in the array are: " + string.Join(", ", array));
            Menu();
        }

        private int[] GetActiveArray()
        {
            return currentArray ?? backupArray;
        }
    }
}
