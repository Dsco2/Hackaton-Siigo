using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;

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

        public List<Product> GetProductByTenant(int idTenant)
        {
            return _context.Products.Where(x => x.IdTenant == idTenant).ToList();
        }
    }
}
