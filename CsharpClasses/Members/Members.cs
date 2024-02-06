using System.Diagnostics;

namespace Members;

public class Members
{
  // member - private field
  private string memberName;
  private string jobTitle;
  private int salary;

  // member - public field
  public int age;

// member - property - exposes jobTitle safely - properties start with a capital letter
  public string JobTitle 
  {
    get
    {
      return jobTitle;
    }
    set
    {
      jobTitle = value;
    }
    }

    // public member Method - can be called from other classes

    public void Introduce(bool isFriend)
    {
      if(isFriend)
      {
        SharingPrivateInfo();
      }else
      {
        System.Console.WriteLine($"Hi. My name is {memberName}. I am a {jobTitle}, and I am {age}");
      }
    }
    private void SharingPrivateInfo()
    {
      System.Console.WriteLine($"My salary is {salary}");
    }

    // member constructor
    public Members()
    {
      age = 30;
      memberName = "Lucy";
      salary = 60000;
      jobTitle = "Developer";
      System.Console.WriteLine("Object created");
    }

    // member - finalizer - destructor
    ~Members()
    {
      // cleanup statements
      System.Console.WriteLine("Deconstruction of Members object");
      Debug.Write("Destruction is complete");
    }
}
