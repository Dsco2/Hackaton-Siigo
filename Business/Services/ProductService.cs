using System.Collections.Generic;
using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }

        public List<Product> GetProductList()
        {
            return _productRepository.GetProductList();
        }

        public Product GetProductById(int idProduct)
        {
            return _productRepository.GetProductById(idProduct);
        }

        public Product GetProductByTenant(int idTenant)
        {
            return _productRepository.GetProductByTenant(idTenant);
        }
    }
}
