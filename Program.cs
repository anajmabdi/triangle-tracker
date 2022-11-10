using System;
using SideTracker.TriangleTracker;

namespace SideTracker {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter one number");
      string length1 = Console.ReadLine();
      int lengthOne = int.Parse(length1);
      Console.WriteLine("Enter another number");
      string length2 = Console.ReadLine();
      int lengthTwo = int.Parse(length2);
      Console.WriteLine("Enter one last number");
      string length3 = Console.ReadLine();
      int lengthThree = int.Parse(length3);

      Triangle newTriangle = new Triangle(lengthOne, lengthTwo, lengthThree);
      Console.WriteLine(newTriangle.CheckType());
    }
  }
}
