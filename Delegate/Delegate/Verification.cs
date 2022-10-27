

delegate int Verificate(string contact);
internal class Verification
{
    Random random = new Random();
    public int EmailVerification(string email)
    {
        Console.Write($"{email} verification code: ");
        return random.Next(1000, 9999);
    }

    public int PhoneVerification(string phone)
    {
        Console.Write($"{phone} verification code: ");
        return random.Next(1000, 9999);
    }
}