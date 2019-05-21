using System;
using Xunit;
using ConsoleApp6.Abstracts;


namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateCircleArea()
        {
            const double expectedValue = 19.634954084936208;



            var sut = new ConsoleApp6.Figures.Circle(2.5);
            var result = sut.CalculateArea();

            Assert.Equal(expectedValue, result);
        }


        [Fact]
        public void CalculateTriangleSquare()
        {
            const double expectedValue = 9.9215674164922145;

           

            var sut = new ConsoleApp6.Figures.Triangle(4, 5, 6);
            var result = sut.CalculateArea();

            Assert.Equal(expectedValue, result);
        }


        [Fact]
        public void ItShouldBeRightTriangle()
        {
            

           

            var sut = new ConsoleApp6.Figures.Triangle(3,4,5);
            var result = sut.IsRightTriangle();
            

           
            Assert.True(result);
        }
    }
}
