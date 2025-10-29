using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class DictionaryImplementationWithArrays
    {
        Object[] keysArray;
        Object[] valuesArray;

        int count = 0;

        public DictionaryImplementationWithArrays() 
        { 
            keysArray= new Object[2];   
            valuesArray= new Object[2];
        }

        public void menu()
        {
            Console.WriteLine("Enter any: 1. Add Key-Value Pair 2. Delete Key 3. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Add();
                    menu();
                    break;
                case 2:
                    Delete();
                    menu();
                    break;
                case 3:
                    Console.WriteLine("Exit from the program");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    menu();
                    break;
            }
        }

        public void Add()
        {
            if (count == keysArray.Length)
            {
                ResizeArrays();
            }
            Console.WriteLine("Enter key to add: ");
            keysArray[count] = Console.ReadLine();
            Console.WriteLine("Enter value to add: ");
            valuesArray[count] = Console.ReadLine();
            count++;
        }

        public void ResizeArrays()
        {
            int newSize = keysArray.Length * 2;
            Object[] newKeysArray = new Object[newSize];
            Object[] newValuesArray = new Object[newSize];
            for (int i = 0; i < keysArray.Length; i++)
            {
                newKeysArray[i] = keysArray[i];
                newValuesArray[i] = valuesArray[i];
            }
            keysArray = newKeysArray;
            valuesArray = newValuesArray;
        }

        public void Delete()
        {
            Console.WriteLine("Enter key to delete: ");
            string keyToDelete = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (keysArray[i].ToString() == keyToDelete)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Key not found!");
                return;
            }

            // Shift elements to remove the key-value pair
            for (int i = index; i < count - 1; i++)
            {
                keysArray[i] = keysArray[i + 1];
                valuesArray[i] = valuesArray[i + 1];
            }

            keysArray[count - 1] = null;
            valuesArray[count - 1] = null;
            count--;

            Console.WriteLine($"Key '{keyToDelete}' deleted successfully.");
        }
    }
}
