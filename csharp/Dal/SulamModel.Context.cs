﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SulamEntities1 : DbContext
    {
        public SulamEntities1()
            : base("name=SulamEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<authorizations> authorizations { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<ParameterReport> ParameterReport { get; set; }
        public virtual DbSet<PersonalFile> PersonalFile { get; set; }
        public virtual DbSet<professionType> professionType { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Treatment> Treatment { get; set; }
        public virtual DbSet<TypeOfParameterToReport> TypeOfParameterToReport { get; set; }
        public virtual DbSet<typeReport> typeReport { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
    }
}
