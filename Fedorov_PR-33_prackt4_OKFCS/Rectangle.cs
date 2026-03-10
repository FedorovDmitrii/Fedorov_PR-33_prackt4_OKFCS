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
