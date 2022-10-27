Console.Write("Enter your name: ");
string? name = Console.ReadLine();
Console.Write("Enter your email: ");
string? email = Console.ReadLine();
Console.Write("Enter your phone: ");
string? phone = Console.ReadLine();

Verification obj = new Verification();
Verificate emailverification = new Verificate(obj.EmailVerification);
Verificate phoneverification = new Verificate(obj.PhoneVerification);

VerificationCode(email, emailverification);
VerificationCode(phone, phoneverification);


static void VerificationCode(string contact, Verificate verificate)
{
    Console.WriteLine(verificate.Invoke(contact));
}



