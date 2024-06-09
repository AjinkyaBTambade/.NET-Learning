using System;
using System.Collections.Generic;

namespace StateManagmentApp.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Role { get; set; } = null!;
}
