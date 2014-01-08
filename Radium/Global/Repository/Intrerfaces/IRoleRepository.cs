using Radium.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium.Global.Repository
{
    public interface IRoleRepository : ISaveRepository
    {
        IDbSet<Role> Roles { get; }

        bool CreateRole(Role role);

        bool UpdateRole(Role role);

        bool RemoveRole(string roleName);
    }
}
