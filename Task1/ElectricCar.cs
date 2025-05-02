using System;
using Task1;

namespace CarTask;

public class ElectricCar : Car
{

    int _battery;
    public ElectricCar(int battery) : this("unknown", "unknown", 0, "unknown", battery)
    {

    }
    public ElectricCar(string brand, string name, int year, string model, int battery) : base(brand, name, year, model) //main ctor
    {
        this._battery = battery;
        ElectricCarCount++;
    }
    public override void PrintInfo()
    {
        System.Console.WriteLine($"Your car is {name}, Brand: {brand}, Model: {model}, Released in: {year}");
        System.Console.WriteLine($"Battery Capacity is: {_battery}");
    }
    public override void StartEngine()
    {
        System.Console.WriteLine("\"Enginge is Charging...\"\n\"Zoooooooooooooooo.............\"");
    }
    public override void StopEngine()
    {
        System.Console.WriteLine("\"Enginge is Discharging...\"\n\"zeeeeeeeeeeeeeeee.......\"");
    }
}
