// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

namespace ConditionalChallenge
{
  class Program
  {
    static int highScore = 300;
    static string highScoreHolder = "Rodolfo";

    static void Main(string[] args)
    {
      CheckHighScore(250, "John");
      CheckHighScore(350, "Joe");
      CheckHighScore(450, "Gabs");
      Console.Read();
    }

    public static void CheckHighScore(int score, string playerName)
    {
        if(score > highScore)
        {
          highScore = score;
          highScoreHolder = playerName;
          Console.WriteLine($"New high score is {score}");
          Console.WriteLine($"New high score holder is {playerName}");
        } else
        {
          Console.WriteLine($"The old high score of {highScore} could not be broken by {playerName}, and it is held by {highScoreHolder}");
        }
    }
  }
}
