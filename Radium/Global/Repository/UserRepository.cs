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
            if (User.Any(x => x.Username == instance.Username))
                return false;

            User.Add(instance);
            SaveChanges();
            return true;
        }

        public bool UpdateUser(User instance)
        {
            return true;
        }

        public bool RemoveUser(string username)
        {
            if (!User.Any(x => x.Username == username))
                return false;

            User.Remove(User.Where(x => x.Username == username).First());
            return true;
        }

        public User GetUser(string username)
        {
            return User.FirstOrDefault(p => string.Compare(p.Username, username, true) == 0);
        }

        public User Login(string username, string password)
        {
            return User.FirstOrDefault(p => string.Compare(p.Username, username, true) == 0 && p.Password == password);
        }
    }
}