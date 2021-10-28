using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECBATS_Test.Data;
using Microsoft.EntityFrameworkCore;

namespace ECBATS_Test.Data
{
    public class ProductServices
    {
        #region Private members
        private ProductDbContext dbContext;
        #endregion

        #region Constructor
        public ProductServices(ProductDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<CryptoSaving>> GetProductAsync()
        {
            return await dbContext.Product.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<CryptoSaving> AddProductAsync(CryptoSaving product)
        {
            try
            {
                dbContext.Product.Add(product);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return product;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<CryptoSaving> UpdateProductAsync(CryptoSaving product)
        {
            try
            {
                var productExist = dbContext.Product.FirstOrDefault(p => p.ID == product.ID);
                if (productExist != null)
                {
                    dbContext.Update(ProductDbContext.GetProducts());
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return product;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task DeleteProductAsync(CryptoSaving product)
        {
            try
            {
                dbContext.Product.Remove(product);
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
