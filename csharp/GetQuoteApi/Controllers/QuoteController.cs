using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetQuoteApi.Models;

namespace GetQuoteApi.Controllers
{
    [Route("api/Quote")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly GetQuoteContext _context;

        public QuoteController(GetQuoteContext context)
        {
            _context = context;

            if (_context.Quotes.Count() == 0)
            {
                // Create a new Quote if collection is empty,
                // which means you can't delete all Quotes.
                _context.Quotes.Add(new Quote
                {
                    Author = "David Allen",
                    Description = "You can do anything, but not everything.",
                    IsFamous = true
                });
                _context.SaveChanges();
            }
        }


        // GET: api/Quote
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quote>>> GetQuotes()
        {
            return await _context.Quotes.ToListAsync();
        }

        // GET: api/Quote/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quote>> GetQuote(long id)
        {
            var quote = await _context.Quotes.FindAsync(id);

            if (quote == null)
            {
                return NotFound();
            }

            return quote;
        }

        // POST: api/Quote
        [HttpPost]
        public async Task<ActionResult<Quote>> PostQuote(Quote item)
        {
            _context.Quotes.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetQuote), new { id = item.Id }, item);
        }

        // PUT: api/Quote/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuote(long id, Quote item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Quote/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuote(long id)
        {
            var quote = await _context.Quotes.FindAsync(id);

            if (quote == null)
            {
                return NotFound();
            }

            _context.Quotes.Remove(quote);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}