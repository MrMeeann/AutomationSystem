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
    
    public partial class SentNote
    {
        public int SentNoteID { get; set; }
        public int SentNoteSendedNoteID { get; set; }
        public int SentNoteUserID { get; set; }
    
        public virtual Note Note { get; set; }
        public virtual User User { get; set; }
    }
}
