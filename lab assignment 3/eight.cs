using System;

class MyClass
{
    private void PrivateMethod()
    {
        Console.WriteLine("Private method called.");
    }

    public void PublicMethod()
    {
        PrivateMethod();
    }
}

class eight
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.PublicMethod();
    }
}
