﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace location
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LocationEntities : DbContext
    {
        public LocationEntities()
            : base("name=LocationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Loue> Loue { get; set; }
        public virtual DbSet<Marque> Marque { get; set; }
        public virtual DbSet<Vehicule> Vehicule { get; set; }
    }
}
