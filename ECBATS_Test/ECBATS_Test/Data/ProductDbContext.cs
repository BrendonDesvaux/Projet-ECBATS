using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECBATS_Test.Data
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
        public DbSet<CryptoSaving> Product { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CryptoSaving>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        public static List<CryptoSaving> GetProducts()
        {
            List<string> CryptoList = new List<string>();
            CryptoList = GeckoAPICall.GeckoCALL.makeAPICall();
            List<CryptoSaving> CryptoInsert = new List<CryptoSaving>();
            for (int i = 0; i < 231; i += 7)
            {

                CryptoInsert.Add(new CryptoSaving { ID = CryptoList[0+i], CryptoName = CryptoList[1 + i], Symbol = CryptoList[2 + i], Image=CryptoList[3+i], Price = CryptoList[4 + i], Percent24h = CryptoList[5 + i], Percent7j = CryptoList[6 + i] });

            }
            return CryptoInsert;
        }
    }

}

#endregion