using System.Text.RegularExpressions;

class Validation
{
    public static bool ValidLink(string link)
    {
        Console.Write(link + "\t\t");
        string pattern = @"^\www.[a-zA-z0-9\-\.\{_}]{2,30}.((net)\b|(com)\b|(ru)\b|(org)\b|(am)\b)";
        return Regex.IsMatch(link, pattern);
    }


    //Պետք է սկսել տառով կամ թվով, կարող է պարունակել (- . _) սիմվոլները ,թվերը,տառերը ..երկարությունը 5-31 սիմվոլ
    // mail.ru   internet.ru   bk.ru    inbox.ru    list.ru

    // Հարց ինչպես թույլ չտալ կողք կողքի նշաններ ????????????
    public static bool ValidMail(string mail)
    {
        Console.Write(mail + "\t\t");
        string pattern = @"^[\w|\\.|\\-|\\_][^\\_]{4,30}@((mail.ru)\b|(internet.ru)\b|(bk.ru)\b|(inbox.ru)\b|(list.ru)\b)";
        return Regex.IsMatch(mail, pattern);
    }



    public static bool IsValidPhoneNumber(string item)
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
}

