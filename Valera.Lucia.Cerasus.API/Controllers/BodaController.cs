using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Valera.Lucia.Cerasus.API.DataBase;
using Valera.Lucia.Cerasus.API.Models;

namespace Valera.Lucia.Cerasus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodaController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public BodaController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/Boda
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Boda>>> GetBodas()
        {
            return await _context.Bodas.ToListAsync();
        }

        // GET: api/Boda/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Boda>> GetBoda(int id)
        {
            var boda = await _context.Bodas.FindAsync(id);

            if (boda == null)
            {
                return NotFound();
            }

            return boda;
        }

        // PUT: api/Boda/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoda(int id, Boda boda)
        {
            if (id != boda.Id)
            {
                return BadRequest();
            }

            _context.Entry(boda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BodaExists(id))
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

        // POST: api/Boda
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Boda>> PostBoda(Boda boda)
        {
            _context.Bodas.Add(boda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoda", new { id = boda.Id }, boda);
        }

        // DELETE: api/Boda/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoda(int id)
        {
            var boda = await _context.Bodas.FindAsync(id);
            if (boda == null)
            {
                return NotFound();
            }

            _context.Bodas.Remove(boda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BodaExists(int id)
        {
            return _context.Bodas.Any(e => e.Id == id);
        }
    }
}
