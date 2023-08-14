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
        public void CreateCircle_WithWrongData_ThrowArgumentException()
        {
            //Arrange
            var r = 0;

            //Act
            Action comparison = () => { var circle = new Circle(r); };


            //Assert
            comparison.Should().Throw<CircleRadiusException>();
        }
    }
}