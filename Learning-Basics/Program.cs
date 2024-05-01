//---------Generic Collections------------------

// using System;
// using System.Collections.Generic;
// namespace genericList
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> GenericList = new List<int>();
//             GenericList.Add(30);
//             GenericList.Add(60);
//             GenericList.Add(90);
//             GenericList.Add(120);
//             foreach (int x in GenericList)
//             {
//                 Console.WriteLine(x);
//             }
//         }
//     }
// }



//-------------One-Dimensional Array-------------------------

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Creating an array of integers with a length of 5 and initializing its elements
//         int[] intArray = { 22, 11, 33, 44, 55 };

//         // Printing each element of intArray
//         foreach (int i in intArray)
//         {
//             Console.WriteLine("\t {0}", i);
//         }

//         // Sorting the elements of intArray in ascending order
//         Array.Sort(intArray);

//         // Reversing the order of elements in intArray
//         Array.Reverse(intArray);

//         // Printing the sorted and reversed intArray
//         Console.WriteLine("\nSorted and Reversed intArray:");
//         foreach (int i in intArray)
//         {
//             Console.WriteLine("\t {0}", i);
//         }

//         // Creating an array of integers with a length of 5 and initializing its elements
//         int[] arr2 = { 10, 20, 30, 40, 50 };

//         // Printing each element of arr2
//         Console.WriteLine("\nElements of arr2:");
//         foreach (int i in arr2)
//         {
//             Console.WriteLine("\t {0}", i);
//         }

        
//     }
// }


// ----------------MultiDemensional Array----------------------------
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Creating a 2D array of integers with dimensions 3x3
//         int[,] multiArray = new int[3, 3]
//         {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         // Accessing and printing elements of the multidimensional array
//         Console.WriteLine("Elements of multiArray:");
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 2; j++)
//             {
//                 Console.Write("\t {0}", multiArray[i, j]);
//             }
//             Console.WriteLine();
//         }
//     }
// }

