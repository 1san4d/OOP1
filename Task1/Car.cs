using System;
using Microsoft.VisualBasic;

namespace Task1;

public class Car
{
public static int carCount = 0;
public string brand; public string name; int year; public string model;
public int Year{
    get{
        return year;
    }
    set{
        if (value<=2000){
            throw new ArgumentException("Only cars released after 2000 are allowed");
        }
        else{
        year=value;
        }
    }
}
public Car (){
        carCount++;
        this.brand="unknown";
        this.name="unknown";
        this.year=0;
        this.model="unknown";
}
public Car (string brand, string name)
{
    this.year=0;
    this.model="unknown";
    this.brand=brand;
    this.name=name;
    carCount++;
}
public void PrintInfo(){
    System.Console.WriteLine($"Your car is {name}, Brand: {brand}, Model: {model}, Released in: {year}.");
}
public void StartEngine(){
    System.Console.WriteLine("\"Enginge is starting...\"\n\"Brrrrrrrrrrrrrrrrrrrrr.............\"");
}
public void StopEngine(){
    System.Console.WriteLine("\"Enginge is stopping...\"\n\"shhhhh.......\"");
}
}
