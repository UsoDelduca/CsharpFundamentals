// See https://aka.ms/new-console-template for more information


namespace WhileLoop
{ 
  class Program
  {
    static void Main(string[] args)
    {
      int counter = 0;
      string enteredText = "";
      while(enteredText.Equals(""))
      {
        System.Console.WriteLine("Please, press enter to increase the amount by one, and anything else" + " + enter if you want to finish counting.");
        enteredText = Console.ReadLine();
        counter++;
        System.Console.WriteLine($"Current people counter is {counter}");
      }
    }
  }
}
