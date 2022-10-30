using System;
using System.Text.RegularExpressions;

namespace Delegate
{
    public delegate void MyDelegate(string people);
    class Verification
    {
        public void MyName(string people)
        {
            string peoplename = @"[A-Z]{1}[a-z]";
            if (Regex.IsMatch(people, peoplename) == false)
            {
                Console.WriteLine("Your name was entered incorrectly");
            }
        }
        public void MyLastName(string people)
        {
            string peoplelastname = @"[A-Z]{1}[a-z]";
            if (Regex.IsMatch(people, peoplelastname) == false)
            {
                Console.WriteLine("Your lastname was entered incorrectly");
            }
        }
        public void MyNumber(string people)
        {
            string phonenumber = @"^\+374\([1-9][0-9]\)[0-9]{3}\-[0-9]{3}";
            Random rnd = new Random();
            if (Regex.IsMatch(people, phonenumber) == false)
            {
                Console.WriteLine("Your number was entered incorrectly");
            }
            else
            { Console.WriteLine("Your phone verification code is " + rnd.Next(1000, 9999)); }
        }
        public void MyEmail(string people)
        {
            Random rnd = new Random();
            Console.WriteLine("Your email verification code is " + rnd.Next(1000, 9999));
        }
    }
}