using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_5.Entities;

namespace Week_5.Context
{
    public class ShopifyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("DbContext");
        }
    }
}


/**
 * Add-migration  : Yeni bir migration oluşturur. Bu migration, veritabanında yapılacak değişiklikleri içerir.
 * 
 */