using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Radium.DBModel;
using System.Web.Mvc;
using Radium.Global.Repository;

namespace Radium.DBModel
{
    public partial class User
    {
        private IUserRoleRepository repository;

        public static string GetActivateUrl()
        {
            return Guid.NewGuid().ToString("N");      
        }

        public string ConfirmPassword { get; set; }

        public bool InRoles(string roles)
        {
            repository = DependencyResolver.Current.GetService<IUserRoleRepository>();

            if (string.IsNullOrWhiteSpace(roles))
            {
                return false;
            }

            var rolesArray = roles.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var role in rolesArray)
            {
                var hasRole = repository.UserRoles.Any(p => string.Compare(p.Role.Code, role, true) == 0);
                if (hasRole)
                {
                    return true;
                }
            }
            return false;
        }
    }
}