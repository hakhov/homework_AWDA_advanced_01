
internal class InvalidNameException : Exception
{
    public InvalidNameException() { }
    public InvalidNameException(string name) : base($"Invalid person name: {name}") { }
}
