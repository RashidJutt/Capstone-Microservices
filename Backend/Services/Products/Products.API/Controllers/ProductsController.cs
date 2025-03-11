using Microsoft.AspNetCore.Mvc;
using Products.API.Application.DtoModels;

namespace Products.API.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
    public IActionResult GetProducts()
    {
        var products = new List<ProductDto>
        {
            new ProductDto { ProductId = 1, ProductNumber = "P001", ProductName = "Product 1" },
            new ProductDto { ProductId = 2, ProductNumber = "P002", ProductName = "Product 2" }
        };
        return Ok(products);
    }
}
