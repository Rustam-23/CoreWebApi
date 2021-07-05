using Fridge.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // ETG
        public IActionResult Index()
        {
            _productService.
            return Ok();
        }
    }
}