using System.Collections.Generic;
using Business.Entities;
using Business.Models;

namespace Business.Interfaces
{
    public interface IProductRepository
    {
        Product CreateProduct(Product product);
        List<Product> GetProductList();
        Product GetProductById(int idProduct);
        List<ProductVm> GetProductByTenant(int idTenant);
        SearchProductHistory GetProductHistory(int idProduct);
        bool CreateSearchProductHistory(SearchProductHistory newHistory);
        bool UpdateSearchProductHistory(SearchProductHistory searchProductHistory);
        bool CreateProductList(List<Product> fileProcess);
        List<ProductVm> GetProductHistoryByTenant(int idTenant);
    }
}
