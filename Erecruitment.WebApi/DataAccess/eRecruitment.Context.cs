﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eRecruitmentEntities : DbContext
    {
        public eRecruitmentEntities()
            : base("name=eRecruitmentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cand_AdditionalInfo> Cand_AdditionalInfo { get; set; }
        public virtual DbSet<Cand_Certification> Cand_Certification { get; set; }
        public virtual DbSet<Cand_Course> Cand_Course { get; set; }
        public virtual DbSet<Cand_Education> Cand_Education { get; set; }
        public virtual DbSet<Cand_EmergencyContact> Cand_EmergencyContact { get; set; }
        public virtual DbSet<Cand_FamilyAndSpouse> Cand_FamilyAndSpouse { get; set; }
        public virtual DbSet<Cand_JobExp> Cand_JobExp { get; set; }
        public virtual DbSet<Cand_Language> Cand_Language { get; set; }
        public virtual DbSet<Cand_OrganizationalHistory> Cand_OrganizationalHistory { get; set; }
        public virtual DbSet<Cand_Reference> Cand_Reference { get; set; }
        public virtual DbSet<Cand_Skill> Cand_Skill { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandJobExp_Benefit> CandJobExp_Benefit { get; set; }
        public virtual DbSet<CandJobExp_Responsibility> CandJobExp_Responsibility { get; set; }
        public virtual DbSet<Co_Directorat> Co_Directorat { get; set; }
        public virtual DbSet<Co_Divition> Co_Divition { get; set; }
        public virtual DbSet<Co_Section> Co_Section { get; set; }
        public virtual DbSet<Co_SubDivition> Co_SubDivition { get; set; }
        public virtual DbSet<Emp_Position> Emp_Position { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job_App> Job_App { get; set; }
        public virtual DbSet<Job_Desc> Job_Desc { get; set; }
        public virtual DbSet<Job_Requirement> Job_Requirement { get; set; }
        public virtual DbSet<Job_Title> Job_Title { get; set; }
        public virtual DbSet<Job_Vacancy> Job_Vacancy { get; set; }
        public virtual DbSet<JobApp_Phase> JobApp_Phase { get; set; }
        public virtual DbSet<JobApp_Task> JobApp_Task { get; set; }
        public virtual DbSet<JobApp_TaskAttender> JobApp_TaskAttender { get; set; }
        public virtual DbSet<JobApp_TaskHistory> JobApp_TaskHistory { get; set; }
        public virtual DbSet<Ref_Master> Ref_Master { get; set; }
        public virtual DbSet<Ref_User> Ref_User { get; set; }
        public virtual DbSet<Ref_UserEmployee> Ref_UserEmployee { get; set; }
        public virtual DbSet<DATA_WILAYAH_INDONESIA> DATA_WILAYAH_INDONESIA { get; set; }
        public virtual DbSet<REF_KODEPOS> REF_KODEPOS { get; set; }
    }
}
