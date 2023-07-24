using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Circumference : Figure
    {
        public double radius;
        public Circumference(double rad)
        {
            radius = rad;
        }
        public override double GetArea()
        {
            Area = 3.14 * Math.Pow(radius, 2);
            return Area;
        }
        public override double GetPerim()
        {
            Perim = 2 * 3.14 * radius;
            return Perim;
        }
    }
}
