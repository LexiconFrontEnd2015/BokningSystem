//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookningsSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserRoles
    {
        public UserRoles()
        {
            this.Users = new HashSet<Users>();
        }
    
        public int UserRoleId { get; set; }
        public string UserRole { get; set; }
    
        public virtual ICollection<Users> Users { get; set; }
    }
}
