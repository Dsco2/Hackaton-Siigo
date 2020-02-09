using System.Collections.Generic;
using Business.Entities;
using Business.Models;
using Microsoft.AspNetCore.Http;

namespace Business.Interfaces
{
    public interface IProductService
    {
        Product CreateProduct(Product product);
        List<Product> GetProductList();
        Product GetProductById(int idProduct);
        List<ProductVm> GetProductByTenant(int idTenant);
        List<ProductVm> SearchProduct(int id, string productSearch);
        bool SaveFile(int idTenant, IFormFile file);
        List<ProductVm> GetProductHistoryByTenant(int idTenant);
    }
}
