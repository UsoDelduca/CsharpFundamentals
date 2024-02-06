// See https://aka.ms/new-console-template for more information


using System.Numerics;

namespace AverageScore
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the student's score. Type -1 if you have finished.");
      string studentScore = "0";
      int counter = 0;
      int parsedScore;
      int scoreSum = 0;
      while(studentScore != "-1")
      {

        

        Console.WriteLine($"The sum of all scores is currently {scoreSum}");
        Console.WriteLine("Type -1 once you want the average score");
        studentScore = Console.ReadLine();
        if(studentScore.Equals("-1"))
        {
          double averageScore = (double)scoreSum/counter;
          Console.WriteLine("____________------------____________------------");
          Console.WriteLine($"| The average of all scores is {averageScore} |");
          Console.WriteLine("------------____________------------____________");
          
        }
          if(int.TryParse(studentScore, out parsedScore) && parsedScore > 0 && parsedScore < 21)
          {
            scoreSum += parsedScore;
          }
          else
          {
            if(!studentScore.Equals("-1"))
            {
              Console.WriteLine("Please, enter a value between 1 and 20");
            }
            continue;
          }
          counter++;
        Console.WriteLine($"The number of students is {counter}");
      }
    }
  }
}
