using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;
using Business.Models;

namespace Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MainContext _context;

        public ProductRepository(MainContext context)
        {
            _context = context;
        }

        public Product CreateProduct(Product product)
        {
            _context.Products.Add(product);

            _context.SaveChanges();

            return product;
        }

        public List<Product> GetProductList()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int idProduct)
        {
            return _context.Products
                .FirstOrDefault(x => x.IdProduct == idProduct);
        }

        public List<ProductVm> GetProductByTenant(int idTenant)
        {
            return _context.Products
                .Where(x => x.IdTenant == idTenant)
                .Select(x => new ProductVm
                {
                    IdProduct = x.IdProduct,
                    Name = x.Name,
                    AmountOfSearch = _context.SearchProductHistories.Where(y => y.IdProduct == x.IdProduct).Select(w => w.AmountOfSearch).FirstOrDefault()
                })
                .ToList();
        }

        public SearchProductHistory GetProductHistory(int idProduct)
        {
            return _context.SearchProductHistories.FirstOrDefault(x => x.IdProduct == idProduct);
        }

        public bool CreateSearchProductHistory(SearchProductHistory newHistory)
        {
            _context.SearchProductHistories.Add(newHistory);
            return _context.SaveChanges() > 0;

        }

        public bool UpdateSearchProductHistory(SearchProductHistory searchProductHistory)
        {
            _context.SearchProductHistories.Update(searchProductHistory);

            return _context.SaveChanges()>0;
        }

        public bool CreateProductList(List<Product> fileProcess)
        {
            _context.Products.AddRange(fileProcess);

            return _context.SaveChanges() > 0;
        }

        public List<ProductVm> GetProductHistoryByTenant(int idTenant)
        {
            return _context.SearchProductHistories
                .Where(x => x.Product.IdTenant == idTenant)
                .Select(x => new ProductVm
                {
                    Name = x.Product.Name,
                    IdProduct = x.IdProduct,
                    AmountOfSearch = x.AmountOfSearch
                }).ToList();
        }

        public bool UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            return _context.SaveChanges() > 0;
        }
    }
}
