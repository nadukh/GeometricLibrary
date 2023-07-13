using System;

namespace FiguresLibrary
{
    public class Figure
    {
        public double Area;
        public double Perim;
        public virtual double GetArea()
        {
            return Area;
        }
        public virtual double GetPerim()
        {
            return Perim;
        }

        public void getInfomation()
        {
            Console.WriteLine($"Площадь: {Math.Round(GetArea(), 2)}");
            Console.WriteLine($"Периметр: {Math.Round(GetPerim(), 2)}");
        }

    }
}

