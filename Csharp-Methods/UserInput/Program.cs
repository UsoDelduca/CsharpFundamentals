// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
      {
        Calculate();
      }

      public static int Calculate()
      {
        Console.WriteLine("Enter a number:");
        string number1 = Console.ReadLine();

        try    
        {
          int userInputParse = int.Parse(number1);

        }

        catch (FormatException)

        {

          Console.WriteLine("Wrong format type. Please, enter a valid NUMBER next time");
        }
        
        catch (OverflowException)
        {
          Console.WriteLine("Overflow exception. The number is either too big or too small for and int32.");
        }


        Console.WriteLine("Enter another number:");
        string number2 = Console.ReadLine();

        try    
        {
          int userInputParse2 = int.Parse(number2);

        }

        catch (FormatException)

        {

          Console.WriteLine("Wrong format type. Please, enter a valid NUMBER next time");
        }
        catch (OverflowException)
        {
          Console.WriteLine("Overflow exception. The number is either too big or too small for and int32.");
        }

        finally
        {
          Console.WriteLine("This happens regardess of the errors above. This program has finished");
        }

        int result = userInputParse + userInputParse2; // the variables are only available in the Try-Catch scope - How to fix this?
        Console.WriteLine($"The sum of the two numbers is {result}");
        return result;
      }

  }
}
