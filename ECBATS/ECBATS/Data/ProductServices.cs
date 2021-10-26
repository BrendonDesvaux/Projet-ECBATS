using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECBATS.Data;
using Microsoft.EntityFrameworkCore;
using static ECBATS.Data.dbcontext;

namespace ECBATS.Data
{
    public class ProductServices
    {
        #region Private members
        private CryptoDbContext dbContext;
        #endregion

        #region Constructor
        public ProductServices(CryptoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<CryptoSaving>> GetCryptoAsync()
        {
            return await dbContext.Product.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="CryptoSaving"></param>
        /// <returns></returns>
        public async Task<CryptoSaving> AddCryptoAsync(CryptoSaving crypto)
        {
            try
            {
                dbContext.Product.Add(crypto);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return crypto;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="CryptoSaving"></param>
        /// <returns></returns>
        public async Task<CryptoSaving> UpdateProductAsync(CryptoSaving crypto)
        {
            try
            {
                var productExist = dbContext.Product.FirstOrDefault(p => p.ID == crypto.ID);
                if (productExist != null)
                {
                    dbContext.Update(crypto);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return crypto;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="CryptoSaving"></param>
        /// <returns></returns>
        public async Task DeleteProductAsync(CryptoSaving crypto)
        {
            try
            {
                dbContext.Product.Remove(crypto);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
