// use methods to build a program that calculates the material cost for any architect’s floor plan

using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
        CalculateTotalCost();
    }

    public static void CalculateTotalCost()
    {
        double teoFull = Math.Round(Triangle(750, 500) + (Circle(375)) / 2 + Rectangle(2500, 1500));
        double costOfTeo = Math.Round(teoFull * 180);
        Console.WriteLine($"The teo floorplan is approx {teoFull}m. This means that it will cost \n" +
        $"approx {costOfTeo}.");

    }

    public static double Rectangle(double length, double width)
    {
        double areaOfRect = length * width;
        return areaOfRect;
    }

    public static double Circle(double radius)
    {
        double areaOfCircle = Math.PI * Math.Pow(radius, 2);
        return areaOfCircle;
    }

    public static double Triangle(double bottom, double height)
    {
        double areaOfTriangle = 0.5 * bottom * height;
        return areaOfTriangle;
    }

    
   }
}

