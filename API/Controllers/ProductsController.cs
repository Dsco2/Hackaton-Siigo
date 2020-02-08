using API.Models;
using Business.Entities;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //Products/createProduct
        [HttpPost("createProduct")]
        public IActionResult CreateProduct(Product product)
        {
            if(product == null)
            {
                return BadRequest();
            }

            var productResponse = _productService.CreateProduct(product);

            return productResponse == null
                ? StatusCode(500)
                : (IActionResult) Ok(productResponse);
        }

        //Products/getProductsList
        [HttpGet("getProductsList")]
        public IActionResult GetProductsList()
        {
            var productResponse = _productService.GetProductList();

            return productResponse == null
                ? StatusCode(500)
                : (IActionResult) Ok(productResponse);
        }

        //products/getProductsByid/1
        [HttpGet("getProductsById/{idProduct}")]
        public IActionResult GetProductById(int idProduct)
        {
            var productResponse = _productService.GetProductById(idProduct);

            return productResponse == null
                ? StatusCode(500)
                : (IActionResult) Ok(productResponse);
        }

        //products/getProductsByTenant/1
        [HttpGet("getProductsByTenant/{idTenant}")]
        public IActionResult GetProductBytenant(int idTenant)
        {
            var productResponse = _productService.GetProductByTenant(idTenant);

            return productResponse == null
                ? StatusCode(500)
                : (IActionResult) Ok(productResponse);
        }

        [HttpPost("search-products")]
        public IActionResult SearchProducts(SearchVm search)
        {
            var productList = _productService.SearchProduct(search.Id, search.query);

            return Ok(productList);
        }
    }
}
