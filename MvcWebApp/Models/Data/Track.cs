//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcWebApp.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Track
    {
        public Track()
        {
            this.Sessions = new HashSet<Session>();
        }
    
        public int ID { get; set; }
        public int ConferenceID { get; set; }
        public string UKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual Conference Conference { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
