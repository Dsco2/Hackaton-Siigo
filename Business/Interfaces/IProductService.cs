using System.Collections.Generic;
using Business.Entities;
using Business.Models;

namespace Business.Interfaces
{
    public interface IProductService
    {
        Product CreateProduct(Product product);
        List<Product> GetProductList();
        Product GetProductById(int idProduct);
        List<ProductVm> GetProductByTenant(int idTenant);
        List<ProductVm> SearchProduct(int id, string productSearch);
    }
}
