public partial class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double BaseSalary { get; set; }
}


public partial class Employee
{
    public double CalculateSalary()
    {
        return BaseSalary;
    }
}

class employee_partial
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.FirstName = "Pranav";
        employee.LastName = "Goyal";
        employee.BaseSalary = 50000.0;

        double calculatedSalary = employee.CalculateSalary();
        Console.WriteLine($"Calculated Salary: {calculatedSalary:C}");
    }
}

