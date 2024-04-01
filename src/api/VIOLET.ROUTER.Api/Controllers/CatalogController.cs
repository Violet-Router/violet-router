using Microsoft.AspNetCore.Mvc;
using VIOLET.ROUTER.Domain.Catalog;

namespace VIOLET.ROUTER.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new[]
            {
                new Item(name: "Item 1", description: "Description 1", brand: "Brand 1", price: 100.00m ),
                new Item(name: "Item 2", description: "Description 2", brand: "Brand 2", price: 200.00m ),
                new Item(name: "Item 3", description: "Description 3", brand: "Brand 3", price: 300.00m ),
                new Item(name: "Item 4", description: "Description 4", brand: "Brand 4", price: 400.00m ),
                new Item(name: "Item 5", description: "Description 5", brand: "Brand 5", price: 500.00m ),
            };
            return Ok(items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = new Item ("Item 1", "Description 1", "Brand 1", 100.00m)
            {
                Id = id
            };

            return Ok(item);
        }
    }
}
