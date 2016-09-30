using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tenta3
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(string name, string password, string email)
        {
            var user = new User()
            {
                Name = name,
                Password = password,
                Email = email
            };

            return user;
        }

        public void DeleteUser(string email)
        {
            
        }

    }
      
}
