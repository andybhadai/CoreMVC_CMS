using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoBergCMS.Data;
using TechnoBergCMS.Models;

namespace TechnoBergCMS.Services
{
    public class DatabaseProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext DbContext;

        public DatabaseProductRepository(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            this.DbContext.Add(product);
            this.DbContext.SaveChanges();
        }

        public Product Find(int id)
        {
            Product product;
            product = this.DbContext.Products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return this.DbContext.Products;
        }

        public void Update(Product product)
        {
            this.DbContext.Update(product);
            this.DbContext.SaveChanges();
        }
    }
}
