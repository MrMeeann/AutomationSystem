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
    
    public partial class Document
    {
        public int DocID { get; set; }
        public string DocSubject { get; set; }
        public string DocCaption { get; set; }
        public string DocDate { get; set; }
        public string DocExporter { get; set; }
        public string DocDeliveryName { get; set; }
        public int DocUserID { get; set; }
        public byte[] DocFileData { get; set; }
        public Nullable<int> DocFileSize { get; set; }
        public string DocFileName { get; set; }
    
        public virtual User User { get; set; }
    }
}
