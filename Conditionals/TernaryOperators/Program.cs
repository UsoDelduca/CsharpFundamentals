// See https://aka.ms/new-console-template for more information


namespace TernaryOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      int temperature = -5;
      string stateOfMatter;

      stateOfMatter = temperature < 0 ? "solid" : "liquid";
      Console.WriteLine($"Temperature is {temperature}. State of matter is {stateOfMatter}");

      temperature +=30;
      stateOfMatter = temperature < 0 ? "solid" : "liquid";
      Console.WriteLine($"Temperature is {temperature}. State of matter is {stateOfMatter}");

      temperature +=130;
      stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

      Console.WriteLine($"Temperature is {temperature}. State of matter is {stateOfMatter}");
    }
  }
}
