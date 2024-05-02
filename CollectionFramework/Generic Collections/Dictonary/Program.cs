using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Adding some key-value pairs to the dictionary
        ages.Add("John", 25);
        ages.Add("Alice", 30);
        ages.Add("Bob", 28);

        // Accessing values using keys
        Console.WriteLine("John's age is: " + ages["John"]);

        // Updating the value associated with a key
        ages["Alice"] = 31;

        // Removing a key-value pair
        ages.Remove("John");

        // Iterating over key-value pairs
        foreach (var kvp in ages)
        {
            Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
        }

        // Checking if a key exists
        if (ages.ContainsKey("John"))
        {
            Console.WriteLine("John's age is present in the dictionary.");
        }
        else
        {
            Console.WriteLine("John's age is not present in the dictionary.");
        }

        // Clearing the dictionary
        ages.Clear();
    }
}
