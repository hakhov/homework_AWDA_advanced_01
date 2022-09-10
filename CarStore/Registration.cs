using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Registration
    {
        public Registration()
        {

        }
        User user = new User();
        private static List<User> RegistratedUsers = new List<User>();
        //private static KeyValuePair<Guid, decimal> RegistrationList = new KeyValuePair<Guid,decimal>();
        public void CreateUser(User user)
        {
            RegistratedUsers.Add(user);
        }
        public User GetUser(string name)
        {
            foreach (User user in RegistratedUsers)
            {
                if (name == user.Name)
                    return user;
            }
            throw new Exception("User is not registrated!\nSession missed...\n");
            
        }

    }
}
