using FluentAssertions;
using TestTask.Lib;
using TestTask.Lib.Exceptions.Triangle;
using Xunit;

namespace TestTask.Test
{
    public class TriangleTest
    {
        [Fact]
        public void CreateTriangle_WithRightData_NewTriangle()
        {
            //Arrange
            var a = 2;
            var b = 3;
            var c = 4;

            //Act
            var triangle = new Triangle(a, b, c);

            //Assert
            triangle.Should().NotBeNull();
        }

        [Fact]
        public void CreateTriangle_WithNegativeSide_ThrowTriangleSideException()
        {
            //Arrange
            var a = -2;
            var b = 3;
            var c = 4;

            //Act
            Action comparison = () => { var triangle = new Triangle(a, b, c); };

            //Assert
            comparison.Should().Throw<TriangleSideException>();
        }

        [Fact]
        public void CreateTriangle_WithNonexistentTriangleSide_ThrowTriangleExistException()
        {
            //Arrange
            var a = 2000;
            var b = 3;
            var c = 4;

            //Act
            Action comparison = () => { var triangle = new Triangle(a, b, c); };

            //Assert
            comparison.Should().Throw<TriangleExistException>();
        }

        [Fact]
        public void FindTriangleArea_WithRightData_ReturnArea()
        {
            //Arrange
            var a = 2;
            var b = 3;
            var c = 4;
            var triangle = new Triangle(a, b, c);
            var expectedS = 2.905;


            //Act
            var s = triangle.GetArea();

            //Assert
            s.Should().BeApproximately(expectedS,0.01);
        }

        [Fact]
        public void FindTriangleArea_WithNegativeSide_ThrowTriangleSideException()
        {
            //Arrange
            var a = -2;
            var b = 3;
            var c = 4;

            //Act
            Action comparison = () => 
            {
                var triangle = new Triangle(a, b, c); 
                var s = triangle.GetArea();
            };

            //Assert
            comparison.Should().Throw<TriangleSideException>();
        }

        [Fact]
        public void FindTriangleArea_WithNonexistentTriangleSide_ThrowTriangleExistException()
        {
            //Arrange
            var a = 2000;
            var b = 3;
            var c = 4;

            //Act
            Action comparison = () =>
            {
                var triangle = new Triangle(a, b, c);
                var s = triangle.GetArea();
            };

            //Assert
            comparison.Should().Throw<TriangleExistException>();
        }

        [Fact]
        public void FindRightTriangleArea_WithRightData_ReturnArea()
        {
            //Arrange
            var a = 15;
            var b = 8;
            var c = 17;
            var triangle = new Triangle(a, b, c);
            var expectedS = 60;


            //Act
            var s = triangle.GetArea();

            //Assert
            s.Should().BeApproximately(expectedS, 0.01);
        }
    }
}