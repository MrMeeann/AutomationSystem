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
    
    public partial class Vw_ReciveNotes
    {
        public string NoteSubject { get; set; }
        public string NoteContext { get; set; }
        public string NoteCreateDate { get; set; }
        public int NoteUserID { get; set; }
        public string CreatorFullName { get; set; }
        public int SentNoteID { get; set; }
        public int NoteReciverID { get; set; }
        public int SentNoteSendedNoteID { get; set; }
        public string ReciverFullName { get; set; }
    }
}
