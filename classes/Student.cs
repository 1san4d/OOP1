using System;
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace classes;

public class Student
{
string name; string gender; int id;
public string house {set; get;}
int bd;
public int BD {
   get => bd;
   set => bd = (value>0) ? bd=value : bd=0;
} 
public string Name
{
    set
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Name cannot be null, empty, or whitespace.");
        }
        if (!value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
        {
            throw new ArgumentException("Name can only contain alphabetic characters and spaces.");
        }
        name = value;
    }
    get
    {
        return name;
    }
}
public string Gender {
   set
   {
      gender=value;
   }
   get
   {
      return gender;
   }
}
public int ID{
   set
   {
      id=value;
   }
   get
   {
      return id;
   }
}

public Student (string name, string gender, int id){
   this.Name=name;
   this.Gender=gender;
   this.ID=id;
}
public void GetInfo(){
   System.Console.WriteLine($"Name is {name}, Gender is {gender}, ID is {id}");
   System.Console.WriteLine($"House is {house}");
   System.Console.WriteLine($"BD is {bd}");
if (bd==0) System.Console.WriteLine("Enter valid BD ,pls"); // validation message :)
}
}
