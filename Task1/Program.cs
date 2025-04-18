using System.Runtime.InteropServices;
using Task1;

Car Car1 = new Car ();
Car1.name= "wezza";
Car1.brand="BMW";
Car1.model="idk";
//Car1.year=2006;
Car1.Year=2006;
Car1.PrintInfo();
Car1.StartEngine();
System.Console.WriteLine();

Car Car2 = new Car ();
Car2.name= "batta";
Car2.brand="Ferrari";
Car2.model="idk";
//Car2.year=2024;
Car2.Year=2024;
Car2.PrintInfo();
Car2.StopEngine();
System.Console.WriteLine();

Car Car3=new Car ("toyota", "breshka");
//Car3.year=1999; //throws an argument exception
Car3.Year=2001;
Car3.PrintInfo();

System.Console.WriteLine($"Cars Count is: {Car.carCount}"); //Cars Count
Console.ReadLine();