using System;

class MyBaseClass
{
    protected int protectedField = 10;
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method called.");
    }
}

class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMembers()
    {
        Console.WriteLine($"Protected field value: {protectedField}");
        ProtectedMethod();
    }
}

class four
{
    static void Main(string[] args)
    {
        MyDerivedClass derivedObj = new MyDerivedClass();
        derivedObj.AccessProtectedMembers();
    }
}
