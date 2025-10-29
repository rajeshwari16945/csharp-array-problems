using System;

namespace CSharp.Arrays
{
    public class DictionaryImplementationWithArrays
    {
        private object[] keysArray;
        private object[] valuesArray;
        private int count = 0;

        public DictionaryImplementationWithArrays()
        {
            keysArray = new object[2];
            valuesArray = new object[2];
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Key-Value Pair");
                Console.WriteLine("2. Update Value for Key");
                Console.WriteLine("3. Delete Key");
                Console.WriteLine("4. Print All");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        PrintAll();
                        break;
                    case 5:
                        Console.WriteLine("Exit from the program");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        public void Add()
        {
            Console.Write("Enter key to add: ");
            string key = Console.ReadLine();

            if (string.IsNullOrEmpty(key))
            {
                Console.WriteLine("Key cannot be empty.");
                return;
            }

            int idx = GetIndex(key);
            if (idx != -1)
            {
                Console.WriteLine($"Key '{key}' already exists with value '{valuesArray[idx]}'.");
                Console.Write("Do you want to update the value instead? (y/n): ");
                string ans = Console.ReadLine();
                if (!string.IsNullOrEmpty(ans) && ans.Trim().ToLower().StartsWith("y"))
                {
                    Console.Write("Enter new value: ");
                    valuesArray[idx] = Console.ReadLine();
                    Console.WriteLine($"Key '{key}' updated successfully.");
                }
                else
                {
                    Console.WriteLine("Add cancelled.");
                }
                return;
            }

            if (count == keysArray.Length)
            {
                ResizeArrays();
            }

            Console.Write("Enter value to add: ");
            string value = Console.ReadLine();

            keysArray[count] = key;
            valuesArray[count] = value;
            count++;

            Console.WriteLine($"Key '{key}' added successfully.");
        }

        public void Update()
        {
            Console.Write("Enter key to update: ");
            string key = Console.ReadLine();

            if (string.IsNullOrEmpty(key))
            {
                Console.WriteLine("Key cannot be empty.");
                return;
            }

            int idx = GetIndex(key);
            if (idx == -1)
            {
                Console.WriteLine($"Key '{key}' not found.");
                return;
            }

            Console.WriteLine($"Current value: '{valuesArray[idx]}'");
            Console.Write("Enter new value: ");
            valuesArray[idx] = Console.ReadLine();
            Console.WriteLine($"Key '{key}' updated successfully.");
        }

        public void Delete()
        {
            Console.Write("Enter key to delete: ");
            string keyToDelete = Console.ReadLine();

            if (string.IsNullOrEmpty(keyToDelete))
            {
                Console.WriteLine("Key cannot be empty.");
                return;
            }

            int index = GetIndex(keyToDelete);

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

        private int GetIndex(string key)
        {
            for (int i = 0; i < count; i++)
            {
                if (keysArray[i] != null && keysArray[i].ToString().Equals(key, StringComparison.Ordinal))
                {
                    return i;
                }
            }
            return -1;
        }

        private void ResizeArrays()
        {
            int newSize = keysArray.Length * 2;
            object[] newKeysArray = new object[newSize];
            object[] newValuesArray = new object[newSize];
            for (int i = 0; i < keysArray.Length; i++)
            {
                newKeysArray[i] = keysArray[i];
                newValuesArray[i] = valuesArray[i];
            }
            keysArray = newKeysArray;
            valuesArray = newValuesArray;
        }

        private void PrintAll()
        {
            if (count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
                return;
            }

            Console.WriteLine("Current key-value pairs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"[{i}] Key: '{keysArray[i]}' => Value: '{valuesArray[i]}'");
            }
        }
    }
}
