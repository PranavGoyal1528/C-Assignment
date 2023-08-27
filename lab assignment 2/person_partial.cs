public partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}


using System;

public partial class Person
{
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}


class person_partial
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";

        person.PrintFullName();
    }
}
