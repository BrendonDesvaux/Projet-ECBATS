using System;
using System.Collections.Generic;
using ECBATS.Data;
using Microsoft.EntityFrameworkCore;

namespace ECBATS.Data
{
    public class dbcontext
    {
        public class CryptoDbContext : DbContext
        {
            #region Contructor
            public CryptoDbContext(DbContextOptions<CryptoDbContext> options)
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
                modelBuilder.Entity<CryptoSaving>().HasData(InsertCryptos());
                base.OnModelCreating(modelBuilder);
                

            }
            #endregion
           


            public static List<CryptoSaving> InsertCryptos()
            {
                List<string> CryptoList = new List<string>();
                CryptoList = GeckoAPICall.GeckoCALL.makeAPICall();
                List<CryptoSaving> CryptoInsert = new List<CryptoSaving>();
                for (int i = 0; i < 231; i += 6)
                {

                  CryptoInsert.Add(new CryptoSaving { ID = 1+i, Symbol = CryptoList[1 + i], CryptoName = CryptoList[2 + i], Price = CryptoList[3 + i], Percent24h = CryptoList[4 + i], Percent7j = CryptoList[5 + i]});

                }
                return CryptoInsert;
            }
            }

            }

            
        }
    
