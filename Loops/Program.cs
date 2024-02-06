// See https://aka.ms/new-console-template for more information

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      for(int counter = 0; counter <= 20 ; counter++)
      {
        if(counter%2 !=0)
        {
          Console.WriteLine($"{counter} is an Odd number");
        }
      }
    }
  }
}
