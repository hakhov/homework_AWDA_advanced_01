
abstract class Human
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

}