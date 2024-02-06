// See https://aka.ms/new-console-template for more information


namespace Conditionals

{


  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Type a temperature and press enter:");
      string temperature = Console.ReadLine();
      int parsedTemp;

      bool success = int.TryParse(temperature, out parsedTemp);

      if(success && parsedTemp < 20)
      {
        Console.WriteLine($"It's {parsedTemp} degrees outside. Take your coat");
      }else if(success && parsedTemp == 20)
      {
        Console.WriteLine($"It's {parsedTemp} degrees outside. Go outside");
      }else if(success && parsedTemp > 20) 
      {
        Console.WriteLine($"It's {parsedTemp} degrees outside. What a warm day! What are you doing in front of the computer???");
      }else if(!success)
      {
        Console.WriteLine("Please, type a valid number");
      }
    }
  }  
}
