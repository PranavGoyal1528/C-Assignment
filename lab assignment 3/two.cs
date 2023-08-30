using System;

namespace MyNamespace
{
    class MyClass1
    {
        private int myPrivateField = 10;

        public int GetPrivateFieldValue()
        {
            return myPrivateField;
        }
    }

    class MyClass2
    {
        public void AccessPrivateField()
        {
            MyClass1 obj1 = new MyClass1();
            int value = obj1.GetPrivateFieldValue();
            Console.WriteLine($"Accessed private field value: {value}");
        }
    }

    class two
    {
        static void Main(string[] args)
        {
            MyClass2 obj2 = new MyClass2();
            obj2.AccessPrivateField();
        }
    }
}
