
internal class InvalidAgeException : Exception
{
	public InvalidAgeException() { }

	public InvalidAgeException(int age):base($"Invalid Age: {age}") { }
	
	
}
