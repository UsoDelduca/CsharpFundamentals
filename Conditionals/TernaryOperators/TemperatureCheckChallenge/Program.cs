// See https://aka.ms/new-console-template for more information


namespace TemperatureCheckChallenge 
{
  class Program
  {
    static void Main(string[] args)
    {
      int inputTemperature = 0;
      string temperatureMessage = string.Empty;
      string inputValue = string.Empty;

      Console.WriteLine("Please, enter the current temperature:");
      inputValue = Console.ReadLine();
      bool validInteger = int.TryParse(inputValue, out inputTemperature);

      if(validInteger)
      {
        temperatureMessage = inputTemperature <= 15 ? "It is too cold!" : (inputTemperature >=16 && inputTemperature <=28) ?  "it is ok" : inputTemperature > 28 ? "It is hot here" : "";
        Console.WriteLine(temperatureMessage);
      }else 
      {
        Console.WriteLine("Please, enter a valid number");
      }
    }
  }
}
