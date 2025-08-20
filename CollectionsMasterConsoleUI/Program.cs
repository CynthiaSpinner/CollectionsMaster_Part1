using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    /// <summary>
    /// Collections Master App - Learn C# Collections
    /// Complete TODOs to master 7 different collection types
    /// 
    /// FOCUS: ARRAYS AND LISTS
    /// 1. Array - Fixed-size indexed collection (you know this!)
    /// 2. List<T> - Dynamic resizable collection (you know this!)
    /// 3. Dictionary<TKey,TValue> - Stores key-value pairs for fast lookups (like a phone book)
    /// 
    /// CORE ARRAY METHODS TO RESEARCH:
    /// - Array.Copy() - Copy elements between arrays
    /// - Array.Clear() - Set elements to default values
    /// - Array.Sort() - Sort elements in ascending order
    /// - Array.Reverse() - Reverse element order
    /// - Array.Resize() - Change array size
    /// - Array.IndexOf() - Find element position
    /// - Array.Length - Get number of elements
    /// 
    /// CORE LIST METHODS TO RESEARCH:
    /// - Add() - Add element to end
    /// - Insert() - Add element at specific position
    /// - Remove() - Remove first matching element
    /// - RemoveAt() - Remove element at specific index
    /// - Contains() - Check if element exists
    /// - IndexOf() - Find element position
    /// - Sort() - Sort elements in ascending order
    /// - Reverse() - Reverse element order
    /// - Clear() - Remove all elements
    /// - ToArray() - Convert to array
    /// - Count - Get number of elements
    /// - Capacity - Get allocated storage space
    ///
    /// CORE DICTIONARY METHODS TO RESEARCH:
    /// - Add() - Add key-value pair
    /// - Remove() - Remove key-value pair
    /// - ContainsKey() - Check if key exists
    /// - ContainsValue() - Check if value exists
    /// - TryGetValue() - Safely get value
    /// - Clear() - Remove all pairs
    /// - Keys - Get all keys
    /// - Values - Get all values
    /// - Count - Get number of pairs
    ///
    /// WHERE TO RESEARCH:
    /// - Microsoft Docs: docs.microsoft.com/dotnet/api/system.collections.generic
    /// - C# Documentation: learn.microsoft.com/dotnet/csharp/
    /// - IntelliSense: Type the collection name and press Ctrl+Space for methods
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** COLLECTIONS MASTER APP ***");
            //Master Arrays & Lists, then explore advanced collections!
            //IMPORTANT: Implement logic in the method stubs at the bottom of this file!
           
            Console.WriteLine();

            #region Arrays
            Console.WriteLine("*** SECTION 1: ARRAYS ***");
            Console.WriteLine("=".PadRight(60, '='));

            Console.WriteLine("\n1. ARRAY CREATE:");
            // TODO 1: Call CreateArray() method and store result in a variable
            // Implement the CreateArray() method at bottom of file
            int[] numbers = CreateArray();
            
            Console.WriteLine("\n2. ARRAY POPULATE:");
            // TODO 2: Call PopulateArray(numbers) method
            // Implement the PopulateArray() method at bottom of file
            PopulateArray(numbers);
            
            // TODO 2b: Call NumberPrinter(numbers) to see the populated array
            NumberPrinter(numbers);
            
            
            Console.WriteLine("\n3. ARRAY ACCESS:");
            // TODO 3: Call AccessArrayElements(numbers) method
            // Implement the AccessArrayElements() method at bottom of file
            AccessArrayElements(numbers);

            Console.WriteLine("\n4. ARRAY SEARCH:");
            // TODO 4: Call SearchArray(numbers) method
            // Implement the SearchArray() method at bottom of file
            SearchArray(numbers);

            Console.WriteLine("\n5. ARRAY SORT:");
            // TODO 5: Call SortArray(numbers) method
            // Implement the SortArray() method at bottom of file
            SortArray(numbers);
            
            Console.WriteLine("\n6. ARRAY REVERSE:");
            // TODO 6: Call ReverseArray(numbers) method
            // Implement the ReverseArray() method at bottom of file
            ReverseArray(numbers);
            
            Console.WriteLine("\n7. ARRAY COPY:");
            // TODO 7: Call CopyArray(numbers) method
            // Implement the CopyArray() method at bottom of file
            int[] copiedArray = CopyArray(numbers);
            
            // TODO 7b: Call NumberPrinter(copiedArray) to see the copied array
            NumberPrinter(copiedArray);
            
            Console.WriteLine("\n8. ARRAY RESIZE:");
            // TODO 8: Call ResizeArray(numbers) method (make it bigger, add more numbers)
            // Implement the ResizeArray() method at bottom of file
            ResizeArray(numbers);
            
            Console.WriteLine("\n9. ARRAY CLEAR:");
            // TODO 9: Call ClearArray(numbers) method (sets all elements to 0)
            // Implement the ClearArray() method at bottom of file
            ClearArray(numbers);

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF ARRAYS SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Lists
            Console.WriteLine("*** SECTION 2: LISTS ***");
            Console.WriteLine("=".PadRight(60, '='));

            Console.WriteLine("\n1. LIST CREATE:");
            // TODO 10: Call CreateList() method and store result in a variable
            // Implement the CreateList() method at bottom of file
            List<int> numberList = CreateList();
            
            Console.WriteLine("\n2. LIST ADD:");
            // TODO 11: Call AddToList(numberList) method
            // Implement the AddToList() method at bottom of file
            AddToList(numberList);
            
            Console.WriteLine("\n3. LIST INSERT:");
            // TODO 12: Call InsertIntoList(numberList) method
            // Implement the InsertIntoList() method at bottom of file
            InsertIntoList(numberList);
            
            Console.WriteLine("\n4. LIST CONTAINS:");
            // TODO 13: Call CheckListContains(numberList) method
            // Implement the CheckListContains() method at bottom of file
            CheckListContains(numberList);
            
            Console.WriteLine("\n5. LIST INDEXOF:");
            // TODO 14: Call FindIndexInList(numberList) method
            // Implement the FindIndexInList() method at bottom of file
            FindIndexInList(numberList);
            
            Console.WriteLine("\n6. LIST REMOVE:");
            // TODO 15: Call RemoveFromList(numberList) method
            // Implement the RemoveFromList() method at bottom of file
            RemoveFromList(numberList);
            
            Console.WriteLine("\n7. LIST REMOVEAT:");
            // TODO 16: Call RemoveAtIndexFromList(numberList) method
            // Implement the RemoveAtIndexFromList() method at bottom of file
            RemoveAtIndexFromList(numberList);

            Console.WriteLine("\n8. LIST SORT:");
            // TODO 17: Call SortList(numberList) method
            // Implement the SortList() method at bottom of file
            SortList(numberList);

            Console.WriteLine("\n9. LIST REVERSE:");
            // TODO 18: Call ReverseList(numberList) method
            // Implement the ReverseList() method at bottom of file
            ReverseList(numberList);

            Console.WriteLine("\n10. LIST TOARRAY:");
            // TODO 19: Call ConvertListToArray(numberList) method
            // Implement the ConvertListToArray() method at bottom of file
            ConvertListToArray(numberList);

            Console.WriteLine("\n11. LIST CLEAR:");
            // TODO 20: Call ClearList(numberList) method
            // Implement the ClearList() method at bottom of file
            ClearList(numberList);

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF LISTS SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

           
            #region Dictionary
                       
            Console.WriteLine("*** SECTION 3: DICTIONARY ***");
            Console.WriteLine("=".PadRight(60, '='));
            //Key-value pairs for fast lookups (like a phone book)

            Console.WriteLine("\n1. DICTIONARY CREATE:");
            // TODO 13: Call CreateDictionary() method and store result in a variable
            // Implement the CreateDictionary() method at bottom of file
            Dictionary<string, int> grades = CreateDictionary();
            
            Console.WriteLine("\n2. DICTIONARY ADD:");
            // TODO 14: Call AddToDictionary(grades) method
            // Implement the AddToDictionary() method at bottom of file
            AddToDictionary(grades);
            
            Console.WriteLine("\n3. DICTIONARY LOOKUP:");
            // TODO 15: Call LookupInDictionary(grades) method
            // Implement the LookupInDictionary() method at bottom of file
            LookupInDictionary(grades);
            
            Console.WriteLine("\n4. DICTIONARY CONTAINSKEY:");
            // TODO 16: Call CheckDictionaryContainsKey(grades) method
            // Implement the CheckDictionaryContainsKey() method at bottom of file
            CheckDictionaryContainsKey(grades);

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF DICTIONARY SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion
      
            Console.WriteLine("🎉 COLLECTIONS MASTER COMPLETE! 🎉");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        



        // ============ ARRAY METHODS ============
        
        private static int[] CreateArray()
        {
            // STEP 1: Create an integer array of size 10
            // STEP 2: Console.WriteLine() to print a message that the array was created           
            // STEP 2: Return the array
            // Example: int[] myArray = new int[10];
            // Example: Console.WriteLine("Array Created!");
            // Example: return myArray;
            
            int[] myArray = new int[10];
            Console.WriteLine("Array Created!");
            return myArray; // Replace this line
        }

        private static void PopulateArray(int[] numbers)
        {
            // STEP 1: Create a Random object (already done for you)
            Random rng = new Random();
            
            // STEP 2: Create a for loop that goes from 0 to numbers.Length
            // STEP 3: Inside the loop, generate a random number between 1-100
            // STEP 4: Assign the random number to numbers[i]
            // Example: numbers[i] = rng.Next(1, 101);
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 101);
            }
            
            
        }

        private static void AccessArrayElements(int[] numbers)
        {
            // STEP 1: Print the first element using numbers[0]
            // STEP 2: Print the middle element using numbers[numbers.Length / 2]
            // STEP 3: Print the last element using numbers[numbers.Length - 1]
            // Example: Console.WriteLine($"First: {numbers[0]}");
            Console.WriteLine($"First: {numbers[0]}");
            Console.WriteLine($"Middle: {numbers[numbers.Length / 2]}");
            Console.WriteLine($"Last: {numbers[numbers.Length - 1]}");
        }

        private static void SearchArray(int[] numbers)
        {
            // STEP 1: Choose a number to search for (try 50)
            // STEP 2: Use Array.IndexOf(numbers, searchValue) to find it
            // STEP 3: Check if the result is -1 (not found) or >= 0 (found)
            // STEP 4: Print whether the number was found and at what index
            // Example: int index = Array.IndexOf(numbers, 50);
            int searchValue = 50;
            int index = Array.IndexOf(numbers, searchValue);
            if(index == -1)
            {
                Console.WriteLine($"Number {searchValue} not found");
            }
            else
            {
                Console.WriteLine($"Number {searchValue} found at index {index}");
            }
        }

        private static void SortArray(int[] numbers)
        {
            // STEP 1: Use Array.Sort(numbers) to sort the array
            // STEP 2: Print the sorted array using NumberPrinter(numbers)
            // Example: Array.Sort(numbers);
            // Example: NumberPrinter(numbers);
            Array.Sort(numbers);
            NumberPrinter(numbers);
        }

        private static void ReverseArray(int[] numbers)
        {
            // STEP 1: Use Array.Reverse(numbers) to reverse the array
            // STEP 2: Print the reversed array using NumberPrinter(numbers)
            // Example: Array.Reverse(numbers);
            // Example: NumberPrinter(numbers);
            Array.Reverse(numbers);
            NumberPrinter(numbers);
        }

        private static int[] CopyArray(int[] numbers)
        {
            // STEP 1: Create a new array of the same size
            // STEP 2: Use Array.Copy() to copy elements from original to new array
            // STEP 3: Print both arrays to show they're identical
            // Example: int[] copy = new int[numbers.Length];
            // Example: Array.Copy(numbers, copy, numbers.Length);
            int[] copy = new int[numbers.Length];
            Array.Copy(numbers, copy, numbers.Length);
            return copy; // Replace with your copied array
        }

        private static void ClearArray(int[] numbers)
        {
            // STEP 1: Use Array.Clear() to set all elements to 0
            // STEP 2: Print the array to show it's cleared
            // Example: Array.Clear(numbers, 0, numbers.Length);
            // Example: NumberPrinter(numbers);
            Array.Clear(numbers, 0, numbers.Length);
            NumberPrinter(numbers);            
        }

        private static int[] ResizeArray(int[] numbers)
        {
            // STEP 1: Use Array.Resize() to make the array larger (try size 15)
            // STEP 2: Fill the new positions with more random numbers
            // STEP 3: Print the resized array to see the new elements
            // Example: Array.Resize(ref numbers, 15);
            // Example: Random rng = new Random();
            // Example: for (int i = 10; i < numbers.Length; i++) numbers[i] = rng.Next(1, 101);
            // Example: NumberPrinter(numbers);
            Array.Resize(ref numbers, 15);
            Random rng = new Random();
            for(int i = 10; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 101);
            }
            NumberPrinter(numbers);
            return numbers;
        }

        // ============ LIST METHODS ============

        private static List<int> CreateList()
        {
            // STEP 1: Create an empty List of integers
            // STEP 2: Return the list
            // Example: List<int> myList = new List<int>();
            // Example: return myList;
            List<int> myList = new List<int>();

            return myList; // Replace this line
        }

        private static void AddToList(List<int> numberList)
        {
            // STEP 1: Add the numbers 5, 15, 25, 35, 45 to the list
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.Add(5);
            // Example: numberList.Add(15);
            // Continue for all numbers...
            // Example: NumberPrinter(numberList);
            numberList.Add(5);
            numberList.Add(15);
            numberList.Add(25);
            numberList.Add(35);
            numberList.Add(45);
            NumberPrinter(numberList);
            
        }

        private static void InsertIntoList(List<int> numberList)
        {
            // STEP 1: Insert the number 99 at position 2 (third position)
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.Insert(2, 99);
            // Example: NumberPrinter(numberList);
            numberList.Insert(2, 99);
            NumberPrinter(numberList);
            
        }

        private static void CheckListContains(List<int> numberList)
        {
            // STEP 1: Check if the number 25 exists in the list
            // STEP 2: Print a message saying if it was found or not
            // Example: bool found = numberList.Contains(25);
            // Example: Console.WriteLine($"Number 25 found: {found}");
            bool found = numberList.Contains(25);
            Console.WriteLine($"Number 25 found: {found}");
        }

        private static void RemoveFromList(List<int> numberList)
        {
            // STEP 1: Remove the number 15 from the list
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.Remove(15);
            // Example: NumberPrinter(numberList);
            numberList.Remove(15);
            NumberPrinter(numberList);                       
        }

        private static void FindIndexInList(List<int> numberList)
        {
            // STEP 1: Use IndexOf to find the position of a specific number (try 25)
            // STEP 2: Print the index (or -1 if not found)
            // Example: int index = numberList.IndexOf(25);
            // Example: Console.WriteLine($"Index of 25: {index}");
            int index = numberList.IndexOf(25);
            Console.WriteLine($"Index of 25: {index}");            
        }

        private static void RemoveAtIndexFromList(List<int> numberList)
        {
            // STEP 1: Remove the item at a specific index (try index 1)
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.RemoveAt(1);
            // Example: NumberPrinter(numberList);
            numberList.RemoveAt(1);
            NumberPrinter(numberList);            
        }

        private static void SortList(List<int> numberList)
        {
            // STEP 1: Use Sort() to sort the list in ascending order
            // STEP 2: Print the sorted list using NumberPrinter(numberList)
            // Example: numberList.Sort();
            // Example: NumberPrinter(numberList);
            numberList.Sort();
            NumberPrinter(numberList);            
        }

        private static void ReverseList(List<int> numberList)
        {
            // STEP 1: Use Reverse() to reverse the list order
            // STEP 2: Print the reversed list using NumberPrinter(numberList)
            // Example: numberList.Reverse();
            // Example: NumberPrinter(numberList);
            numberList.Reverse();
            NumberPrinter(numberList);            
        }

        private static int[] ConvertListToArray(List<int> numberList)
        {
            // STEP 1: Use ToArray() to convert the list to an array
            // STEP 2: Print both the list and array to show they're the same
            // Example: int[] array = numberList.ToArray();
            // Example: Console.WriteLine("List:"); NumberPrinter(numberList);
            // Example: Console.WriteLine("Array:"); NumberPrinter(array);
            int[] array = numberList.ToArray();
            Console.WriteLine("List:");
            NumberPrinter(numberList);
            Console.WriteLine("Array:");
            NumberPrinter(array);
            return array; // Replace with your array
        }

        private static void ClearList(List<int> numberList)
        {
            // STEP 1: Clear all items from the list
            // STEP 2: Print the count to show it's empty
            // Example: numberList.Clear();
            // Example: Console.WriteLine($"List count after clear: {numberList.Count}");
            numberList.Clear();
            Console.WriteLine($"List count after clear: {numberList.Count}");
        }

        // ============ DICTIONARY METHODS ============

        private static Dictionary<string, int> CreateDictionary()
        {
            // TODO: Create a Dictionary with string keys and int values
            // Example: Dictionary<string, int> grades = new Dictionary<string, int>();
            // Then return grades;
            Dictionary<string, int> grades = new Dictionary<string, int>();

            
            return grades;
        }

        private static void AddToDictionary(Dictionary<string, int> grades)
        {
            // TODO: Add Alice with grade 95 and Bob with grade 87
            // Example: grades.Add("Alice", 95);
            
            grades["Charlie"] = 92; // Alternative syntax (this one is done for you)
            grades.Add("Alice", 95);
            grades.Add("Bob", 87);
            
            Console.WriteLine("Student Grades:");
            // TODO: Print all key-value pairs using a foreach loop
            // Example: foreach (var student in grades)
            foreach (var student in grades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
            
            
        }

        private static void LookupInDictionary(Dictionary<string, int> grades)
        {
            string studentName = "Alice";
            // TODO: Get Alice's grade from the dictionary
            // Example: int grade = grades[studentName];
            int grade = grades[studentName];
            // TODO: Print the result
            // Example: Console.WriteLine($"{studentName}'s grade: {grade}");
            Console.WriteLine($"{studentName}'s grade: {grade}");
        }

        private static void CheckDictionaryContainsKey(Dictionary<string, int> grades)
        {
            string studentName = "David";
            
            // TODO: Check if the key exists using ContainsKey, then print appropriate message
            // Example: if (grades.ContainsKey(studentName))
            if (grades.ContainsKey(studentName))
            {
                Console.WriteLine($"{studentName} is in the dictionary");                
            } 
            else {
                Console.WriteLine($"{studentName} is not in the dictionary");
            }
            
        }



        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
