using System;

namespace RegistrationVerification
{
    public class User
    {
        public string Login { get; set; }

        public string Pass { get; set; }

        public User(string login, string pass)
        {
            this.Login = login;
            this.Pass = pass;
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
