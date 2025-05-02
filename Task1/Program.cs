using System.Runtime.InteropServices;
using CarTask;
using Task1;
ElectricCar e1 = new ElectricCar(90);
e1.PrintInfo();
e1.StartEngine();
System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Car c1 = new Car();
c1.PrintInfo();
c1.StartEngine();
System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Car[] cars = new Car[] {
    new Car(),
    new Car(),
};
System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
System.Console.WriteLine($"All Cars Count: {Car.AllCarCount}");
System.Console.WriteLine($"Electric Cars Count: {Car.ElectricCarCount}");
System.Console.WriteLine($"Gasoline Cars Count: {Car.GasolineCarCount}");