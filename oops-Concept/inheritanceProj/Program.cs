// signle + heirachical

// Parent Class (Base Class)
public class Vehicle
{
    public int Wheels; // Property
    public string Brand; // Property

    public void DisplayInfo() // Method
    {
        Console.WriteLine($"Brand: {Brand},\nWheels: {Wheels}");
    }
}

// Child Class (Derived Class)
public class Car : Vehicle
{
    public string Model; // Additional Property

    public void DisplayCarInfo() // Additional Method
    {
        Console.WriteLine($"Model is : {Model}");
    }
}


public class Color : Car
{
    public string carColor;
    public void ColorCar(){
        Console.WriteLine($"Car color is : {carColor}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the derived class
        Color myCar = new Color();
        myCar.Brand = "Ford";  
        myCar.Wheels = 4;       
        myCar.Model = "Lincoln";  
        myCar.carColor = "Black + Red";

        // Calling methods
        myCar.DisplayInfo();     
        myCar.DisplayCarInfo(); 
        myCar.ColorCar();
    }
}




// multilavel
// Another exaple

// Base Class (Parent Class)
// public class Vehicle
// {
//     public int Wheels;
//     public string Brand;

//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Brand: {Brand}, Wheels: {Wheels}");
//     }
// }

// // Derived Class 1 (Car)
// public class Car : Vehicle
// {
//     public string Model;

//     public void DisplayCarInfo()
//     {
//         Console.WriteLine($"Car Model: {Model}");
//     }
// }

// // Derived Class 2 (Truck)
// public class Truck : Vehicle
// {
//     public string CargoType;

//     public void DisplayTruckInfo()
//     {
//         Console.WriteLine($"Truck Cargo: {CargoType}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create an object of the Car class
//         Car myCar = new Car();
//         myCar.Brand = "Ford";
//         myCar.Wheels = 4;
//         myCar.Model = "Mustang";
//         myCar.DisplayInfo();
//         myCar.DisplayCarInfo();

//         // Create an object of the Truck class
//         Truck myTruck = new Truck();
//         myTruck.Brand = "Volvo";
//         myTruck.Wheels = 6;
//         myTruck.CargoType = "Heavy";
//         myTruck.DisplayInfo();
//         myTruck.DisplayTruckInfo();
//     }
// }
