namespace Tracking51API;

public class Tracking51Exception : Exception
{
    public Tracking51Exception() : base("")
    {
    }

    public Tracking51Exception(string message) : base(message)
    {
    }

    public Tracking51Exception(string message, Exception innerException) : base(message, innerException)
    {
    }
}