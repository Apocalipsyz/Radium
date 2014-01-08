using Radium.DBModel;
using Radium.Global.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Radium.DBModel
{
    public partial class RadiumDBEntities : IRoleRepository
    {
        IDbSet<Role> IRoleRepository.Roles
        {
            get 
            {
                return Role;
            }
        }

        public bool CreateRole(Role role)
        {
            if (Role.Any(x => x.Name == role.Name || x.Code == role.Code))
                return false;

            Role.Add(role);
            SaveChanges();
            return true;      
        }

        public bool UpdateRole(Role role)
        {
            if (!Role.Any(x => x.Id == role.Id))
                return false;

            Role updatedRole = Role.Where(x => x.Id == role.Id).First();
            updatedRole.Name = role.Name;
            updatedRole.Code = role.Code;

            Role.Load();
            SaveChanges();
            return true;
        }

        public bool RemoveRole(string roleName)
        {
            if (!Role.Any(x => x.Name == roleName))
                return false;

            Role.Remove(Role.Where(x => x.Name == roleName).First());
            return true;
        }
    }
}