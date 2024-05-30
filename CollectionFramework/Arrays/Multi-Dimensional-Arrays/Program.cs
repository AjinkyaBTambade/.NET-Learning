using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a 2D array of integers with dimensions 3x3
        int[,] multiArray = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Accessing and printing elements of the multidimensional array
        Console.WriteLine("Elements of multiArray:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("\t {0}", multiArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}
