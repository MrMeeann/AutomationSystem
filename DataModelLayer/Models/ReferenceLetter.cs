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
    
    public partial class ReferenceLetter
    {
        public int RefID { get; set; }
        public int RefLetterID { get; set; }
        public int RefSenderUserID { get; set; }
        public int RefReciverUserID { get; set; }
        public string RefDate { get; set; }
        public Nullable<int> RefReadType { get; set; }
        public string RefCaption { get; set; }
        public Nullable<int> RefLevelNumber { get; set; }
        public Nullable<byte> RefMessage { get; set; }
    
        public virtual Letter Letter { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
