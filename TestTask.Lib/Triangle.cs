namespace TestTask.Lib
{
    public class Triangle : Shape
    {
        public double[] Sides { get; set; } = new double[3];

        public Triangle(double a,double b, double c)
        {
            if (a<=0 || b<=0 || c<=0)
            {
                throw new ArgumentException("Side cannot be less than zero");
            }
            if (!triangleExist(a, b, c))
            {
                throw new ArgumentException("Triangle with such sides cannot exist");
            }

            Sides = new[] { a, b, c };
        }

        private bool triangleExist(params double[] sides)
        {
                return sides[0] + sides[1] > sides[2] &&
                    sides[0] + sides[2] > sides[1] &&
                    sides[2] + sides[1] > sides[0];
        }

        public override double GetArea()
        {
            var p = Sides.Sum() / 2;
            var s = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            return s;
        }
    }
}