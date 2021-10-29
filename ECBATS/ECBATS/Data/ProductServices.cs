using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECBATS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

namespace ECBATS.Data
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
        public static string ReadData(string ID)
        {
            SqliteConnection sqlite_conn;
            sqlite_conn = new SqliteConnection("Data Source= Projet_ECBATS/ECBATS/Crypto.db");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
           
            SqliteDataReader sqlite_DataReader;
            SqliteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT "+ID+" FROM Symbol";

            sqlite_DataReader = sqlite_cmd.ExecuteReader();

            string str="";
            while (sqlite_DataReader.Read())
            {
                str = sqlite_DataReader.GetString(1);
            }
            sqlite_conn.Close();
            return str;

        }
    }
}
