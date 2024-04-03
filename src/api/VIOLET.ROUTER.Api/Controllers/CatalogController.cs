using Microsoft.AspNetCore.Mvc;
using VIOLET.ROUTER.Data;
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
           return Ok(_context.Items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = _context.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return Created($"api/catalog/{item.Id}", item);
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
