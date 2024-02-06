// See https://aka.ms/new-console-template for more information


namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int lengthOfText = 0;
      string wholeText  = "";

      do
      {
        Console.WriteLine("Please, enter the name of a friend:");
        string nameOfFriend = Console.ReadLine();
        int currentLength = nameOfFriend.Length;
        lengthOfText += currentLength;
        wholeText +=nameOfFriend;

      } while (lengthOfText < 20);
      Console.WriteLine("Thanks. It is enough " + wholeText);

    }
  }
}
