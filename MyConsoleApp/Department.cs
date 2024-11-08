using System;

namespace MyConsoleApp
{
    public class Department
    {
        public string DepartmentName { get; set; }
        
        public void AssignStudentToDepartment(Student student)
        {
            student.DepartmentName = DepartmentName;
            Console.WriteLine($"Assigned {student.Name} to {DepartmentName} department.");
        }
    }
}
