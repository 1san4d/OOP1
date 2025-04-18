// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using classes;

// Student std1 = new Student("Aya Mohamed","Female",123);
// // std1.GetInfo();
// Student std2 = new Student("Ali Ahmed","Male",1233);
// std2.house="3";
// std2.BD=-19;
// std2.GetInfo();

Car car1= new Car("bmw",1001M); // i can in the constructor But, I cant in the property
//car1.Name="mercidec"; through the property
car1.SetName("houndai"); // through the public (method public)
car1.PrintInfo();
System.Console.WriteLine(car1.IsThousand); //booleans
System.Console.WriteLine(car1.Name);
Console.ReadLine();


