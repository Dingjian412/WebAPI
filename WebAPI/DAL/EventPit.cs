//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventPit
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int PitStopID { get; set; }
        public System.DateTime Createdtime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual Event Event { get; set; }
    }
}
