namespace TestTask.Lib.Exceptions.Triangle
{
    public class TriangleSideException : LibExceptions
    {
        public TriangleSideException() : base(ExceptionConstMessage.InvalidSideInTriangle)
        {
        }
        public TriangleSideException(string message) : base(message)
        {
        }
    }
}
