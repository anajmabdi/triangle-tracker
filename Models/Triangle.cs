namespace SideTracker.TriangleTracker
{
  public class Triangle
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }

    public Triangle(int sideOne, int sideTwo, int sideThree) 
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }
    public string CheckType()
    {
      if (SideOne > SideTwo + SideThree || SideTwo > SideOne + SideThree || SideThree > SideOne + SideTwo)
      {
        return "Not a triangle";
      }
      else if (SideOne == SideTwo && SideTwo == SideThree)
      {
        return "Equilateral Triangle";
      }
      else if (SideOne == SideTwo || SideOne == SideThree || SideTwo == SideThree)
      {
        return "Isosceles Triangle";
      }
      else 
      {
        return "Scalene Triangle";
      }

    }
  }
}
