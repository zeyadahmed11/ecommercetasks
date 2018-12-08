using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.Models;

namespace Task3
{
    public class BISContext : DbContext

    {
        public BISContext(DbContextOptions<BISContext>options):base(options)
        {
        }


        public DbSet<Customer> Customer { get; set; }
        public  DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<C_O> C_O { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.C_O>()
                .HasKey(sc => new { sc.O_ID, sc.P_ID });

            modelBuilder.Entity<Models.C_O>()
                .HasOne(sc => sc.Order_O)
                .WithMany(sc => sc.List_Product)
                .HasForeignKey(sc => sc.O_ID);

            modelBuilder.Entity<Models.C_O>()
                .HasOne(sc => sc.Product_PRD)
                .WithMany(sc => sc.listo)
                .HasForeignKey(sc => sc.P_ID);
        }
        }
}
