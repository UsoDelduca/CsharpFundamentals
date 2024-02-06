using System.Runtime.CompilerServices;

namespace CsharpClasses;

internal class Car
{
  // Member variable
  private string _name;
  private int _hp;
  private string _colour;

  public void setName(string name)
  {
    _name = name;
  }
  // Constructor
  public Car()
  {
    _name = "Car";
    _hp = 0;
    _colour = "red";
  }
  public Car(string name, int hp = 0, string colour = "black")
  {
    _name=name;
    _hp = hp;
    _colour = colour;
    Console.WriteLine($"A {colour} {name} was created");
    Drive();
  }
  // Member Methods - only available to objects of the Car datatype
  private void Drive()
  {
    Console.WriteLine($"The {_colour} {_name} is driving");
  }
  public void Stop()
  {
    Console.WriteLine($"The {_colour} {_name} has stopped"); 
  }
  public void Details()
  {
    Console.WriteLine($"The {_colour} {_name} has got {_hp} horsepower");
    Console.WriteLine("-------------------------------------------");
  }


}
