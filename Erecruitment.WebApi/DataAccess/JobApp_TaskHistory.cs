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
    
    public partial class JobApp_TaskHistory
    {
        public long ID { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> DtmCreate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> DtmUpdate { get; set; }
        public Nullable<long> TaskID { get; set; }
    
        public virtual JobApp_Task JobApp_Task { get; set; }
    }
}
