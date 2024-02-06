// See https://aka.ms/new-console-template for more information


namespace ConstantsC
{
  // Constants - These are immutable values which are known at compile time and do not change for the life of the program



  class Program
  {

    // constants as fields

    const double PI = 3.14159265359;
    const int weeks = 52, months =12;
    const string bday = "15/10/1985";


      static void Main(string[] args)
      {
        Console.WriteLine($"My birthday is {bday}");

      }


  }
}
