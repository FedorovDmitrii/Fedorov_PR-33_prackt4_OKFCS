using Fedorov_PR_33_prackt4_OKFCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fedorov_PR_33_prackt4_OKFCS_Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_Area_Correct ()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.Area( ));
        }
        [Fact]
        public void Triangle_Perimeter_Correct ()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(12, triangle.Perimeter( ));
        }
        [Fact]
        public void Triangle_Area_Incorrect ()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(10, triangle.Perimeter( ));
        }
    }
}
