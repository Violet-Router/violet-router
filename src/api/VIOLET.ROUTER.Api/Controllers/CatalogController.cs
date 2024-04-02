using Microsoft.AspNetCore.Mvc;
using VIOLET.ROUTER.Domain.Catalog;
 


namespace VIOLET.ROUTER.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {

        private readonly StoreContext _context;

        public CatalogController(StoreContext context)
        {
            _context = context;
        }
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

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            return CreatedAtAction(nameof (GetItem), new { id = 42 }, item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult AddRating(int id, Rating rating)
        {
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateItem(int id, Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            var existingItem = _context.Items.Find(id);
            if (existingItem == null)
            {
                return NotFound();
            }

            _context.Entry(existingItem).CurrentValues.SetValues(item);
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            return NoContent();
        }
    }
}
