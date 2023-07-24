using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
   public  class Triangle : Figure
    {
          
        public double aS;
        public double bS;
        public double cS;

        public Triangle(double aS, double bS, double cS)
        {
            this.aS = aS;
            this.bS = bS;
            this.cS = cS;

            if (aS * aS + bS * bS == cS * cS)
            {
                Console.WriteLine("Triangle is right");
            }
            else if (aS * aS + cS * cS == bS * bS)
            {
                Console.WriteLine("Triangle is right");
            }
            else if (bS * bS + cS * cS == aS * aS)
            {
                Console.WriteLine("Triangle is right");
            }
            else
            {
                Console.WriteLine("Triangle is not right");
            }
        }
        public override double GetArea()
        {
            double p = GetPerim() / 2;
            Console.WriteLine("В GArea");
            Console.WriteLine("В GArea p = {0}",p);
          
            double Area = Math.Sqrt(p * (p - aS) * (p - bS) * (p - cS));
           /* Console.WriteLine("В GArea aS = {0}", aS );
            Console.WriteLine("В GArea  bS= {0}", bS);
            Console.WriteLine("В GArea cS = {0}", cS);

            Console.WriteLine("В GArea Area  = {0}", Area);*/

            return Area;
        }
        public override double GetPerim()
        {
            Perim = aS + bS + cS;
            return Perim;
        }

    }
}

