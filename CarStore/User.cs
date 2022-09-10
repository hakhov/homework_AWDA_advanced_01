using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class User
    {
        public Guid Id { get; } = new Guid();
        public string Name { get; set; }
        public string LastName { get; set; }
        public  decimal Wallet { get; set; }

        public User()
        {

        }
        public User(string name,string lastName, decimal wallet)
        {
            Name = name;
            LastName = lastName;
            Wallet = wallet;
        }

        public void Pay(int price,User user)
        {
            
            if (user.Wallet >= price)
            {
                user.Wallet -= price;
                Console.WriteLine($"It is paid '$'{price} from the wallet\nUser: {user.ToString()}\nBalance: {user.Wallet}");
            }
            else
            {
                Console.WriteLine("The transaction declines\nThere are not enough money in the wallet.");
            }
        }
        public override string ToString()
        {
            return $"_ _ _ _ _ _ _ _\nUser: {Name} {LastName}\n _ _ _ _ _ _ _ _ ";
        }
    }
}
