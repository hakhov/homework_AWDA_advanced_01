Human human;

try
{
    human = new Human();
    //human.Name = "James0";
    human.Name = "James";
    human.Age = 19;
    Validation.ValidName(human.Name);
    Validation.ValidAge(human.Age);

}
catch (InvalidNameException ex)
{

    Console.WriteLine(ex.Message);
}
catch (InvalidAgeException ex)
{

    Console.WriteLine(ex.Message);
}