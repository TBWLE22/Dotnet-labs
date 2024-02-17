using System;
namespace rectArea;

internal class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle1 = new Rectangle( 5, 4);
        Rectangle rectangle2 = new Rectangle(2, 8);

        rectangle1.computeArea();
        rectangle2.computeArea();

        rectangle1.DisplayArea();
        rectangle2.DisplayArea();

        if (rectangle1.GetArea() > rectangle2.GetArea())
        {
            Console.WriteLine("Rectangle 1 has bigger area.");
        }
        else if (rectangle1.GetArea() < rectangle2.GetArea())
        {
            Console.WriteLine("Rectangle 2 has bigger area.");
        }
        else
        {
            Console.WriteLine("Both rectangels have same area.");
        }
    }
}


