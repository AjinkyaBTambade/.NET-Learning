using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a department
            Department itDepartment = new Department { DepartmentName = "Information Technology" };

            // Create a student
            Student student = new Student { Id = 1, Name = "Ajinkya" };

            // Assign student to department
            itDepartment.AssignStudentToDepartment(student);

            // Display student info
            Console.WriteLine("\nStudent Details:");
            student.DisplayInfo();
        }
    }
}
