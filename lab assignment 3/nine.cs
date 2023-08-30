using System;

class MyBaseClass
{
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method in base class called.");
    }
}

class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMethod()
    {
        ProtectedMethod();
    }
}

class nine
{
    static void Main(string[] args)
    {
        MyDerivedClass derivedObj = new MyDerivedClass();
        derivedObj.AccessProtectedMethod();
    }
}
