using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                "2. Insert At First 3. Insert At Any Position 4. Insert At Mid point 5. Print 6. Delete At End " +
                "7. Delete if Element Exist 8. Delete from start 9. Delete from Any Position 10. Search for a element " +
                "11. Clear the Array 12. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: InsertElementAtLast(); break;
                case 2: InsertElementAtFirst(); break;
                case 3: InsertElementAtPosition(); break;
                case 4: InsertElementAtMidpoint(); break;
                case 5: PrintArray(); break;
                case 6: DeleteFromEnd(); break;
                case 7: DeleteIfElementExists(); break;
                case 8: DeleteFromStart(); break;
                case 9: DeleteAtPosition(); break;
                case 10: SearchForElement(); break;
                case 11: ClearArray(); break;
                case 12: Console.WriteLine("Exit from the program"); return;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }

        public void InsertElementAtFirst()
        {
            Console.WriteLine("Enter value to insert at position " + (0 + 1) + ": ");
            int value = Convert.ToInt32(Console.ReadLine());
            checkCapacityAndIncreaseSize();
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
            checkCapacityAndIncreaseSize();
            shiftRightAndInsert(value, pos);
            count++;
            Menu();
        }

        public void InsertElementAtLast()
        {
            Console.WriteLine("Enter value to insert at end: ");
            int value = Convert.ToInt32(Console.ReadLine());
            checkCapacityAndIncreaseSize();
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

        private void checkCapacityAndIncreaseSize()
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

        private void checkCapacityAndDecreaseSize()
        {
            int[] array = GetActiveArray();
            if (count == array.Length) return;

            int[] newArray = new int[count];
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

        public void DeleteFromEnd()
        {
            if (count != 0)
            {
                int[] array = GetActiveArray();
                array[count - 1] = 0; 
                count--;
            }
            Menu();
        }

        public void DeleteIfElementExists()
        {
            Console.WriteLine("Enter value to delete: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int[] array = GetActiveArray();
            int index = Array.IndexOf(array, value);
            if (shiftLeftAndDelete(index))
            {
                checkCapacityAndDecreaseSize();
            }
            Menu();
        }

        public Boolean shiftLeftAndDelete(int index)
        {
            int[] array = GetActiveArray();
            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[count - 1] = 0;
                count--;
                return true;
            }
            else
            {
                Console.WriteLine("The number doesnt exist.");
            }
            return false;
        }

        public void InsertElementAtMidpoint()
        {
            int[] array = GetActiveArray();
            int midpoint = count / 2;
            Console.WriteLine($"Enter element to insert at midpoint position {midpoint + 1}: ");
            int value = Convert.ToInt32(Console.ReadLine());
            checkCapacityAndIncreaseSize();
            shiftRightAndInsert(value, midpoint);
            count++;

            Menu();
        }

        public void DeleteFromStart()
        {
            if (count == 0)
            {
                Console.WriteLine("Array is empty. Nothing to delete.");
                Menu();
                return;
            }

            int[] array = GetActiveArray();
            shiftLeftAndDelete(0);
            checkCapacityAndDecreaseSize();

            Menu();
        }

        public void DeleteAtPosition()
        {
            if (count == 0)
            {
                Console.WriteLine("Array is empty. Nothing to delete.");
                Menu();
                return;
            }

            Console.WriteLine($"Enter the position to delete (1 to {count}): ");
            int pos = Convert.ToInt32(Console.ReadLine()) - 1;

            shiftLeftAndDelete(pos);
            checkCapacityAndDecreaseSize();
            Menu();
        }

        public void SearchForElement()
        {
            Console.WriteLine("Enter value to search: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int index = IndexOf(value);
            if (index != -1)
            {
                Console.WriteLine("Element found at index: " + index);
            }
            else
            {
                Console.WriteLine("Element not found in the array.");
            }
            Menu();
        }

        public int IndexOf(int value)
        {
            int[] array = GetActiveArray();
            for (int i = 0; i < count; i++)
                if (array[i] == value)
                    return i;
            return -1;
        }

        public void ClearArray()
        {
            int[] array = GetActiveArray();
            for (int i = 0; i < count; i++)
                array[i] = 0;
            count = 0;
            Menu();
        }
    }
}
