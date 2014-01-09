using Radium.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium.Global.Repository
{
    public interface IUserRepository : ISaveRepository
    {
        IDbSet<User> Users { get; }

        bool CreateUser(User instance);

        bool UpdateUser(User instance);

        bool RemoveUser(string username);

        User GetUser(string username);

        User Login(string username, string password);
    }
}
