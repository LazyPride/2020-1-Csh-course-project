﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolControlPanel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schoolEntities : DbContext
    {
        public schoolEntities()
            : base("name=schoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<classroom> classrooms { get; set; }
        public virtual DbSet<learning_program> learning_program { get; set; }
        public virtual DbSet<lesson_mark> lesson_mark { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<student_group> student_group { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
    }
}
