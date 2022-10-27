//Console.WriteLine("Mail validetion");
//Console.WriteLine(ValidMail("_asd23_@inbox.ru"));
//Console.WriteLine(ValidMail("A123_@mail.ru"));
//Console.WriteLine(ValidMail("asdf@bk.ru"));
//Console.WriteLine(ValidMail("Aasx123_8sss@inbox.ru"));
//Console.WriteLine(ValidMail("Aasx123__8@inbox.ru"));
//Console.WriteLine(ValidMail("Aasx123_.8@inbox.ru"));
//Console.WriteLine(ValidMail("asda_Adca@list.ru"));

//Console.WriteLine("______________________");
//Console.WriteLine("Link validation");
//Console.WriteLine(ValidLink("www.facebook.com"));
//Console.WriteLine(ValidLink("www.kino.am"));
//Console.WriteLine(ValidLink("facebook.com"));
//Console.WriteLine(ValidLink("www.regex101.com"));
//Console.WriteLine(ValidLink("www.c-sharpcorner.com"));

string phonenumber = "";
char symbol;

do
{
    //if (phonenumber.Length == 4)
    //{
    //    phonenumber += '(';
    //    continue;
    //}
    //if (phonenumber.Length == 7)
    //{
    //    phonenumber += ')';
    //    continue;
    //}
    //if (phonenumber.Length == 11)
    //{
    //    phonenumber += '-';
    //    continue;
    //}
    Console.Write(phonenumber);

    symbol = (Console.ReadKey().KeyChar);
    Console.Clear();

    if (Validation.IsValidPhoneNumber(phonenumber + symbol))
    {
        phonenumber += symbol;
    }
    else
    {
        Console.Clear();
    }


} while (phonenumber.Length != 15);
Console.WriteLine($"\nValid phone number: {phonenumber}");

