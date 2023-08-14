namespace TestTask.Lib.Exceptions
{
    public class LibExceptions : Exception
    {

        public LibExceptions(string message) : base(message)
        {
        }

        public LibExceptions() : base("exception in Lib")
        {
        }
    }
}
