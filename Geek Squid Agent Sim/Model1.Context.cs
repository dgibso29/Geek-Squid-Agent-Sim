﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeekSquidAgentSim
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MainDB : DbContext
    {
        public MainDB()
            : base("name=MainDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Suspect> Suspects { get; set; }
        public virtual DbSet<Trait> Traits { get; set; }
        public virtual DbSet<FirstName> FirstNames { get; set; }
        public virtual DbSet<LastName> LastNames { get; set; }
    }
}
