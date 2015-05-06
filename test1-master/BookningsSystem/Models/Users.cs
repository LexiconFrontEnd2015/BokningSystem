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
    
    public partial class Users
    {
        public Users()
        {
            this.Reservations = new HashSet<Reservations>();
        }
    
        public int UserId { get; set; }
        public int UserRole_UserRoleId { get; set; }
        public int CityId { get; set; }
        public int UserRoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string TelNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual UserRoles UserRoles { get; set; }
    }
}
