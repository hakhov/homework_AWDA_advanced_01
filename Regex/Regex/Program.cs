using System.Text.RegularExpressions;

//Console.WriteLine("Mail validetion");
//Console.WriteLine(ValidMail("_asd23_@inbox.ru"));
//Console.WriteLine(ValidMail("A123_@mail.ru"));
//Console.WriteLine(ValidMail("asdf@bk.ru"));
//Console.WriteLine(ValidMail("Aasx123_8@inbox.ru"));
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

    if (IsValidPhoneNumber(phonenumber + symbol))
    {
        phonenumber += symbol;
    }
    else
    {
        Console.Clear();
    }


} while (phonenumber.Length != 15);
Console.WriteLine($"\nValid phone number: {phonenumber}");


static bool IsValidPhoneNumber(string item)
{
    //string pattern = @"^\+374\([1-9][0-9]\)[0-9]{3}\-[0-9]{3}";
    string[] pattern = new string[]
    {   @"^\+",
        @"^\+3",
        @"^\+37",
        @"^\+374",
        @"^\+374\(",
        @"^\+374\([1-9]",
        @"^\+374\([1-9][0-9]",
        @"^\+374\([1-9][0-9]\)",
        @"^\+374\([1-9][0-9]\)[0-9]",
        @"^\+374\([1-9][0-9]\)[0-9]{2}",
        @"^\+374\([1-9][0-9]\)[0-9]{3}",
        @"^\+374\([1-9][0-9]\)[0-9]{3}\-",
        @"^\+374\([1-9][0-9]\)[0-9]{3}\-[0-9]",
        @"^\+374\([1-9][0-9]\)[0-9]{3}\-[0-9]{2}",
        @"^\+374\([1-9][0-9]\)[0-9]{3}\-[0-9]{3}",};
    return Regex.IsMatch(item, pattern[item.Length - 1]);

}

static bool ValidLink(string link)
{
    Console.Write(link + "\t\t");
    string pattern = @"^\www.[a-zA-z0-9\-\.\{_}]{2,30}.((net)\b|(com)\b|(ru)\b|(org)\b|(am)\b)";
    return Regex.IsMatch(link, pattern);
}


//Պետք է սկսել տառով կամ թվով, կարող է պարունակել (- . _) սիմվոլները ,թվերը,տառերը ..երկարությունը 5-31 սիմվոլ
// mail.ru   internet.ru   bk.ru    inbox.ru    list.ru

// Հարց ինչպես թույլ չտալ կողք կողքի նշաններ ????????????
static bool ValidMail(string mail)
{
    Console.Write(mail + "\t\t");
    string pattern = @"^[a-zA-Z0-9][a-zA-Z0-9\-\.\{_}]{4,30}@((mail.ru)\b|(internet.ru)\b|(bk.ru)\b|(inbox.ru)\b|(list.ru)\b)";
    return Regex.IsMatch(mail, pattern);
}