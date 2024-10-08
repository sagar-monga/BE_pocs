﻿namespace _01WebApi.Models;

public class EmployeeDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Salary { get; set; }
    public string Department { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime? LastWorkingDate { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime DateOfBirth { get; set; }

    // * Calculated Properties
    // Can do like this too if we want to be more explicit
    // public string FullName
    // {
    //     get
    //     {
    //         return FirstName + " " + LastName;
    //     }
    // }

    // => creates a read only property
    public string FullName => FirstName + " " + LastName;
    public bool IsActive => !LastWorkingDate.HasValue;
    public long AnnualSalary => (long)Salary * 12;
    public int YearsInCurrentRole => DateTime.Now.Year - HireDate.Year;
    public int Age => DateTime.Now.Year - DateOfBirth.Year;
}
