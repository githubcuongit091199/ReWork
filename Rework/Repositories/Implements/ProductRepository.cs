
using Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implements
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApiDbContext _dbContext;
        public ProductRepository(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Product entity)
        {
            _dbContext.Products.Add(entity);
           
        }

        public bool Delete(Guid id)
        {
            var productToRemove = GetById(id);
            if (productToRemove != null)
            {
                _dbContext.Products.Remove(productToRemove);
                return true;
            }
            return false;
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Products;
        }

        public Product GetById(Guid Id)
        {
            return _dbContext.Products.FirstOrDefault(x=>x.Id == Id);
        }


        public void Update(Product entity)
        {
            var existingProduct = GetById(entity.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = entity.Name;
                existingProduct.Price = entity.Price;
            }
        }
    }
}
