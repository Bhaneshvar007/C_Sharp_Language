using System;

class Calculator
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method to add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        
        Console.WriteLine("Sum of 2 numbers: " + calc.Add(5, 10));      // Calls the Add(int, int)
        Console.WriteLine("Sum of 3 numbers: " + calc.Add(5, 10, 15));  // Calls the Add(int, int, int)
    }
}
