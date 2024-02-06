// See https://aka.ms/new-console-template for more information

namespace BreakContinue
{
  class Program
  {
    static void Main(string[] args)
    {
      // for(int counter = 0; counter<10; counter++)
      // {
      //   Console.WriteLine($"Counter is in {counter}");
      //   if(counter ==3)
      //   {
      //     Console.WriteLine($"We stop here at {counter}");
        
      //   break;
      //   }
      // }

      for(int counter = 0; counter<10; counter++)
      {
        if(counter%2 == 0)
        {
          Console.WriteLine($"ODD NUMBERS ONLY");
        
        continue;
        }
        Console.WriteLine($"Counter is in {counter}");
      }
    }
  }
}