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
    
    public partial class Staff
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string title { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        public string UpdatedBy { get; set; }
    }
}
