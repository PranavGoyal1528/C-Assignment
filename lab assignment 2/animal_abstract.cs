public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
}


public class Dog : Animal
{
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine($"{Name} the dog is barking.");
    }
}


public class Cat : Animal
{
    public string FurColor { get; set; }

    public void Meow()
    {
        Console.WriteLine($"{Name} the cat is meowing.");
    }
}


using System;

class animal_abstract
{
    static void Main(string[] args)
    {
        Dog dog = new Dog { Name = "Buddy", Age = 3, Breed = "Labrador" };
        dog.Bark();
        Console.WriteLine($"Dog's Age: {dog.Age}");

        Cat cat = new Cat { Name = "Whiskers", Age = 2, FurColor = "Calico" };
        cat.Meow();
        Console.WriteLine($"Cat's Age: {cat.Age}");
    }
}
