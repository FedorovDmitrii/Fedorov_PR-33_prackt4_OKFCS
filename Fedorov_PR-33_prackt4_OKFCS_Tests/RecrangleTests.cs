using Fedorov_PR_33_prackt4_OKFCS;

namespace Fedorov_PR_33_prackt4_OKFCS_Tests
{
    public class RecrangleTests
    {
        [Fact]
        public void Rectangle_Area_Correct ()
        {
            var rectangle = new Rectangle(5, 10);
            Assert.Equal(50, rectangle.Area( ));
        }
        [Fact]
        public void Rectangle_Perimeter_Correct ()
        {
            var rectangle = new Rectangle(5, 10);
            Assert.Equal(30, rectangle.Perimeter( ));
        }
        [Theory]
        [InlineData(-1, 5)]
        [InlineData(0, 5)]
        [InlineData(5, -3)]
        public void Rectangle_WrongData_ThrowException (double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }
    }
}