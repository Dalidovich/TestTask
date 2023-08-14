namespace TestTask.Lib.Exceptions.Circle
{
    public class CircleRadiusException : LibExceptions
    {
        public CircleRadiusException() : base(ExceptionConstMessage.InvalidRadiusInCircle)
        {
        }
        public CircleRadiusException(string message) : base(message)
        {
        }
    }
}
