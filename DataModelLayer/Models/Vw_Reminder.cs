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
    
    public partial class Vw_Reminder
    {
        public int RemindID { get; set; }
        public string RemindSubject { get; set; }
        public string RemindCaption { get; set; }
        public string RemindCreatedDate { get; set; }
        public string RemindRememberDate { get; set; }
        public byte RemindIsRead { get; set; }
        public int RemindUserID { get; set; }
        public string RemindRead { get; set; }
    }
}
