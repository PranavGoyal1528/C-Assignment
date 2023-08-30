using System;

class BaseClass
{
    public int MyProperty { get; set; }
}

class DerivedClass : BaseClass
{
    public void AccessProperty()
    {
        MyProperty = 42;
        Console.WriteLine($"Value of MyProperty in the derived class: {MyProperty}");
    }
}

class six
{
    static void Main(string[] args)
    {
        DerivedClass derivedObj = new DerivedClass();
        derivedObj.AccessProperty();
    }
}
