﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KapyTestData.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class databaseTest1Entities : DbContext
    {
        public databaseTest1Entities()
            : base("name=databaseTest1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Action_Records> Action_Records { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<News_Categories> News_Categories { get; set; }
        public virtual DbSet<newsTest> newsTests { get; set; }
        public virtual DbSet<newsTest3> newsTest3 { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Categories> User_Categories { get; set; }
        public virtual DbSet<User_Sources> User_Sources { get; set; }
    }
}