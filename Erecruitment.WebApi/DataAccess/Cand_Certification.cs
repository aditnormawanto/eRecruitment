//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Erecruitment.WebApi.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cand_Certification
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string OrgIssue { get; set; }
        public Nullable<int> YearIssue { get; set; }
        public Nullable<int> Score { get; set; }
        public byte[] Img { get; set; }
        public Nullable<long> CandidateID { get; set; }
    
        public virtual Candidate Candidate { get; set; }
    }
}