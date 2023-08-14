using TestTask.Lib;

namespace TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(2);
            Console.WriteLine($"circle S - {circle.GetArea()}");

            Shape triangle = new Triangle(2,2,1);
            Console.WriteLine($"triangle S - {triangle.GetArea()}");
        }
    }
}