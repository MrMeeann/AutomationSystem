//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLog
    {
        public int LogID { get; set; }
        public string LogUserPcName { get; set; }
        public string LogUserIPAddress { get; set; }
        public string LogUserEnterDate { get; set; }
        public string LogUserExitDate { get; set; }
        public int LogUserID { get; set; }
    
        public virtual User User { get; set; }
    }
}
