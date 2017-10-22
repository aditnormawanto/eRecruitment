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
    
    public partial class JobApp_Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobApp_Task()
        {
            this.JobApp_TaskAttender = new HashSet<JobApp_TaskAttender>();
            this.JobApp_TaskHistory = new HashSet<JobApp_TaskHistory>();
        }
    
        public long ID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string IssueTime { get; set; }
        public Nullable<long> PhaseID { get; set; }
        public Nullable<long> CandidateID { get; set; }
    
        public virtual JobApp_Phase JobApp_Phase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobApp_TaskAttender> JobApp_TaskAttender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobApp_TaskHistory> JobApp_TaskHistory { get; set; }
    }
}
