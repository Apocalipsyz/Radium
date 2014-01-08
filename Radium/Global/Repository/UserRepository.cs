using Radium.DBModel;
using Radium.Global.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Radium.DBModel
{
    public partial class RadiumDBEntities : IUserRepository
    {
        IDbSet<User> IUserRepository.Users 
        { 
            get
            {
                return User;
            }
        }

        public bool CreateUser(User instance)
        {
            return true;
        }

        public bool UpdateUser(User instance)
        {
            return true;
        }

        public bool RemoveUser(int idUser)
        {
            return true;
        }

        public User GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}