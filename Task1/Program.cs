using System.Runtime.InteropServices;
using CarTask;
using Task1;
// ElectricCar e1 = new ElectricCar(90);
// e1.PrintInfo();
// e1.StartEngine();
// System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
// Car c1 = new Car();
// c1.PrintInfo();
// c1.StartEngine();
// System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Car[] cars = new Car[] {
    new Car("toyota","momo",2010,"F70"),
    new Car("mercedis","zoro",2020,"M50"),
    new ElectricCar("Tesla", "CyberTruck",2022,"K10",100),
    new ElectricCar(20),
};
foreach (Car Car in cars)
{
    Car.PrintInfo();
    Car.Move();
    System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
}
System.Console.WriteLine($"All Cars Count: {Car.AllCarCount}");
System.Console.WriteLine($"Electric Cars Count: {Car.ElectricCarCount}");
System.Console.WriteLine($"Gas Cats Count: ");

Console.ReadKey();