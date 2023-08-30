using System;

class MyClass
{
    private int myPrivateProperty;

    public void SetPropertyValue(int value)
    {
        myPrivateProperty = value;
    }

    public int GetPropertyValue()
    {
        return myPrivateProperty;
    }
}

class seven
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.SetPropertyValue(42);
        int value = obj.GetPropertyValue();
        Console.WriteLine($"Value of private property: {value}");
    }
}
