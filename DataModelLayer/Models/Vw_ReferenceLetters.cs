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
    
    public partial class Vw_ReferenceLetters
    {
        public int RefLetterID { get; set; }
        public Nullable<int> RefLevelNumber { get; set; }
        public int RefReciverUserID { get; set; }
        public int RefSenderUserID { get; set; }
        public string RefDate { get; set; }
        public string RefCaption { get; set; }
        public Nullable<int> RefReadType { get; set; }
        public int RefID { get; set; }
        public string View_RefReadType { get; set; }
        public string RefReciver_FullName { get; set; }
        public string RefSender_FullName { get; set; }
        public Nullable<byte> RefMessage { get; set; }
    }
}
