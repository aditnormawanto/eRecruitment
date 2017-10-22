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
    
    public partial class Candidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Candidate()
        {
            this.Cand_AdditionalInfo = new HashSet<Cand_AdditionalInfo>();
            this.Cand_Certification = new HashSet<Cand_Certification>();
            this.Cand_Course = new HashSet<Cand_Course>();
            this.Cand_Education = new HashSet<Cand_Education>();
            this.Cand_EmergencyContact = new HashSet<Cand_EmergencyContact>();
            this.Cand_FamilyAndSpouse = new HashSet<Cand_FamilyAndSpouse>();
            this.Cand_JobExp = new HashSet<Cand_JobExp>();
            this.Cand_Language = new HashSet<Cand_Language>();
            this.Cand_OrganizationalHistory = new HashSet<Cand_OrganizationalHistory>();
            this.Cand_Reference = new HashSet<Cand_Reference>();
            this.Cand_Skill = new HashSet<Cand_Skill>();
            this.Job_App = new HashSet<Job_App>();
            this.Ref_User = new HashSet<Ref_User>();
        }
    
        public long ID { get; set; }
        public Nullable<long> IDCardNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BirthPlace { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Addr { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public Nullable<int> Zipcode { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public Nullable<long> TaxRegistrationNo { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<int> Height { get; set; }
        public byte[] Photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_AdditionalInfo> Cand_AdditionalInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_Certification> Cand_Certification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_Course> Cand_Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_Education> Cand_Education { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_EmergencyContact> Cand_EmergencyContact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_FamilyAndSpouse> Cand_FamilyAndSpouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_JobExp> Cand_JobExp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_Language> Cand_Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_OrganizationalHistory> Cand_OrganizationalHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_Reference> Cand_Reference { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cand_Skill> Cand_Skill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_App> Job_App { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ref_User> Ref_User { get; set; }
    }
}
