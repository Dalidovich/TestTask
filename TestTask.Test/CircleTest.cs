using FluentAssertions;
using TestTask.Lib;
using TestTask.Lib.Exceptions.Circle;
using Xunit;

namespace TestTask.Test
{
    public class CircleTest
    {
        [Fact]
        public void CreateCircle_WithRightData_NewCircle()
        {
            //Arrange
            var r = 2;

            //Act
            var circle = new Circle(r);

            //Assert
            circle.Should().NotBeNull();
        }

        [Fact]
        public void CreateCircle_WithWrongData_ThrowCircleRadiusException()
        {
            //Arrange
            var r = 0;

            //Act
            Action comparison = () => { var circle = new Circle(r); };


            //Assert
            comparison.Should().Throw<CircleRadiusException>();
        }

        [Fact]
        public void FindCircleArea_WithWrongData_ThrowCircleRadiusException()
        {
            //Arrange
            var r = 0;

            //Act
            Action comparison = () =>
            {
                var circle = new Circle(r);
                var s = circle.GetArea();
            };


            //Assert
            comparison.Should().Throw<CircleRadiusException>();
        }

        [Fact]
        public void FindCircleArea_WithRightData_ReturnArea()
        {
            //Arrange
            var r = 2;
            var circle = new Circle(r);
            var expectedS = 12.566370614;

            //Act
            var s = circle.GetArea();

            //Assert
            s.Should().BeApproximately(expectedS,0.01);
        }
    }
}