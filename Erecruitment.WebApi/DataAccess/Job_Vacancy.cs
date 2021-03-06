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
    
    public partial class Job_Vacancy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job_Vacancy()
        {
            this.Job_App = new HashSet<Job_App>();
            this.Job_Desc = new HashSet<Job_Desc>();
            this.Job_Requirement = new HashSet<Job_Requirement>();
        }
    
        public long ID { get; set; }
        public string Experience { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
        public string IsActive { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> DtmCreate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> DtmUpdate { get; set; }
        public string Position { get; set; }
        public string Lvl { get; set; }
        public string City { get; set; }
        public Nullable<long> JobTitleID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_App> Job_App { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Desc> Job_Desc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Requirement> Job_Requirement { get; set; }
        public virtual Job_Title Job_Title { get; set; }
    }
}
