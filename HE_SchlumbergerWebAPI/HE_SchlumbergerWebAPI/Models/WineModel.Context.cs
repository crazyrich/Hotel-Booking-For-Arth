﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HE_SchlumbergerWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HackerEarthDBEntities : DbContext
    {
        public HackerEarthDBEntities()
            : base("name=HackerEarthDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Wine> Wines { get; set; }

        public System.Data.Entity.DbSet<HE_SchlumbergerWebAPI.Models.arth_hotels> arth_hotels { get; set; }
    }
}
