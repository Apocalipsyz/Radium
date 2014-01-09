using Radium.DBModel;
using Radium.Global.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Radium.DBModel
{
    public partial class RadiumDBEntities : IUserRoleRepository
    {
        IDbSet<UserRole> IUserRoleRepository.UserRoles
        {
            get
            {
                return UserRole;
            }
        }

        public bool CreateUserRole(UserRole instance)
        {
            if (UserRole.Any(x => x.RoleId == instance.RoleId && x.UserId == instance.UserId))
                return false;

            UserRole.Add(instance);
            return true;
        }

        public bool UpdateUserRole(UserRole instance)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUserRole(int userRoleId)
        {
            if (!UserRole.Any(x => x.Id == userRoleId))
                return false;

            UserRole.Remove(UserRole.FirstOrDefault(x => x.Id == userRoleId));
            return true;
        }
    }
}