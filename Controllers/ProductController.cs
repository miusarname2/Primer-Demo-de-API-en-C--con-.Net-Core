using Demo1.Models;
using Demo1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]

        public IActionResult GetAllProduct() 
        {
            List<ProductEntity> product = this._productService.GetProducts();
            return Ok(product);
        }

        [HttpPost]

        public IActionResult CreateProduct(ProductModel product) 
        {
            _productService.createProduct(product);
            return Ok();
        }
    }
}
