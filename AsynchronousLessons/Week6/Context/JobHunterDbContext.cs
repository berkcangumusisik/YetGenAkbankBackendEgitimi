using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Common;
using Week6.Entities;

namespace Week6.Context
{
    internal class JobHunterDbContext : DbContext
    {
        public DbSet<JobPost> JobPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("");
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if(entry.State == EntityState.Added)
                {
                    ((ICreatedByEntity)entry.Entity).CreatedOn = DateTime.UtcNow;
                }
                if(entry.State == EntityState.Modified)
                {
                    ((IModififedByEntity)entry.Entity).ModifiedOn = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }

    }
}
