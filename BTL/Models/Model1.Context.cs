﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IVYmodaONLINEEntities : DbContext
    {
        public IVYmodaONLINEEntities()
            : base("name=IVYmodaONLINEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<tb_Adv> tb_Adv { get; set; }
        public virtual DbSet<tb_Category> tb_Category { get; set; }
        public virtual DbSet<tb_New> tb_New { get; set; }
        public virtual DbSet<tb_Order> tb_Order { get; set; }
        public virtual DbSet<tb_OrderDetail> tb_OrderDetail { get; set; }
        public virtual DbSet<tb_Post> tb_Post { get; set; }
        public virtual DbSet<tb_Product> tb_Product { get; set; }
        public virtual DbSet<tb_ProductCategory> tb_ProductCategory { get; set; }
        public virtual DbSet<tb_Subscrice> tb_Subscrice { get; set; }
    }
}
