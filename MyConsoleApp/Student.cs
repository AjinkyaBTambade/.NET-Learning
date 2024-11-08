using System;

namespace MyConsoleApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Department: {DepartmentName}");
        }
    }
}
