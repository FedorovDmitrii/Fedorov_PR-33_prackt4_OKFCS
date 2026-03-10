using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedorov_PR_33_prackt4_OKFCS
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle (double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Стороны прямоугольника должна быть полоржительными.");
            }
            Width = width;
            Height = height;
        }
        public override double Area ()
        {
            return Width * Height;
        }
        public override double Perimeter ()
        {
            return 2 * (Height + Width);
        }
        public override string ToString ()
        {
            return $"Прямоугольник: {Width}x{Height}";
        }
    }
}
