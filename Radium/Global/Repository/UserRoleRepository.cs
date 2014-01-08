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
            throw new NotImplementedException();
        }

        public bool UpdateUserRole(UserRole instance)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUserRole(int idUserRole)
        {
            throw new NotImplementedException();
        }
    }
}