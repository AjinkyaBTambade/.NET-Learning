using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Creating a new Queue to simulate the printing queue
        Queue printingQueue = new Queue();

        // Adding printing requests to the queue
        printingQueue.Enqueue("John's report");
        printingQueue.Enqueue("Alice's presentation");
        printingQueue.Enqueue("Bob's forms");

        // Simulating printing process
        Console.WriteLine("Printing Queue:");

        while (printingQueue.Count > 0)
        {
            string document = (string)printingQueue.Dequeue(); // Dequeue the document at the front of the queue
            Console.WriteLine("Printing: " + document);
           
        }

        Console.WriteLine("Printing complete. No more documents in the queue.");
    }
}
