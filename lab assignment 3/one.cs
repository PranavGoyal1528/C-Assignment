using System;

class MyClass
{
    private int myValue;

    public void SetValue(int value)
    {
        myValue = value;
    }
}

class one
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.SetValue(42);
    }
}
