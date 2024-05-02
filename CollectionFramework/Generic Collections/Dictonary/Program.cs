// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Creating a new dictionary with string keys and int values
//         Dictionary<string, int> ages = new Dictionary<string, int>();

//         // Adding some key-value pairs to the dictionary
//         ages.Add("John", 25);
//         ages.Add("Alice", 30);
//         ages.Add("Bob", 28);

//         // Accessing values using keys
//         Console.WriteLine("John's age is: " + ages["John"]);

//         // Updating the value associated with a key
//         ages["Alice"] = 31;

//         // Removing a key-value pair
//         ages.Remove("John");

//         // Iterating over key-value pairs
//         foreach (var kvp in ages)
//         {
//             Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
//         }

//         // Checking if a key exists
//         if (ages.ContainsKey("John"))
//         {
//             Console.WriteLine("John's age is present in the dictionary.");
//         }
//         else
//         {
//             Console.WriteLine("John's age is not present in the dictionary.");
//         }

//         // Clearing the dictionary
//         ages.Clear();
//     }
// }



using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a dictionary to store student grades
        Dictionary<string, double> studentGrades = new Dictionary<string, double>();

        // Adding student grades
        studentGrades.Add("Alice", 85.5);
        studentGrades.Add("Bob", 90.0);
        studentGrades.Add("Charlie", 75.2);
        studentGrades.Add("David", 80.8);

        // Accessing and printing student grades
        Console.WriteLine("Student Grades:");
        foreach (var kvp in studentGrades)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Updating a student's grade
        studentGrades["Charlie"] = 79.3;

        Console.WriteLine("\nAfter updating Charlie's grade:");
        Console.WriteLine("Student Grades:");
        foreach (var kvp in studentGrades)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Removing a student from the dictionary
        studentGrades.Remove("David");

        Console.WriteLine("\nAfter removing David's grade:");
        Console.WriteLine("Student Grades:");
        foreach (var kvp in studentGrades)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Checking if a student's grade exists
        string studentName = "Bob";
        if (studentGrades.ContainsKey(studentName))
        {
            Console.WriteLine($"\n{studentName}'s grade is present in the dictionary.");
        }
        else
        {
            Console.WriteLine($"\n{studentName}'s grade is not present in the dictionary.");
        }

        // Clearing the dictionary
        studentGrades.Clear();

        Console.WriteLine("\nAfter clearing the dictionary, the count is: " + studentGrades.Count);
    }
}
