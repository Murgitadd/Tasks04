using System;

class Program
{
    static void Main()
    {
        double circleArea = Area(5.0); 
        Console.WriteLine("Area of circle: " + circleArea);

        double rectangleArea = Area(4.0, 6.0); 
        Console.WriteLine("Area of rectangle: " + rectangleArea);

        double parallelepipedArea = Area(3.0, 4.0, 5.0); 
        Console.WriteLine("Area of parallelepiped: " + parallelepipedArea);

        double triangleArea = Area(3.0, 4.0, 5.0);
        Console.WriteLine("Area of triangle with nested circle: " + triangleArea);
    }

    static double Area(double radius)
    {
        double pi = Math.PI;
        return pi * Math.Pow(radius, 2);
    }

    static double Area(double length, double width)
    {
        
        return length * width;
    }

    static double Area(double length, double width, double height)
    {

        return 2 * (length * width + length * height + width * height);
    }

    static double Area(double sideA, double sideB, double sideC)
    {
     
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double radius = semiPerimeter / 2;
        double areaOfTriangle = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        return radius * areaOfTriangle;
    }
}
