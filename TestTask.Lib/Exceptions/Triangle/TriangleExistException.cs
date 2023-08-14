namespace TestTask.Lib.Exceptions.Triangle
{
    public class TriangleExistException : LibExceptions
    {
        public TriangleExistException() : base(ExceptionConstMessage.InvalidTriangleExist)
        {
        }
        public TriangleExistException(string message) : base(message)
        {
        }
    }
}
