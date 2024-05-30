using System;

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = { 22, 11, 33, 44, 55 }; // Initializing intArray with values

        // Printing elements of intArray
        Console.WriteLine("Elements of intArray:");
        foreach (int i in intArray)
        {
            Console.WriteLine("\t{0}", i);
        }

        Array.Sort(intArray); // Sorting intArray
        Array.Reverse(intArray); // Reversing the sorted intArray

        // Printing sorted and reversed intArray
        Console.WriteLine("\nSorted and reversed intArray:");
        foreach (int i in intArray)
        {
            Console.WriteLine("\t{0}", i);
        }

        int[] arr = new int[5]; // Creating an empty array arr

        int[] arr2 = { 10, 20, 30, 40, 50 }; // Initializing arr2 with values

        // Printing elements of arr2
        Console.WriteLine("\nElements of arr2:");
        foreach (int i in arr2)
        {
            Console.WriteLine("\t{0}", i);
        }
    }
}
