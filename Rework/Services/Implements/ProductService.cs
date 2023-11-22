using DTOs;
using Entities;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ApiDbContext _apiDbContext;
        public ProductService(IProductRepository productRepository, ApiDbContext apiDbContext)
        {
            _productRepository = productRepository;
            _apiDbContext = apiDbContext;
        }

        public Guid CreateProduct(CreateProductModel model)
        {
            throw new NotImplementedException();
        }

        public ProductModel GetProductById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetProducts(PaginationProductRequest request)
        {
            throw new NotImplementedException();
        }

        public Guid UpdateProduct(UpdateProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
