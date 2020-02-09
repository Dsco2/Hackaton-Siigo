using System.Collections.Generic;
using System.IO;
using System.Linq;
using Business.Entities;
using Business.Interfaces;
using Business.Models;
using Business.Utilities;
using Microsoft.AspNetCore.Http;

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
            var product = _productRepository.GetProductById(idProduct);
            UpdateProductHistory(idProduct);
            return product;
        }

        private void UpdateProductHistory(int idProduct)
        {
            var searchProductHistory = _productRepository.GetProductHistory(idProduct);
            if (searchProductHistory != null)
            {
                searchProductHistory.AmountOfSearch++;
                _productRepository.UpdateSearchProductHistory(searchProductHistory);
            }
            else
            {
                var newHistory = new SearchProductHistory
                {
                    AmountOfSearch = 1,
                    IdProduct = idProduct
                };

                _productRepository.CreateSearchProductHistory(newHistory);
            }
        }

        public List<ProductVm> GetProductByTenant(int idTenant)
        {
            return _productRepository.GetProductByTenant(idTenant);
        }

        public List<ProductVm> SearchProduct(int id, string query)
        {
            var products = _productRepository.GetProductByTenant(id);

            var stringList = query.Split(' ').ToList();

            var productList = new List<ProductVm>();

            foreach(var queryString in stringList)
            {
                var result = products.Where(x => x.Name.InsensitiveConvert().Contains(queryString.InsensitiveConvert()))
                    .ToList();

                if (!productList.Any())
                {
                    productList = result;    
                }

                productList = productList.Intersect(result).OrderByDescending(x => x.AmountOfSearch).ToList();
            }

            return productList;
        }

        public bool SaveFile(int idTenant, IFormFile file)
        {
            var fileRead = ReadFile(file);
            var fileProcess = ProcessFile(fileRead, idTenant);

            return _productRepository.CreateProductList(fileProcess);
        }

        private List<Product> ProcessFile(List<string[]> fileRead, int idTenant)
        {            
            var fileResult = new List<Product>();

            foreach (var row in fileRead)
            {
                int.TryParse(row[2], out var ListPrice);

                var rowFile = new Product
                {
                    IdTenant = idTenant,
                    Name = row[0],
                    ListPrice = ListPrice,
                    Description = row[1]            
                };
                fileResult.Add(rowFile);
            }
            return fileResult;
        }

        private List<string[]> ReadFile(IFormFile file)
        {
            var elements = new List<string[]>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                var rows = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null) continue;
                    var values = line.Split('\n');
                    rows.AddRange(values);
                }

                rows.RemoveAt(0);

                foreach (var values in rows)
                {
                    var data = values.Split(",");
                    elements.Add(data);
                }

                return elements;
            }
        }
    }
}
