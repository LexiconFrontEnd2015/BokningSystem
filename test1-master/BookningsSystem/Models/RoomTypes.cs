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
    
    public partial class RoomTypes
    {
        public RoomTypes()
        {
            this.Requests = new HashSet<Requests>();
            this.Rooms = new HashSet<Rooms>();
        }
    
        public int RoomTypeId { get; set; }
        public string TypeName { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ICollection<Requests> Requests { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
