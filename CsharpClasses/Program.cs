// See https://aka.ms/new-console-template for more information

namespace CsharpClasses
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Car myCar = new Car();
      myCar.SetName("Marquinho");
      Console.WriteLine("The name of the car is " + myCar.GetName() + ", and it has " + myCar.GetHorsepower());
      
      myCar.Details();
      Car audi = new Car("Audi A4", 800, "red");
      audi.Details();
      Car bmw = new Car("BMW M5", 850);
      bmw.Details();
      string userInput = Console.ReadLine();
      if(userInput == "1")
      {

      audi.Stop();
      bmw.Stop();
      }
      else{ Console.WriteLine("Cars are still driving...");}
    }
  }
}