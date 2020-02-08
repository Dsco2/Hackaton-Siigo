using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;
using Business.Utilities;

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

        public List<Product> GetProductByTenant(int idTenant)
        {
            return _productRepository.GetProductByTenant(idTenant);
        }

        public List<Product> SearchProduct(int id, string query)
        {
            var products = _productRepository.GetProductByTenant(id);

            var stringList = query.Split(' ').ToList();

            var productList = new List<Product>();

            foreach(var queryString in stringList)
            {
                var result = products.Where(x => x.Name.InsensitiveConvert().Contains(queryString.InsensitiveConvert()))
                    .ToList();

                if (!productList.Any())
                {
                    productList = result;    
                }

                productList = productList.Intersect(result).ToList();
            }

            return productList;
        }
    }
}
