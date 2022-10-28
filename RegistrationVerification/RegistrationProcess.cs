using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegistrationVerification
{
    public delegate void Sender(string message);
    public class RegistrationProcess
    {
        public static List<User> Users = new List<User>();
        //Action Sender(string a);
        Sender Sender;

        public void Registration()
        {
            var user = RegistrUser();
            if (user != null)
            {
                Sender.Invoke("registration sucssefull");
                Users.Add(user);
            }
            else
            {
                RegistrUser();
            }
        }


        public User RegistrUser()
        {
            string Email = "";
            bool isEmail=false;
            bool isphone=false;
            string phone = "";
            do
            {
                Console.Clear();
                Console.Write("Please enter Phone Number or Email for Login =>");
                string variable = Console.ReadLine();
                if (isEmail = Regex.IsMatch(variable, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {
                    Email = variable;

                }
                // if (isphone = Regex.IsMatch(variable = Console.ReadLine(), @"^([\+]?374[-]?[1-9][0-9]{7}$"))
                //{
                //    phone = variable;

                //}

            }
            while (isEmail == false /*&& isphone == false*/);

            string Password = "";
            do
            {
               

                Console.Write("Please  enter password at least 6 digits =>");
                Password = Console.ReadLine();
            } while (Password.Length < 6);

            var user = new User(Email, Password);

            //user.Notify($"{Email} registration sucssefull");

            Sender = user.Notify;

            return user;
        }


    }
}
