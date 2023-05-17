using LS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        User Auntheticate(string username, string password);

        User Register(User user);

        User UpdateUserPass(int userID, User user);
    }
}
