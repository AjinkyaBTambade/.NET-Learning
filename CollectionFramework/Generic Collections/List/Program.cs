using System;
using System.Collections.Generic;

// Task class to represent individual tasks
class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public Task(int id, string description)
    {
        Id = id;
        Description = description;
        IsCompleted = false;
    }

    public override string ToString()
    {
        return $"Task {Id}: {Description} (Completed: {IsCompleted})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold tasks
        List<Task> tasks = new List<Task>();

        // Add some tasks
        tasks.Add(new Task(1, "Complete homework"));
        tasks.Add(new Task(2, "Go to the gym"));
        tasks.Add(new Task(3, "Buy groceries"));

        // Display all tasks
        Console.WriteLine("All tasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
        }

        // Mark a task as completed
        tasks[0].IsCompleted = true;

        // Display completed tasks
        Console.WriteLine("\nCompleted tasks:");
        foreach (Task task in tasks)
        {
            if (task.IsCompleted)
            {
                Console.WriteLine(task);
            }
        }

        // Display remaining tasks
        Console.WriteLine("\nRemaining tasks:");
        foreach (Task task in tasks)
        {
            if (!task.IsCompleted)
            {
                Console.WriteLine(task);
            }
        }
    }
}
\