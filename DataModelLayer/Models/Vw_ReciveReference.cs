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
    
    public partial class Vw_ReciveReference
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
        public string LetterSubject { get; set; }
        public string LetterCaption { get; set; }
        public string LetterNo { get; set; }
        public Nullable<int> LetterUserID { get; set; }
        public string LetterCreatedDate { get; set; }
        public Nullable<byte> LetterSecurityType { get; set; }
        public Nullable<byte> LetterForceType { get; set; }
        public Nullable<byte> LetterArchiveType { get; set; }
        public Nullable<byte> LetterFollowingType { get; set; }
        public Nullable<byte> LetterAttachmentType { get; set; }
        public Nullable<byte> LetterType { get; set; }
        public Nullable<byte> LetterDraftType { get; set; }
        public string LetterAbstract { get; set; }
        public Nullable<byte> LetterAnswerType { get; set; }
        public string LetterAnswerDeadLine { get; set; }
        public string LetterReffrence { get; set; }
        public Nullable<int> LetterReplyID { get; set; }
        public string View_LetterSecurityType { get; set; }
        public string View_LetterForceType { get; set; }
        public string View_LetterArchiveType { get; set; }
        public string View_LetterFollowingType { get; set; }
        public string View_LetterAttachmentType { get; set; }
        public string UserFullName { get; set; }
        public string LetterSentDate { get; set; }
        public string View_LetterAnswerType { get; set; }
        public string View_LetterDraftType { get; set; }
        public string View_LetterType { get; set; }
        public byte[] AttachFileData { get; set; }
        public string AttachFileName { get; set; }
        public Nullable<int> AttachFileSize { get; set; }
        public Nullable<byte> RefMessage { get; set; }
    }
}
