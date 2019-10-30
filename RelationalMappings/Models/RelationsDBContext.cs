using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RelationalMappings.Models
{
    public class RelationsDBContext: DbContext
    {

        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Alien> Aliens { get; set; }
        public DbSet<Human> Humans { get; set; }
        public DbSet<ICosmicMammal> CosmicMammals { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Mobile>()
           .HasMany<Contact>(m => m.Contacts)
           .WithRequired(c => c.Mobile);

            modelBuilder.Entity<Mobile>()
           .HasRequired(m => m.Manufacturer)
           .WithRequiredPrincipal(mn=>mn.Mobile);

            modelBuilder.Entity<Mobile>()
          .HasRequired(m => m.Category)
          .WithRequiredPrincipal(c => c.Mobile);
        
            modelBuilder.Entity<ICosmicMammal>()
         .HasMany<Mobile>(h => h.Mobiles)
         .WithRequired(m => m.Owner);

        }
    }
}