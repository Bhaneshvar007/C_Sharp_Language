using System;

class Animal
{
    // Virtual method in base class
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // Overriding the base class method
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    // Overriding the base class method
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Cow : Animal
{
    // Overriding the base class method
    public override void Sound()
    {
        Console.WriteLine("Cow moos");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();  // Reference of type Animal
        Animal myDog = new Dog();         // Reference of type Animal, but object of Dog class
        Animal myCat = new Cat();         // Reference of type Animal, but object of Cat class
        Animal myCow = new Cow();         // Reference of type Animal, but object of Cow class

        myAnimal.Sound();  // Calls the Animal class method
        myDog.Sound();     // Calls the Dog class method (overridden)
        myCat.Sound();     // Calls the Cat class method (overridden)
        myCow.Sound();     // Calls the Cow class method (overridden)
    }
}
