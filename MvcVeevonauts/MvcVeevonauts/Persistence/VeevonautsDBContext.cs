using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcVeevonauts.Persistence;

namespace MvcVeevonauts.Models
{
    public class VeevonautsDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<VirtualVeevonaut> VirtualVeevonauts { get; set; }
        public DbSet<Item> VeevonautItems { get; set; }
        public DbSet<ItemType> VeevonautItemTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<VeevonautsDBContext, Configuration>());
        }
    }
}