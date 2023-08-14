using TestTask.Lib.Exceptions.Circle;

namespace TestTask.Lib
{
    public class Circle : Shape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            if (r <=0)
            {
                throw new CircleRadiusException();
            }
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(R,2);
        }
    }
}