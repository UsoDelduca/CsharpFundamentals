// See https://aka.ms/new-console-template for more information

namespace Switch_Statement
{
  class Program
  {
    static void Main(string[] args)
    {
      int age = 19;

      switch (age)
      {
        case 15:
          Console.WriteLine("Too young");
          break;

        case 25:
          Console.WriteLine("Good to go");
          break;

        default:
          Console.WriteLine("How old are you?");
          break;
      }

      // if(age == 15)
      // {
      //   Console.WriteLine("Too young");
      // } else if( age == 25)
      // {
      //   Console.WriteLine("Good to go");
      // } else{
      //   Console.WriteLine("How old are you?");
      // }
    }
  }
}