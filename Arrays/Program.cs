// See https://aka.ms/new-console-template for more information


namespace _07_Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] grades = [20, 15, 34, 40, 10]; //define the new array with length of 5
      System.Console.WriteLine($"grade at index 0: {grades[0]}");
      string input = Console.ReadLine();
      grades[0] = int.Parse(input);
      System.Console.WriteLine($"grade at index 0: {grades[0]}");

      // another way to initialize an array
      int[] newGradesA = {20, 15, 34, 40, 10 };

      // another way
      int[] newGradesB = new int[] {20, 15, 34, 40, 10};

      System.Console.WriteLine($"New grade A at index 1: {newGradesA[1]}");
      System.Console.WriteLine($"New grade B at index 2: {newGradesB[2]}");
    }
  }
}
