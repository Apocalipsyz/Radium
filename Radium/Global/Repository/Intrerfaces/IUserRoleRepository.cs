using Radium.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium.Global.Repository
{
    public interface IUserRoleRepository : ISaveRepository
    {
        IDbSet<UserRole> UserRoles { get; }

        bool CreateUserRole(UserRole instance);

        bool UpdateUserRole(UserRole instance);

        bool RemoveUserRole(int userRoleId);
    }
}
