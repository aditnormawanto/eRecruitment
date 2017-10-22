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
    
    public partial class Job_Title
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job_Title()
        {
            this.Emp_Position = new HashSet<Emp_Position>();
            this.Job_Vacancy = new HashSet<Job_Vacancy>();
        }
    
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string IsActive { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> DtmCreate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> DtmUpdate { get; set; }
        public Nullable<long> SectionID { get; set; }
    
        public virtual Co_Section Co_Section { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emp_Position> Emp_Position { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Vacancy> Job_Vacancy { get; set; }
    }
}
