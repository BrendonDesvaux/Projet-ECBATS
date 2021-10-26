using System;
using System.Collections.Generic;
using ECBATS.Data;
using Microsoft.EntityFrameworkCore;

namespace ECBATS.Data
{
    public class dbcontext
    {
        public class ProductDbContext : DbContext
        {
            #region Contructor
            public ProductDbContext(DbContextOptions<ProductDbContext> options)
                    : base(options)
            {

            }
            #endregion

            #region Public properties
            public DbSet<Product> Product { get; set; }
            #endregion

            #region Overidden methods
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>().HasData(GetProducts());
                base.OnModelCreating(modelBuilder);
            }
            #endregion


            #region Private methods
            private List<Product> GetProducts()
            {
                return new List<Product>
    {
        new Product { ID = 1001, CryptoName = "Laptop", Price = "20.02", Symbol = "10", Percent24h ="50%"},
        new Product { ID = 1002, CryptoName = "Microsoft Office", Price = "20.99", Symbol = "50", Percent24h ="20%"},
        new Product { ID = 1003, CryptoName = "Lazer Mouse", Price = "12.02", Symbol = "20", Percent24h ="3%"},
        new Product { ID = 1004, CryptoName = "USB Storage", Price = "5.00", Symbol = "20", Percent24h ="95%"}
    };
            }
            #endregion
        }
    }
}
