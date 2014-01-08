using Radium.DBModel;
using Radium.Global.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Radium.Global.Auth
{
    public class RadiumAuthorizeAttribute : AuthorizeAttribute
    {
        private IUserRepository repository;
        public string RequiredRoles;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            repository = DependencyResolver.Current.GetService<IUserRepository>();

            if (httpContext == null) 
                throw new ArgumentNullException("httpContext");

            if (httpContext.User.Identity.IsAuthenticated == false) 
                return false;

            try
            {
                User user = repository.Users.Single(u => u.Username == httpContext.User.Identity.Name);
                return user.InRoles(RequiredRoles);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}