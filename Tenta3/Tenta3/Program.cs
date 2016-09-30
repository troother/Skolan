using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta3
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userRepository = new UserRepository();
            var user = userRepository.CreateUser();
            userRepository.DeleteUser(newUser.Email);
        }
    }
}
