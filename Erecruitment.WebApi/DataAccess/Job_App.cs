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
    
    public partial class Job_App
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job_App()
        {
            this.JobApp_Phase = new HashSet<JobApp_Phase>();
        }
    
        public long ID { get; set; }
        public Nullable<System.DateTime> AppliedDate { get; set; }
        public Nullable<long> VacancyID { get; set; }
        public Nullable<long> CandidateID { get; set; }
    
        public virtual Candidate Candidate { get; set; }
        public virtual Job_Vacancy Job_Vacancy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobApp_Phase> JobApp_Phase { get; set; }
    }
}
