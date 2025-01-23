// class Program{
//     string name = "Bhaneshvar Kshirsagar";
//     int age = 21;
//     string location = "Balaghat";
//     public static void Main(String[] args){
//         Program obj = new Program();
//         Console.WriteLine("My name is : " +obj.name);
//         Console.WriteLine("My age is : "+ obj.age);
//         Console.WriteLine("My location is : "+ obj.location);
//     }
// }



// Exaple of multiclass object
class Car
{
  string color = "red";
  static void Main(string[] args)
  {
    Car myObj1 = new Car();
    Car myObj2 = new Car();
    Console.WriteLine(myObj1.color);
    Console.WriteLine(myObj2.color);
  }
}