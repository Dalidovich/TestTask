using TestTask.Lib.Exceptions.Triangle;

namespace TestTask.Lib
{
    public class Triangle : Shape
    {
        public double[] Sides { get; set; } = new double[3];

        private double? hypotenuse = null;

        public Triangle(double a,double b, double c)
        {
            if (a<=0 || b<=0 || c<=0)
            {
                throw new TriangleSideException();
            }
            if (!triangleExist(a, b, c))
            {
                throw new TriangleExistException();
            }

            Sides = new[] { a, b, c };
            isRightTriangle();
        }

        private void isRightTriangle()
        {
            if (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2))
            {
                hypotenuse = Sides[2];
            }

            if(Math.Pow(Sides[2],2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[0], 2))
            {
                hypotenuse = Sides[0];
            }
            if (Math.Pow(Sides[0],2) + Math.Pow(Sides[2], 2) == Math.Pow(Sides[1], 2))
            {
                hypotenuse = Sides[1];
            }
        }

        private bool triangleExist(params double[] sides)
        {

                return sides[0] + sides[1] > sides[2] &&
                    sides[0] + sides[2] > sides[1] &&
                    sides[2] + sides[1] > sides[0];
        }

        public override double GetArea()
        {
            if (hypotenuse != null)
            {
                var cathetus = Sides.SkipWhile(x => x == hypotenuse).ToArray();

                return cathetus[0]*cathetus[1] / 2;
            }
            var p = Sides.Sum() / 2;
            var s = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));

            return s;
        }
    }
}