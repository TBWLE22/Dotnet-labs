using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectArea
{
    class Rectangle
    {
        private double length, breadth, area;
        public Rectangle (double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public void computeArea()
        {
            area = length * breadth;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"The area is {area}");
        }
        public double GetArea()
        {
            return area;
        }
    }
}
