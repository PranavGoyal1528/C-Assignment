using System;

public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

public sealed class Car : Vehicle
{
    // This is a sealed class, meaning it cannot be further inherited.
}

// This class cannot inherit from the sealed class 'Car'
public class SubCar : Car
{
    // This will result in a compilation error
}

class vehicle_sealed
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.StartEngine();
        car.StopEngine();

        // The following line would result in a compilation error
        // SubCar subCar = new SubCar();
    }
}
