// See https://aka.ms/new-console-template for more information


namespace HelloWorld
{

    class Program
    {

   



      static void Main(string[] args)
      {
          string friend1 = "ABC";
          string friend2 = "DEF";
          string friend3 = "GHI";
/*
          WriteSomething(); //This is the Method being called, just like a JS function
          WriteSomethingSpecific("I am an argument and I am called from a method");
*/

          Console.WriteLine(Add(15,31));
          Console.WriteLine(Multiply(4,4));
          Console.WriteLine(Divide(25,13));
          GreetFriend(friend1);
          GreetFriend(friend2);
          GreetFriend(friend3);
           Console.Read();
      }

      public static void WriteSomething() // methods are like JS functions and the Main METHOD is like a React Main component (App)
      {
        Console.WriteLine("I am called from a METHOD");
       
      }

      public static void WriteSomethingSpecific(string myText){

        Console.WriteLine(myText);
      }

      public static int Add(int num1, int num2){
        return num1 + num2;
      }

      public static int Multiply(int num1, int num2)
      {
        return num1 * num2;
      }

      public static double Divide(double num1, double num2)
      {
        return num1 / num2;
      }

      public static void GreetFriend(string friendName)
      {
        Console.WriteLine($"Hi, {friendName}");
      }
    }
}
