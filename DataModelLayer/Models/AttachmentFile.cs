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
    
    public partial class AttachmentFile
    {
        public int AttachFileID { get; set; }
        public byte[] AttachFileData { get; set; }
        public string AttachFileName { get; set; }
        public Nullable<int> AttachFileSize { get; set; }
        public int AttachLetterID { get; set; }
    
        public virtual Letter Letter { get; set; }
    }
}
