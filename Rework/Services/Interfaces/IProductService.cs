using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetProducts(PaginationProductRequest request);
        ProductModel GetProductById(Guid id);
        Guid CreateProduct(CreateProductModel model);
        Guid UpdateProduct(UpdateProductModel model);
    }
}
