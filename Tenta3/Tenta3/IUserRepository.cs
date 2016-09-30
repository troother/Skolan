using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta3
{
    public interface IUserRepository
    {
        User CreateUser(string Name, string Password, string Email);

        void DeleteUser(string Email);
    }
}
