using System;
using System.Text;
using CarTask;
using Microsoft.VisualBasic;

namespace Task1;

public class Car
{
    public static int GasolineCarCount = AllCarCount - ElectricCarCount;
    public static int ElectricCarCount = 0;
    public static int AllCarCount = 0;
    protected string brand; protected string name; protected int year; protected string model;
    
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            if (value < 2000)
            {
                throw new ArgumentException("Only cars released after 2000 are allowed");
            }
            else
            {
                year = value;
            }
        }
    }
    public Car() : this("unknown", "unknown", 0000, "unknown") //passes those values to the main ctor
    {
    }
    public Car(string brand, string name, string model) : this(brand, name, 0000, model) // passes those value to the main ctor 
    {

    }
    public Car(string brand, string name, int year, string model) //main constructor
    {
        this.year = year;
        this.brand = brand;
        this.name = name;
        this.model = model;
        AllCarCount++;
    }
    public virtual void PrintInfo()
    {
        System.Console.WriteLine($"Your car is {name}, Brand: {brand}, Model: {model}, Released in: {year}.");
    }
    public virtual void StartEngine()
    {
        System.Console.WriteLine("\"Enginge is starting...\"\n\"Brrrrrrrrrrrrrrrrrrrrr.............\"");
    }
    public virtual void StopEngine()
    {
        System.Console.WriteLine("\"Enginge is stopping...\"\n\"shhhhh.......\"");
    }
}
