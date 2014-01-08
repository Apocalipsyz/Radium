//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Radium.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserRole = new HashSet<UserRole>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public Nullable<System.DateTime> ActivationDate { get; set; }
        public string ActivationLink { get; set; }
        public Nullable<System.DateTime> LastVisitDate { get; set; }
        public string AvatarPath { get; set; }
    
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
