using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface IProductService
    {
        Product CreateProduct(Product product);
        List<Product> GetProductList();
        Product GetProductById(int idProduct);
        Product GetProductByTenant(int idTenant);
    }
}
