using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3_Rectangle
{
    class Rectangle
    {
        public double heigth;
        public double width;

        public double Area()
        {
            return heigth*width;
        }

        public double Perimetro()
        {
            return 2 * heigth * width;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(heigth, 2) + Math.Pow(width, 2));
        }
    }
}
