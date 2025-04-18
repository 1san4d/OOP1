using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace classes;

public class Car
{
    string name; decimal price;
    public string Name {
        get {
            return name;
        }
         private set{
            name=value;
        }
    }
    public void SetName(string name){ // public gate to set 
        Name=name;
    }

    public decimal Price {
        get {
            return price;
        }
        set {
            price=PriceValidation(value);
        }
    }
    public bool IsThousand => price==1000;
    public Car (string name, decimal price){
        this.Name=name;
        this.Price=price;
    }
    public void PrintInfo() => System.Console.WriteLine($"Car name: {name}, Price is: {Math.Round(price)}");// Prints info
    private decimal PriceValidation(decimal price) => (price<=0) ? 0 : Math.Round(price, 2); // validation method   
    private decimal Validation (decimal value){ // Same as the One above
        if (value <=0){
            return 0;
        }
        else {
            return Math.Round(value, 2);
        }
    }
    // private String StringCheck(String text) {
    //     if (fsafsaf) {
    //         return text;
    //     }
    //     else {
    //         System.Console.WriteLine("Enter valid text");
    //         default;
    //     }
    // }

}


