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
    
    public partial class Co_Divition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Co_Divition()
        {
            this.Co_SubDivition = new HashSet<Co_SubDivition>();
        }
    
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string IsActive { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> DtmCreate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> DtmUpdate { get; set; }
        public Nullable<long> DirID { get; set; }
    
        public virtual Co_Directorat Co_Directorat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Co_SubDivition> Co_SubDivition { get; set; }
    }
}
