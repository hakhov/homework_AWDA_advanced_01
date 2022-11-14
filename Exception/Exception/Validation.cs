
using System.Text.RegularExpressions;

internal class Validation
{
    public static void ValidName(string name)
    {
        Regex regex=new Regex("^[a-zA-Z]+$");
        if (!regex.IsMatch(name))
        {
            throw new InvalidNameException(name);
        } 
    }

    public static void ValidAge(int age)
    {
        if (age < 18 || age > 100) throw new InvalidAgeException(age);
            
    }
}