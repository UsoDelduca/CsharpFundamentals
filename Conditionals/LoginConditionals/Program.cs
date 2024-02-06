// See https://aka.ms/new-console-template for more information

namespace LoginConditionals
{
  class Program
  {

    static void Main(string[] args)
    {
      bool isAdmin = false;
      bool isRegistered = true;
      string userName = "";
      Console.WriteLine("Please, enter your username:");

      userName = Console.ReadLine();
      if(isRegistered && userName != "" && userName.Equals("admin"))
      {
        Console.WriteLine("Hello, Admin");
      } else if(isRegistered && userName != "" && userName !="admin")
      {
        Console.WriteLine($"Hello, {userName}");
      }
      if(isAdmin || isRegistered)
      {
        Console.WriteLine("You are logged in!");
      }
    }
  }
}