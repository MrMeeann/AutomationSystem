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
    
    public partial class Vw_AsignmentJobs
    {
        public int AsignJobsID { get; set; }
        public int AsignUserID { get; set; }
        public int AsignJobID { get; set; }
        public string AsignAsigntedDate { get; set; }
        public string AsignDismissalDate { get; set; }
        public byte AsignStatus { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string JobsName { get; set; }
        public Nullable<int> JobsDetermineLevel { get; set; }
        public string UserFullName { get; set; }
        public string AsignStatusView { get; set; }
    }
}
