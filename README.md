# Collections Master App - Student Exercise

## Overview
This exercise helps you master C# collections through hands-on practice with Arrays, Lists, and Dictionaries.

## Structure

### **Main Focus: Arrays, Lists & Dictionaries**
Practice core collection operations with essential C# collections:
- **Arrays** (9 operations): Create, Populate, Access, Search, Sort, Reverse, Copy, Clear, Resize
- **Lists** (11 operations): Create, Add, Insert, Contains, IndexOf, Remove, RemoveAt, Sort, Reverse, ToArray, Clear
- **Dictionaries** (4 operations): Create, Add, Lookup, ContainsKey

## How to Complete This Exercise

### **Step 1: Implement Method Logic**
Scroll down to the METHOD STUBS section and implement each method:
```csharp
private static int[] CreateArray()
{
    // TODO: Create an integer array of size 10
    // TODO: Console.WriteLine() to print a message that the array was created
    // TODO: Return the array
    // Example: int[] myArray = new int[10];
    // Example: Console.WriteLine("Array Created!");
    // Example: return myArray;
    
    return null; // Replace this null with your array
}
```

### **Step 2: Call Your Methods**
Go back to the Main method and uncomment the TODO lines:
```csharp
Console.WriteLine("\n1. ARRAY CREATE:");
// TODO: Call CreateArray() method and store result in a variable
// Implement the CreateArray() method at bottom of file
int[] numbers = CreateArray();  // <-- Uncomment and add this line
```

### **Step 3: Test Your Work**
- Run the program after implementing each method
- Use the provided helper methods to display results:
  - `NumberPrinter()` for arrays and lists
  - `DictionaryPrinter()` for dictionaries
- Each operation has clear console labels to show progress

## Learning Approach

### **Arrays & Lists (Step-by-Step)**
- Detailed step-by-step instructions
- Clear examples to guide implementation
- Research prompts to learn core methods

### **Dictionaries (Key-Value Practice)**
- Learn fast lookups with key-value pairs
- Practice adding, retrieving, and checking keys
- Understand when dictionaries are the right choice

## Key Learning Outcomes

### **Technical Skills:**
- Master all core Array, List, and Dictionary operations
- Understand when to use different collection types (indexed vs key-value)
- Learn proper method organization and code structure
- Practice input validation and error handling

### **Professional Skills:**
- Research documentation (Microsoft Docs, IntelliSense)
- Break complex problems into methods
- Write clean, organized code
- Test and debug systematically

## Tips for Success

1. **Complete in Order**: Start with Arrays, then Lists, then Dictionaries
2. **Test Frequently**: Run the program after each method implementation
3. **Use NumberPrinter**: This helper method displays your collections clearly
4. **Research Methods**: Use the core methods lists in the summary for reference
5. **Don't Rush**: Take time to understand each collection's unique characteristics
6. **Dictionary Focus**: Pay attention to how key-value pairs differ from indexed collections

## Getting Help

### **Built-in References:**
- Core methods listed in the file header
- Method references as comments above each collection section
- Step-by-step instructions in each method stub

### **External Resources:**
- Microsoft Docs: docs.microsoft.com/dotnet/api/system.collections.generic
- C# Documentation: learn.microsoft.com/dotnet/csharp/
- IntelliSense: Type collection name + Ctrl+Space for methods


Happy coding! 🚀