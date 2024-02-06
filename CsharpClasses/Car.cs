using System.Runtime.CompilerServices;

namespace CsharpClasses;

internal class Car
{
  // Member variable
  private string _name;
  private int _hp;
  private string _colour;
  private int _speedLimit;

 /* public int GetHorsepower()
  {
    return _hp;
  }
  public string GetName()
  {
    return _name;
  }
  public void SetName(string name)
  {
    if(name == "")
    {
      _name = "Default Name";
    } else
    {
    _name = name;

    }
  }*/

  public int MaxSpeed { get; set;} //This auto-generates a private anonymous field 
  public int SuperSpeed { get;} = 350;//This makes the property READ-ONLY
  public int SpeedLimit 
  {
    set
    {
      _speedLimit = value; // This makes the property WRITE-ONLY and cannot be used or READ
    }
    }
  // public property

  public string Name {
    get{return _name;} 
    set {
      if(value == "")
      { _name = "Hello world Default Name";}
      else
      {   }
      _name = value; 
    
      }
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
