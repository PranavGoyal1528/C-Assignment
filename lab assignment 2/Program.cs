using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Salary: {Salary}"); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Employee employee = new Employee("Pranav Goyal", 23, 42000.0);

        employee.DisplayDetails();
    }
}
