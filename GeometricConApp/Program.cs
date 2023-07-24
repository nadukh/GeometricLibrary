using System;
using FiguresLibrary;

namespace GeometricConApp
{
    class Program
    {
        static void Main(string[] args)
         {
            Console.WriteLine("Введите a, b и c: ");
            
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Figure triangle = new Triangle(a, b, c);
            Console.WriteLine($"\nПериметр: {triangle.GetPerim()}");
            Console.WriteLine($"\nПлощадь треугольника: {triangle.GetArea()}");
           // triangle.getInfomation();
           
            Console.Write("\nВведите радиус: ");
            double rad = Convert.ToDouble(Console.ReadLine());

            Figure circumference = new Circumference(rad);
            circumference.getInfomation();
        }
    }
}
