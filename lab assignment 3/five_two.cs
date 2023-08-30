using System;
using Library;

class five_two
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        Console.WriteLine($"Protected Internal field value: {obj.protectedInternalField}");
    }
}
