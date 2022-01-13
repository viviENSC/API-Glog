using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EnfcGlog.Models;

namespace EnfcGlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PouleApiController : ControllerBase
    {
        private readonly EnfcGlogContext _context;

        public PouleApiController(EnfcGlogContext context)
        {
            _context = context;
        }

        // GET: api/PouleApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Poule>>> GetPoule()
        {
            return await _context.Poule.ToListAsync();
        }

        // GET: api/PouleApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Poule>> GetPoule(int id)
        {
            var poule = await _context.Poule.FindAsync(id);

            if (poule == null)
            {
                return NotFound();
            }

            return poule;
        }

        // PUT: api/PouleApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPoule(int id, Poule poule)
        {
            if (id != poule.Id)
            {
                return BadRequest();
            }

            _context.Entry(poule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PouleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PouleApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Poule>> PostPoule(Poule poule)
        {
            _context.Poule.Add(poule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPoule", new { id = poule.Id }, poule);
        }

        // DELETE: api/PouleApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePoule(int id)
        {
            var poule = await _context.Poule.FindAsync(id);
            if (poule == null)
            {
                return NotFound();
            }

            _context.Poule.Remove(poule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PouleExists(int id)
        {
            return _context.Poule.Any(e => e.Id == id);
        }
    }
}
