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
    
    public partial class Cand_AdditionalInfo
    {
        public long ID { get; set; }
        public Nullable<int> ExpectedSalary { get; set; }
        public string PreferedLocation { get; set; }
        public string Available { get; set; }
        public string Hobby { get; set; }
        public Nullable<long> CandidateID { get; set; }
    
        public virtual Candidate Candidate { get; set; }
    }
}
