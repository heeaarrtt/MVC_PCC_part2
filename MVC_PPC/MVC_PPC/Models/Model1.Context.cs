﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_PPC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PPCDBEntities : DbContext
    {
        public PPCDBEntities()
            : base("name=PPCDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Full_Contract> Full_Contract { get; set; }
        public virtual DbSet<Installment_Contract> Installment_Contract { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Property_Service> Property_Service { get; set; }
        public virtual DbSet<Property_Status> Property_Status { get; set; }
        public virtual DbSet<Property_Type> Property_Type { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}