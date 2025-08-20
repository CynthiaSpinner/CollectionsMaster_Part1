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
    /// ADVANCED COLLECTIONS (Learn how to Learn section):
    /// 
    /// • Dictionary<TKey,TValue> - Stores key-value pairs for fast lookups (like a phone book)
    ///   Use when: You need to quickly find values using unique keys
    ///   Example: Student names → grades, Product IDs → prices
    /// 
    /// • HashSet<T> - Stores unique items only, automatically prevents duplicates
    ///   Use when: You need a collection with no duplicate values
    ///   Example: Unique usernames, visited website pages, lottery numbers
    /// 
    /// • Stack<T> - Last-In-First-Out (LIFO) like a stack of plates
    ///   Use when: You need to process items in reverse order
    ///   Example: Undo operations, browser back button, function call stack
    /// 
    /// • Queue<T> - First-In-First-Out (FIFO) like a line at a store
    ///   Use when: You need to process items in the order they arrived
    ///   Example: Print queue, customer service line, task scheduling
    /// 
    /// • SortedList<TKey,TValue> - Key-value pairs kept automatically sorted by key
    ///   Use when: You need Dictionary functionality but want items sorted
    ///   Example: Leaderboard (score → player), timeline (date → event)
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
            
            Console.WriteLine("\n2. ARRAY POPULATE:");
            // TODO 2: Call PopulateArray(numbers) method
            // Implement the PopulateArray() method at bottom of file
            
            Console.WriteLine("\n3. ARRAY ACCESS:");
            // TODO 3: Call AccessArrayElements(numbers) method
            // Implement the AccessArrayElements() method at bottom of file
            
            Console.WriteLine("\n4. ARRAY SEARCH:");
            // TODO 4: Call SearchArray(numbers) method
            // Implement the SearchArray() method at bottom of file
            
            Console.WriteLine("\n5. ARRAY SORT:");
            // TODO 5: Call SortArray(numbers) method
            // Implement the SortArray() method at bottom of file
            
            Console.WriteLine("\n6. ARRAY REVERSE:");
            // TODO 6: Call ReverseArray(numbers) method
            // Implement the ReverseArray() method at bottom of file
            
            Console.WriteLine("\n7. ARRAY COPY:");
            // TODO 7: Call CopyArray(numbers) method
            // Implement the CopyArray() method at bottom of file
            
            Console.WriteLine("\n8. ARRAY CLEAR:");
            // TODO 8: Call ClearArray(numbers) method
            // Implement the ClearArray() method at bottom of file
            
            Console.WriteLine("\n9. ARRAY RESIZE:");
            // TODO 9: Call ResizeArray(numbers) method
            // Implement the ResizeArray() method at bottom of file

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
            
            Console.WriteLine("\n2. LIST ADD:");
            // TODO 11: Call AddToList(numberList) method
            // Implement the AddToList() method at bottom of file
            
            Console.WriteLine("\n3. LIST INSERT:");
            // TODO 12: Call InsertIntoList(numberList) method
            // Implement the InsertIntoList() method at bottom of file
            
            Console.WriteLine("\n4. LIST CONTAINS:");
            // TODO 13: Call CheckListContains(numberList) method
            // Implement the CheckListContains() method at bottom of file
            
            Console.WriteLine("\n5. LIST INDEXOF:");
            // TODO 14: Call FindIndexInList(numberList) method
            // Implement the FindIndexInList() method at bottom of file
            
            Console.WriteLine("\n6. LIST REMOVE:");
            // TODO 15: Call RemoveFromList(numberList) method
            // Implement the RemoveFromList() method at bottom of file
            
            Console.WriteLine("\n7. LIST REMOVEAT:");
            // TODO 16: Call RemoveAtIndexFromList(numberList) method
            // Implement the RemoveAtIndexFromList() method at bottom of file
            
            Console.WriteLine("\n8. LIST SORT:");
            // TODO 17: Call SortList(numberList) method
            // Implement the SortList() method at bottom of file
            
            Console.WriteLine("\n9. LIST REVERSE:");
            // TODO 18: Call ReverseList(numberList) method
            // Implement the ReverseList() method at bottom of file
            
            Console.WriteLine("\n10. LIST TOARRAY:");
            // TODO 19: Call ConvertListToArray(numberList) method
            // Implement the ConvertListToArray() method at bottom of file
            
            Console.WriteLine("\n11. LIST CLEAR:");
            // TODO 20: Call ClearList(numberList) method
            // Implement the ClearList() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF LISTS SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            //Learn More Section
            //These are bonus collections to explore after mastering Arrays & Lists!
            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** ADVANCED COLLECTIONS ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");

            #region Dictionary
            // DICTIONARY<TKey,TValue> CORE METHODS FOR REFERENCE:
            // • Add(key, value) - Add key-value pair
            // • [key] = value - Set or get value by key
            // • ContainsKey(key) - Check if key exists
            // • ContainsValue(value) - Check if value exists
            // • Remove(key) - Remove key-value pair
            // • TryGetValue(key, out value) - Safely get value
            // • Clear() - Remove all pairs
            // • Keys - Get all keys
            // • Values - Get all values
            // • Count - Get number of pairs
            
            Console.WriteLine("*** DICTIONARY ***");
            Console.WriteLine("=".PadRight(60, '='));
            //Key-value pairs for fast lookups (like a phone book)

            Console.WriteLine("\n1. DICTIONARY CREATE:");
            // TODO 13: Call CreateDictionary() method and store result in a variable
            // Implement the CreateDictionary() method at bottom of file
            
            Console.WriteLine("\n2. DICTIONARY ADD:");
            // TODO 14: Call AddToDictionary(grades) method
            // Implement the AddToDictionary() method at bottom of file
            
            Console.WriteLine("\n3. DICTIONARY LOOKUP:");
            // TODO 15: Call LookupInDictionary(grades) method
            // Implement the LookupInDictionary() method at bottom of file
            
            Console.WriteLine("\n4. DICTIONARY CONTAINSKEY:");
            // TODO 16: Call CheckDictionaryContainsKey(grades) method
            // Implement the CheckDictionaryContainsKey() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF DICTIONARY SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region HashSet
            // HASHSET<T> CORE METHODS FOR REFERENCE:
            // • Add(item) - Add unique item
            // • Contains(item) - Check if item exists
            // • Remove(item) - Remove specific item
            // • UnionWith(other) - Add items from another collection
            // • IntersectWith(other) - Keep only common items
            // • ExceptWith(other) - Remove items that exist in other
            // • Clear() - Remove all items
            // • Count - Get number of unique items
            
            Console.WriteLine("*** HASHSET ***");
            Console.WriteLine("=".PadRight(60, '='));
            //Stores unique items only, automatically prevents duplicates

            Console.WriteLine("\n1. HASHSET CREATE:");
            // TODO 17: Call CreateHashSet() method and store result in a variable
            // Implement the CreateHashSet() method at bottom of file
            
            Console.WriteLine("\n2. HASHSET ADD:");
            // TODO 18: Call AddToHashSet(uniqueNames) method
            // Implement the AddToHashSet() method at bottom of file
            
            Console.WriteLine("\n3. HASHSET COUNT & CONTAINS:");
            // TODO 19: Call CheckHashSetCount(uniqueNames) method
            // Implement the CheckHashSetCount() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF HASHSET SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Stack
            // STACK<T> CORE METHODS FOR REFERENCE:
            // • Push(item) - Add item to top
            // • Pop() - Remove and return top item
            // • Peek() - Look at top item without removing
            // • Contains(item) - Check if item exists
            // • Clear() - Remove all items
            // • Count - Get number of items
            
            Console.WriteLine("*** STACK ***");
            Console.WriteLine("=".PadRight(60, '='));
            //Last-In-First-Out (LIFO) like a stack of plates

            Console.WriteLine("\n1. STACK CREATE:");
            // TODO 20: Call CreateStack() method and store result in a variable
            // Implement the CreateStack() method at bottom of file
            
            Console.WriteLine("\n2. STACK PUSH:");
            // TODO 21: Call PushToStack(stack) method
            // Implement the PushToStack() method at bottom of file
            
            Console.WriteLine("\n3. STACK POP:");
            // TODO 22: Call PopFromStack(stack) method
            // Implement the PopFromStack() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF STACK SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region Queue
            // QUEUE<T> CORE METHODS FOR REFERENCE:
            // • Enqueue(item) - Add item to back
            // • Dequeue() - Remove and return front item
            // • Peek() - Look at front item without removing
            // • Contains(item) - Check if item exists
            // • Clear() - Remove all items
            // • Count - Get number of items
            
            Console.WriteLine("*** QUEUE ***");
            Console.WriteLine("=".PadRight(60, '='));
            //First-In-First-Out (FIFO) like a line at a store

            Console.WriteLine("\n1. QUEUE CREATE:");
            // TODO 23: Call CreateQueue() method and store result in a variable
            // Implement the CreateQueue() method at bottom of file
            
            Console.WriteLine("\n2. QUEUE ENQUEUE:");
            // TODO 24: Call EnqueueToQueue(queue) method
            // Implement the EnqueueToQueue() method at bottom of file
            
            Console.WriteLine("\n3. QUEUE DEQUEUE:");
            // TODO 25: Call DequeueFromQueue(queue) method
            // Implement the DequeueFromQueue() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF QUEUE SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            #region SortedList
            // SORTEDLIST<TKey,TValue> CORE METHODS FOR REFERENCE:
            // • Add(key, value) - Add key-value pair (auto-sorted)
            // • [key] = value - Set or get value by key
            // • ContainsKey(key) - Check if key exists
            // • ContainsValue(value) - Check if value exists
            // • Remove(key) - Remove key-value pair
            // • IndexOfKey(key) - Get position of key
            // • IndexOfValue(value) - Get position of value
            // • RemoveAt(index) - Remove by position
            // • Keys - Get all keys (sorted)
            // • Values - Get all values (by key order)
            // • Count - Get number of pairs
            
            Console.WriteLine("*** SORTEDLIST ***");
            Console.WriteLine("=".PadRight(60, '='));
            //Key-value pairs kept automatically sorted by key

            Console.WriteLine("\n1. SORTEDLIST CREATE:");
            // TODO 26: Call CreateSortedList() method and store result in a variable
            // Implement the CreateSortedList() method at bottom of file
            
            Console.WriteLine("\n2. SORTEDLIST ADD:");
            // TODO 27: Call AddToSortedList(sorted) method
            // Implement the AddToSortedList() method at bottom of file
            
            Console.WriteLine("\n3. SORTEDLIST DISPLAY:");
            // TODO 28: Call DisplaySortedList(sorted) method
            // Implement the DisplaySortedList() method at bottom of file

            Console.WriteLine("\n" + "=".PadRight(60, '='));
            Console.WriteLine("*** END OF SORTEDLIST SECTION ***");
            Console.WriteLine("=".PadRight(60, '=') + "\n");
            #endregion

            Console.WriteLine("🎉 COLLECTIONS MASTER COMPLETE! 🎉");
            Console.ReadKey();
            #endregion
        }

        // ============ ARRAY METHODS ============
        
        private static int[] CreateArray()
        {
            // STEP 1: Create an integer array of size 10
            // STEP 2: Return the array
            // Example: int[] myArray = new int[10];
            // Example: return myArray;
            
            return null; // Replace this line
        }

        private static void PopulateArray(int[] numbers)
        {
            // STEP 1: Create a Random object (already done for you)
            Random rng = new Random();
            
            // STEP 2: Create a for loop that goes from 0 to numbers.Length
            // STEP 3: Inside the loop, generate a random number between 1-100
            // STEP 4: Assign the random number to numbers[i]
            // Example: numbers[i] = rng.Next(1, 101);
            
        }

        private static void AccessArrayElements(int[] numbers)
        {
            // STEP 1: Print the first element using numbers[0]
            // STEP 2: Print the middle element using numbers[numbers.Length / 2]
            // STEP 3: Print the last element using numbers[numbers.Length - 1]
            // Example: Console.WriteLine($"First: {numbers[0]}");
            
        }

        private static void SearchArray(int[] numbers)
        {
            // STEP 1: Choose a number to search for (try 50)
            // STEP 2: Use Array.IndexOf(numbers, searchValue) to find it
            // STEP 3: Check if the result is -1 (not found) or >= 0 (found)
            // STEP 4: Print whether the number was found and at what index
            // Example: int index = Array.IndexOf(numbers, 50);
            
        }

        private static void SortArray(int[] numbers)
        {
            // STEP 1: Use Array.Sort(numbers) to sort the array
            // STEP 2: Print the sorted array using NumberPrinter(numbers)
            // Example: Array.Sort(numbers);
            // Example: NumberPrinter(numbers);
            
        }

        private static void ReverseArray(int[] numbers)
        {
            // STEP 1: Use Array.Reverse(numbers) to reverse the array
            // STEP 2: Print the reversed array using NumberPrinter(numbers)
            // Example: Array.Reverse(numbers);
            // Example: NumberPrinter(numbers);
            
        }

        private static int[] CopyArray(int[] numbers)
        {
            // STEP 1: Create a new array of the same size
            // STEP 2: Use Array.Copy() to copy elements from original to new array
            // STEP 3: Print both arrays to show they're identical
            // Example: int[] copy = new int[numbers.Length];
            // Example: Array.Copy(numbers, copy, numbers.Length);
            
            return null; // Replace with your copied array
        }

        private static void ClearArray(int[] numbers)
        {
            // STEP 1: Use Array.Clear() to set all elements to 0
            // STEP 2: Print the array to show it's cleared
            // Example: Array.Clear(numbers, 0, numbers.Length);
            // Example: NumberPrinter(numbers);
            
        }

        private static int[] ResizeArray(int[] numbers)
        {
            // STEP 1: Use Array.Resize() to make the array larger (try size 15)
            // STEP 2: Print the resized array
            // Example: Array.Resize(ref numbers, 15);
            // Example: NumberPrinter(numbers);
            
            return numbers;
        }

        // ============ LIST METHODS ============

        private static List<int> CreateList()
        {
            // STEP 1: Create an empty List of integers
            // STEP 2: Return the list
            // Example: List<int> myList = new List<int>();
            // Example: return myList;
            
            return null; // Replace this line
        }

        private static void AddToList(List<int> numberList)
        {
            // STEP 1: Add the numbers 5, 15, 25, 35, 45 to the list
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.Add(5);
            // Example: numberList.Add(15);
            // Continue for all numbers...
            // Example: NumberPrinter(numberList);
            
        }

        private static void InsertIntoList(List<int> numberList)
        {
            // STEP 1: Insert the number 99 at position 2 (third position)
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.Insert(2, 99);
            // Example: NumberPrinter(numberList);
            
        }

        private static void CheckListContains(List<int> numberList)
        {
            // STEP 1: Check if the number 25 exists in the list
            // STEP 2: Print a message saying if it was found or not
            // Example: bool found = numberList.Contains(25);
            // Example: Console.WriteLine($"Number 25 found: {found}");
            
        }

        private static void RemoveFromList(List<int> numberList)
        {
            // STEP 1: Remove the number 15 from the list
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.Remove(15);
            // Example: NumberPrinter(numberList);
            
        }

        private static void FindIndexInList(List<int> numberList)
        {
            // STEP 1: Use IndexOf to find the position of a specific number (try 25)
            // STEP 2: Print the index (or -1 if not found)
            // Example: int index = numberList.IndexOf(25);
            // Example: Console.WriteLine($"Index of 25: {index}");
            
        }

        private static void RemoveAtIndexFromList(List<int> numberList)
        {
            // STEP 1: Remove the item at a specific index (try index 1)
            // STEP 2: Print the list using NumberPrinter(numberList)
            // Example: numberList.RemoveAt(1);
            // Example: NumberPrinter(numberList);
            
        }

        private static void SortList(List<int> numberList)
        {
            // STEP 1: Use Sort() to sort the list in ascending order
            // STEP 2: Print the sorted list using NumberPrinter(numberList)
            // Example: numberList.Sort();
            // Example: NumberPrinter(numberList);
            
        }

        private static void ReverseList(List<int> numberList)
        {
            // STEP 1: Use Reverse() to reverse the list order
            // STEP 2: Print the reversed list using NumberPrinter(numberList)
            // Example: numberList.Reverse();
            // Example: NumberPrinter(numberList);
            
        }

        private static int[] ConvertListToArray(List<int> numberList)
        {
            // STEP 1: Use ToArray() to convert the list to an array
            // STEP 2: Print both the list and array to show they're the same
            // Example: int[] array = numberList.ToArray();
            // Example: Console.WriteLine("List:"); NumberPrinter(numberList);
            // Example: Console.WriteLine("Array:"); NumberPrinter(array);
            
            return null; // Replace with your array
        }

        private static void ClearList(List<int> numberList)
        {
            // STEP 1: Clear all items from the list
            // STEP 2: Print the count to show it's empty
            // Example: numberList.Clear();
            // Example: Console.WriteLine($"List count after clear: {numberList.Count}");
            
        }

        // ============ DICTIONARY METHODS ============

        private static Dictionary<string, int> CreateDictionary()
        {
            // TODO: Create a Dictionary with string keys and int values
            // Example: Dictionary<string, int> grades = new Dictionary<string, int>();
            // Then return grades;
            
            return null;
        }

        private static void AddToDictionary(Dictionary<string, int> grades)
        {
            // TODO: Add Alice with grade 95 and Bob with grade 87
            // Example: grades.Add("Alice", 95);
            
            grades["Charlie"] = 92; // Alternative syntax (this one is done for you)
            
            // TODO: Print all key-value pairs using a foreach loop
            // Example: foreach (var student in grades)
            
            Console.WriteLine("Student Grades:");
        }

        private static void LookupInDictionary(Dictionary<string, int> grades)
        {
            string studentName = "Alice";
            // TODO: Get Alice's grade from the dictionary
            // Example: int grade = grades[studentName];
            
            // TODO: Print the result
            // Example: Console.WriteLine($"{studentName}'s grade: {grade}");
            
        }

        private static void CheckDictionaryContainsKey(Dictionary<string, int> grades)
        {
            string studentName = "David";
            
            // TODO: Check if the key exists using ContainsKey, then print appropriate message
            // Example: if (grades.ContainsKey(studentName))
            
        }

        // ============ HASHSET METHODS ============

        private static HashSet<string> CreateHashSet()
        {
            // TODO: Create a HashSet of strings (automatically prevents duplicates)
            // Example: HashSet<string> uniqueNames = new HashSet<string>();
            // Then return uniqueNames;
            
            return null;
        }

        private static void AddToHashSet(HashSet<string> uniqueNames)
        {
            // TODO: Add "John", "Jane", and "John" again (watch the duplicate get ignored!)
            // Example: uniqueNames.Add("John");
            
            // TODO: Print all unique names using a foreach loop
            // Example: foreach (string name in uniqueNames)
            
            Console.WriteLine("Unique names in HashSet:");
        }

        private static void CheckHashSetCount(HashSet<string> uniqueNames)
        {
            // TODO: Print the count of unique names
            // Example: Console.WriteLine($"Total unique names: {uniqueNames.Count}");
            
            // TODO: Check if specific names exist using Contains
            // Example: Console.WriteLine($"Contains John: {uniqueNames.Contains(\"John\")}");
            
        }

        // ============ STACK METHODS ============

        private static Stack<int> CreateStack()
        {
            // TODO: Create a Stack of integers (Last In, First Out - like a stack of plates)
            // Example: Stack<int> stack = new Stack<int>();
            // Then return stack;
            
            return null;
        }

        private static void PushToStack(Stack<int> stack)
        {
            // TODO: Push the numbers 10, 20, 30 onto the stack
            // Example: stack.Push(10);
            
            Console.WriteLine("Pushed 10, 20, 30 onto stack");
            Console.WriteLine($"Stack count: {stack.Count}");
        }

        private static void PopFromStack(Stack<int> stack)
        {
            Console.WriteLine("Popping from stack (LIFO order):");
            
            // TODO: Pop all items while the stack has items (they come out in reverse order!)
            // Example: while (stack.Count > 0)
            // Example: int item = stack.Pop();
            
        }

        // ============ QUEUE METHODS ============

        private static Queue<string> CreateQueue()
        {
            // TODO: Create a Queue of strings (First In, First Out - like a line at a store)
            // Example: Queue<string> queue = new Queue<string>();
            // Then return queue;
            
            return null;
        }

        private static void EnqueueToQueue(Queue<string> queue)
        {
            // TODO: Add "First", "Second", "Third" to the queue
            // Example: queue.Enqueue("First");
            
            Console.WriteLine("Enqueued: First, Second, Third");
            Console.WriteLine($"Queue count: {queue.Count}");
        }

        private static void DequeueFromQueue(Queue<string> queue)
        {
            Console.WriteLine("Dequeuing from queue (FIFO order):");
            
            // TODO: Remove all items while the queue has items (they come out in same order!)
            // Example: while (queue.Count > 0)
            // Example: string item = queue.Dequeue();
            
        }

        // ============ SORTEDLIST METHODS ============

        private static SortedList<int, string> CreateSortedList()
        {
            // TODO: Create a SortedList with int keys and string values (automatically sorted by key)
            // Example: SortedList<int, string> sorted = new SortedList<int, string>();
            // Then return sorted;
            
            return null;
        }

        private static void AddToSortedList(SortedList<int, string> sorted)
        {
            // TODO: Add key-value pairs out of order - watch them get sorted automatically!
            // Example: sorted.Add(3, "Third");
            
            Console.WriteLine("Added items out of order: 3=Third, 1=First, 2=Second");
        }

        private static void DisplaySortedList(SortedList<int, string> sorted)
        {
            Console.WriteLine("SortedList contents (automatically sorted by key):");
            
            // TODO: Loop through and print each key-value pair
            // Example: foreach (var item in sorted)
            
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
