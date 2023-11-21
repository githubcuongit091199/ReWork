
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
        public Guid Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Guid Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid Id)
        {
            throw new NotImplementedException();
        }


        public Guid Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
